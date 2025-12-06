using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace GestionPharmacie
{
    public partial class Accueil : Form
    {
        SqlConnection sqlConnection;
        private DataTable dataTable;
        private int currentPage = 1;
        private int pageSize = 20;
        private int totalRecords = 0;
        private ListBox listBoxFournisseurs;
        // In the constructor, modify the listBoxFournisseurs initialization:
        public Accueil()
        {
            InitializeComponent();
            sqlConnection = Connexion.connecter();

            // Create and configure the suppliers listbox
            listBoxFournisseurs = new ListBox
            {
                Location = new Point(1350, 532), // Position it below the alerts panel
                Size = new Size(624, 300),
                BackColor = Color.White,
                Font = new Font("Segoe UI", 9F),
                ForeColor = Color.FromArgb(0, 122, 204),
                Visible = false // Start hidden
            };

            // Add a title label for the suppliers section
            Label lblFournisseursTitle = new Label
            {
                Location = new Point(1350, 532),
                Size = new Size(624, 40),
                BackColor = Color.FromArgb(46, 204, 113),
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                ForeColor = Color.White,
                Text = "📞 Fournisseurs Disponibles",
                TextAlign = ContentAlignment.MiddleCenter,
                Visible = false,
                Name = "lblFournisseursTitle"
            };

            this.Controls.Add(lblFournisseursTitle);
            listBoxFournisseurs.Location = new Point(1350, 572);
            this.Controls.Add(listBoxFournisseurs);

            // Lier l'événement de sélection de l'alerte
            listBoxAlertes.MouseClick += ListBoxAlertes_MouseClick;
        }

        private void Accueil_Load(object sender, EventArgs e)
        {
            ChargerStatistiques();
            ChargerMedicaments();
            ChargerAlertesPeremption();
            ChargerGraphiqueCategories();
            ConfigurerDataGridView();
        }
    

        private void ConfigurerDataGridView()
        {
            // Double-clic pour modifier
            gridview.CellDoubleClick += (s, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    btnModifier_Click(s, e);
                }
            };

            // Coloration des lignes selon le stock
            gridview.CellFormatting += GridView_CellFormatting;
        }

        private void GridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (gridview.Columns[e.ColumnIndex].Name == "QuantitéTotale" && e.RowIndex >= 0)
            {
                if (e.Value != null && int.TryParse(e.Value.ToString(), out int quantite))
                {
                    if (quantite == 0)
                    {
                        e.CellStyle.BackColor = Color.FromArgb(255, 200, 200); // Rouge clair
                        e.CellStyle.ForeColor = Color.DarkRed;
                        e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                    }
                    else if (quantite < 10)
                    {
                        e.CellStyle.BackColor = Color.FromArgb(255, 235, 180); // Orange clair
                        e.CellStyle.ForeColor = Color.DarkOrange;
                    }
                    else
                    {
                        e.CellStyle.BackColor = Color.FromArgb(200, 255, 200); // Vert clair
                        e.CellStyle.ForeColor = Color.DarkGreen;
                    }
                }
            }
        }

        private void ChargerFournisseursPourMedicament(string medicamentNom)
        {
            try
            {
                string sql = @"SELECT DISTINCT f.nom, f.telephone, f.email
                        FROM lot l
                        INNER JOIN fournisseur f ON l.fournisseur_id = f.id
                        INNER JOIN medicament m ON l.medicament_id = m.id
                        WHERE m.nom = @nom AND l.quantite_stock > 0";

                SqlCommand cmd = new SqlCommand(sql, sqlConnection);
                cmd.Parameters.AddWithValue("@nom", medicamentNom);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show($"Aucun fournisseur trouvé pour: {medicamentNom}",
                                  "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string message = $"Fournisseurs disponibles pour '{medicamentNom}':\n\n";
                    foreach (DataRow row in dt.Rows)
                    {
                        message += $"📦 {row["nom"]}\n";
                        message += $"   📞 Tel: {row["telephone"]}\n";
                        if (row["email"] != DBNull.Value && !string.IsNullOrEmpty(row["email"].ToString()))
                        {
                            message += $"   📧 Email: {row["email"]}\n";
                        }
                        message += "\n";
                    }

                    MessageBox.Show(message, "Fournisseurs Disponibles",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des fournisseurs : " + ex.Message,
                               "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ListBoxAlertes_MouseClick(object sender, MouseEventArgs e)
        {
            int index = listBoxAlertes.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                string selectedAlert = listBoxAlertes.Items[index].ToString();
                string medicamentNom = selectedAlert.Split('(')[0].Trim();
                ChargerFournisseursPourMedicament(medicamentNom);
            }
        }

        private void ChargerStatistiques()
        {
            try
            {
                sqlConnection.Open();

                // Total médicaments
                string sqlTotal = "SELECT COUNT(*) FROM medicament";
                SqlCommand cmdTotal = new SqlCommand(sqlTotal, sqlConnection);
                int totalMedicaments = (int)cmdTotal.ExecuteScalar();
                lblTotalMedicaments.Text = totalMedicaments.ToString();

                // Valeur du stock
                string sqlValeur = @"SELECT ISNULL(SUM(l.quantite_stock * m.prix_achat), 0) 
                                    FROM lot l 
                                    INNER JOIN medicament m ON l.medicament_id = m.id";
                SqlCommand cmdValeur = new SqlCommand(sqlValeur, sqlConnection);
                decimal valeurStock = (decimal)cmdValeur.ExecuteScalar();
                lblValeurStock.Text = valeurStock.ToString("N2") + " DH";

                // Alertes stock faible
                string sqlAlertes = @"
                                    SELECT COUNT(*)
                                            FROM (
                                                SELECT m.id, ISNULL(SUM(l.quantite_stock),0) AS total_stock, MIN(l.seuil_alerte) AS seuil
                                                FROM medicament m
                                                LEFT JOIN lot l 
                                                    ON m.id = l.medicament_id
                                                    AND l.date_peremption > GETDATE()
                                                GROUP BY m.id
                                                HAVING ISNULL(SUM(l.quantite_stock),0) < ISNULL(MIN(l.seuil_alerte),10)
                                            ) AS t;";

                SqlCommand cmdAlertes = new SqlCommand(sqlAlertes, sqlConnection);
                int alertes = (int)(cmdAlertes.ExecuteScalar() ?? 0); // <-- safely handle null

                lblAlertes.Text = alertes.ToString();


                // Lots expirés ou à expirer dans 30 jours
                string sqlPeremption = @"SELECT COUNT(*) FROM lot 
                                        WHERE date_peremption <= DATEADD(day, 30, GETDATE()) 
                                        AND date_peremption >= GETDATE()";
                SqlCommand cmdPeremption = new SqlCommand(sqlPeremption, sqlConnection);
                int lotsPeremption = (int)cmdPeremption.ExecuteScalar();
                lblPeremption.Text = lotsPeremption.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des statistiques : " + ex.Message);
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                    sqlConnection.Close();
            }
        }

        private void ChargerMedicaments()
        {
            try
            {
                Medicament medicament = new Medicament();
                dataTable = medicament.ListerAvecQuantite();
                totalRecords = dataTable.Rows.Count;

                AfficherPage();
                UpdatePaginationInfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des médicaments : " + ex.Message);
            }
        }

        private void AfficherPage()
        {
            if (dataTable == null) return;

            var pageData = dataTable.AsEnumerable()
                .Skip((currentPage - 1) * pageSize)
                .Take(pageSize)
                .CopyToDataTable();

            gridview.DataSource = pageData;

            // Configuration des colonnes
            if (gridview.Columns.Contains("id"))
                gridview.Columns["id"].Visible = false;

            if (gridview.Columns.Contains("Nom"))
                gridview.Columns["Nom"].Width = 200;

            if (gridview.Columns.Contains("Référence"))
                gridview.Columns["Référence"].Width = 120;

            if (gridview.Columns.Contains("Catégorie"))
                gridview.Columns["Catégorie"].Width = 150;

            if (gridview.Columns.Contains("PrixVente"))
            {
                gridview.Columns["PrixVente"].HeaderText = "Prix de vente (DH)";
                gridview.Columns["PrixVente"].DefaultCellStyle.Format = "N2";
            }

            if (gridview.Columns.Contains("QuantitéTotale"))
            {
                gridview.Columns["QuantitéTotale"].HeaderText = "Quantité disponible";
                gridview.Columns["QuantitéTotale"].Width = 150;
            }

            gridview.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 247, 255);
            gridview.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 122, 204);
            gridview.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridview.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            gridview.EnableHeadersVisualStyles = false;
        }

        private void UpdatePaginationInfo()
        {
            int totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
            lblPagination.Text = $"Page {currentPage} sur {totalPages} ({totalRecords} médicaments)";

            btnPrevious.Enabled = currentPage > 1;
            btnNext.Enabled = currentPage < totalPages;
        }

        private void ChargerAlertesPeremption()
        {
            try
            {
                string sql = @"SELECT TOP 5 m.nom, l.numero_lot, l.date_peremption, l.quantite_stock
                              FROM lot l
                              INNER JOIN medicament m ON l.medicament_id = m.id
                              WHERE l.date_peremption <= DATEADD(day, 30, GETDATE()) 
                              AND l.date_peremption >= GETDATE()
                              AND l.quantite_stock > 0
                              ORDER BY l.date_peremption ASC";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, sqlConnection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                listBoxAlertes.Items.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    DateTime datePeremption = Convert.ToDateTime(row["date_peremption"]);
                    int joursRestants = (datePeremption - DateTime.Now).Days;
                    string alerte = $"{row["nom"]} (Lot: {row["numero_lot"]}) - Expire dans {joursRestants} jours - Stock: {row["quantite_stock"]}";
                    listBoxAlertes.Items.Add(alerte);
                }

                if (listBoxAlertes.Items.Count == 0)
                {
                    listBoxAlertes.Items.Add("Aucune alerte de péremption");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des alertes : " + ex.Message);
            }
        }

        private void ChargerGraphiqueCategories()
        {
            try
            {
                string sql = @"SELECT TOP 10 m.categorie, SUM(l.quantite_stock) as total
                              FROM medicament m
                              LEFT JOIN lot l ON m.id = l.medicament_id
                              WHERE m.categorie IS NOT NULL AND m.categorie != ''
                              GROUP BY m.categorie
                              ORDER BY total DESC";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, sqlConnection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                listBoxCategories.Items.Clear();

                if (dt.Rows.Count == 0)
                {
                    listBoxCategories.Items.Add("Aucune catégorie trouvée");
                    return;
                }

                foreach (DataRow row in dt.Rows)
                {
                    string categorie = row["categorie"].ToString();
                    int total = row["total"] != DBNull.Value ? Convert.ToInt32(row["total"]) : 0;
                    string item = $"{categorie.PadRight(25)} → {total} unités";
                    listBoxCategories.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des catégories : " + ex.Message);
            }
        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            if (dataTable == null) return;

            string recherche = txtRecherche.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(recherche))
            {
                currentPage = 1;
                AfficherPage();
                UpdatePaginationInfo();
                return;
            }

            try
            {
                var filteredRows = dataTable.AsEnumerable()
                    .Where(row =>
                        row["Nom"].ToString().ToLower().Contains(recherche) ||
                        row["Référence"].ToString().ToLower().Contains(recherche) ||
                        row["Catégorie"].ToString().ToLower().Contains(recherche)
                    );

                if (filteredRows.Any())
                {
                    DataTable filteredTable = filteredRows.CopyToDataTable();
                    gridview.DataSource = filteredTable;
                    lblPagination.Text = $"{filteredTable.Rows.Count} résultat(s) trouvé(s)";
                }
                else
                {
                    gridview.DataSource = null;
                    lblPagination.Text = "Aucun résultat trouvé";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la recherche : " + ex.Message);
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                AfficherPage();
                UpdatePaginationInfo();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
            if (currentPage < totalPages)
            {
                currentPage++;
                AfficherPage();
                UpdatePaginationInfo();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ChargerStatistiques();
            ChargerMedicaments();
            ChargerAlertesPeremption();
            ChargerGraphiqueCategories();
            txtRecherche.Clear();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            //FormAjouterMedicament f = new FormAjouterMedicament();
            //f.ShowDialog();
            //btnRefresh_Click(sender, e);
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (gridview.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un médicament à supprimer.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(gridview.SelectedRows[0].Cells["id"].Value);
            string nom = gridview.SelectedRows[0].Cells["Nom"].Value.ToString();

            DialogResult res = MessageBox.Show($"Voulez-vous vraiment supprimer le médicament '{nom}' ?\n\nAttention: Cette action est irréversible!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (res == DialogResult.Yes)
            {
                try
                {
                    sqlConnection.Open();

                    // Vérifier s'il y a des lots associés
                    string checkQuery = "SELECT COUNT(*) FROM lot WHERE medicament_id = @id";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, sqlConnection);
                    checkCmd.Parameters.AddWithValue("@id", id);
                    int lotsCount = (int)checkCmd.ExecuteScalar();

                    if (lotsCount > 0)
                    {
                        DialogResult deleteLotsRes = MessageBox.Show($"Ce médicament a {lotsCount} lot(s) associé(s).\n\nVoulez-vous également supprimer ces lots ?", "Lots associés", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                        if (deleteLotsRes == DialogResult.Cancel)
                        {
                            return;
                        }
                        else if (deleteLotsRes == DialogResult.Yes)
                        {
                            string deleteLots = "DELETE FROM lot WHERE medicament_id = @id";
                            SqlCommand deleteLotCmd = new SqlCommand(deleteLots, sqlConnection);
                            deleteLotCmd.Parameters.AddWithValue("@id", id);
                            deleteLotCmd.ExecuteNonQuery();
                        }
                    }

                    string query = "DELETE FROM medicament WHERE id = @id";
                    SqlCommand cmd = new SqlCommand(query, sqlConnection);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    sqlConnection.Close();

                    MessageBox.Show("Médicament supprimé avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnRefresh_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la suppression : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (sqlConnection.State == ConnectionState.Open)
                        sqlConnection.Close();
                }
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (gridview.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un médicament à modifier.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(gridview.SelectedRows[0].Cells["id"].Value);

            //FormModifierMedicament f = new FormModifierMedicament(id);
            //f.ShowDialog();
            //btnRefresh_Click(sender, e);
        }

        private void cmbFiltre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dataTable == null) return;

            string filtre = cmbFiltre.SelectedItem?.ToString();

            if (filtre == "Tous" || string.IsNullOrEmpty(filtre))
            {
                currentPage = 1;
                AfficherPage();
                UpdatePaginationInfo();
                return;
            }

            try
            {
                DataView dv = new DataView(dataTable);

                switch (filtre)
                {
                    case "Stock faible (< 10)":
                        dv.RowFilter = "QuantitéTotale < 10";
                        break;
                    case "Stock épuisé":
                        dv.RowFilter = "QuantitéTotale = 0";
                        break;
                    case "Stock normal (≥ 10)":
                        dv.RowFilter = "QuantitéTotale >= 10";
                        break;
                }

                gridview.DataSource = dv.ToTable();
                lblPagination.Text = $"{dv.Count} médicament(s) affiché(s)";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du filtrage : " + ex.Message);
            }
        }

        private void lblValeurStockTitle_Click(object sender, EventArgs e)
        {

        }

        private void ajouterMedicamentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjouterMedicament f = new AjouterMedicament();
            f.Show();
            this.Hide();
        }

        private void modifierMedicamentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifierMedicament f = new ModifierMedicament();
            f.Show();
            this.Hide();
        }

        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccueilClient f = new AccueilClient();
            f.Show();
            this.Hide();
        }

        private void gridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ajouterUnLotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjouterLot f = new AjouterLot();
            f.Show();
            this.Hide();
        }

        private void commandesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccueilCommande f = new AccueilCommande();
            f.Show();
            this.Hide();
        }

       
    }
}