using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace GestionPharmacie
{
    public partial class Accueil : Form
    {
        SqlConnection sqlConnection;

        public Accueil()
        {
            InitializeComponent();
            sqlConnection = Connexion.connecter();
        }

        private void Accueil_Load(object sender, EventArgs e)
        {
            ChargerMedicaments();
        }

        private void ChargerMedicaments()
        {
            try
            {
                Medicament medicament = new Medicament();
                DataTable table = medicament.ListerAvecQuantite();
                MessageBox.Show("Nombre de lignes : " + table.Rows.Count);
                gridview.DataSource = table;
                gridview.Columns["id"].Visible = false; // on masque l’ID
                gridview.Columns["Nom"].Width = 200;
                gridview.Columns["Référence"].Width = 120;
                gridview.Columns["Catégorie"].Width = 150;
                gridview.Columns["PrixVente"].HeaderText = "Prix de vente (DH)";
                gridview.Columns["QuantitéTotale"].HeaderText = "Quantité disponible";
                gridview.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(240, 247, 255);
                gridview.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(0, 122, 204);
                gridview.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
                gridview.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
                gridview.EnableHeadersVisualStyles = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des médicaments : " + ex.Message);
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                    sqlConnection.Close();
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            //FormAjouterMedicament f = new FormAjouterMedicament();
            //f.ShowDialog();
            //ChargerMedicaments();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (gridview.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un médicament à supprimer.");
                return;
            }

            int id = Convert.ToInt32(gridview.SelectedRows[0].Cells["id"].Value);

            DialogResult res = MessageBox.Show("Voulez-vous vraiment supprimer ce médicament ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                try
                {
                    sqlConnection.Open();
                    string query = "DELETE FROM medicament WHERE id = @id";
                    SqlCommand cmd = new SqlCommand(query, sqlConnection);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Médicament supprimé avec succès !");
                    ChargerMedicaments();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (gridview.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un médicament à modifier.");
                return;
            }

            int id = Convert.ToInt32(gridview.SelectedRows[0].Cells["id"].Value);
            string nom = gridview.SelectedRows[0].Cells["nom"].Value.ToString();
            string type = gridview.SelectedRows[0].Cells["type"].Value.ToString();

            //FormModifierMedicament f = new FormModifierMedicament(id, nom, type);
            //f.ShowDialog();
            ChargerMedicaments();
        }
    }
}
