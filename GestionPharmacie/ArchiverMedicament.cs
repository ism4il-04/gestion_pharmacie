using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace GestionPharmacie
{
    public partial class ArchiverMedicament : Form
    {
        private DataTable medicamentsTable;

        public ArchiverMedicament()
        {
            InitializeComponent();
            LoadMedicaments();
            SetupEventHandlers();
        }

        private void SetupEventHandlers()
        {
            btnArchiver.Click += BtnArchiver_Click;
            btnDesarchiver.Click += BtnDesarchiver_Click;
            btnFermer.Click += (s, e) => this.Close();
            comboStatut.SelectedIndexChanged += ComboStatut_SelectedIndexChanged;
        }

        private void LoadMedicaments()
        {
            try
            {
                SqlConnection connection = Connexion.connecter();
                string sql = @"SELECT m.id, 
                              m.nom AS 'Nom', 
                              m.reference AS 'Référence',
                              m.categorie AS 'Catégorie',
                              m.prix_vente AS 'Prix Vente',
                              CASE WHEN m.est_actif = 1 THEN 'Actif' ELSE 'Archivé' END AS 'Statut',
                              m.est_actif
                              FROM medicament m
                              ORDER BY m.nom";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                medicamentsTable = new DataTable();
                adapter.Fill(medicamentsTable);

                guna2DataGridView1.DataSource = medicamentsTable;

                // Hide the est_actif column (we use Statut instead)
                if (guna2DataGridView1.Columns["est_actif"] != null)
                {
                    guna2DataGridView1.Columns["est_actif"].Visible = false;
                }

                // Hide ID column
                if (guna2DataGridView1.Columns["id"] != null)
                {
                    guna2DataGridView1.Columns["id"].Visible = false;
                }

                // Format price column
                if (guna2DataGridView1.Columns["Prix Vente"] != null)
                {
                    guna2DataGridView1.Columns["Prix Vente"].DefaultCellStyle.Format = "N2";
                }

                connection.Close();
                ApplyFilter();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des médicaments: " + ex.Message,
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ComboStatut_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void ApplyFilter()
        {
            if (medicamentsTable == null) return;

            try
            {
                DataView dv = medicamentsTable.DefaultView;
                
                if (comboStatut.SelectedIndex == 1) // Actifs
                {
                    dv.RowFilter = "est_actif = 1";
                }
                else if (comboStatut.SelectedIndex == 2) // Archivés
                {
                    dv.RowFilter = "est_actif = 0";
                }
                else // Tous
                {
                    dv.RowFilter = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du filtrage: " + ex.Message,
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnArchiver_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un médicament à archiver.",
                    "Sélection requise", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int medicamentId = Convert.ToInt32(guna2DataGridView1.SelectedRows[0].Cells["id"].Value);
            string medicamentNom = guna2DataGridView1.SelectedRows[0].Cells["Nom"].Value.ToString();
            bool estActif = Convert.ToBoolean(guna2DataGridView1.SelectedRows[0].Cells["est_actif"].Value);

            if (!estActif)
            {
                MessageBox.Show("Ce médicament est déjà archivé.",
                    "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Êtes-vous sûr de vouloir archiver le médicament '{medicamentNom}'?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                UpdateMedicamentStatus(medicamentId, false);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void BtnDesarchiver_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un médicament à désarchiver.",
                    "Sélection requise", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int medicamentId = Convert.ToInt32(guna2DataGridView1.SelectedRows[0].Cells["id"].Value);
            string medicamentNom = guna2DataGridView1.SelectedRows[0].Cells["Nom"].Value.ToString();
            bool estActif = Convert.ToBoolean(guna2DataGridView1.SelectedRows[0].Cells["est_actif"].Value);

            if (estActif)
            {
                MessageBox.Show("Ce médicament est déjà actif.",
                    "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Êtes-vous sûr de vouloir désarchiver le médicament '{medicamentNom}'?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                UpdateMedicamentStatus(medicamentId, true);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void UpdateMedicamentStatus(int medicamentId, bool estActif)
        {
            try
            {
                SqlConnection connection = Connexion.connecter();
                string sql = "UPDATE medicament SET est_actif = @EstActif WHERE id = @Id";

                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@EstActif", estActif);
                    cmd.Parameters.AddWithValue("@Id", medicamentId);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }

                MessageBox.Show(
                    estActif ? "Médicament désarchivé avec succès!" : "Médicament archivé avec succès!",
                    "Succès",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadMedicaments(); // Refresh the grid
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la mise à jour: " + ex.Message,
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
