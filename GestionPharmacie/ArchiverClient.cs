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
    public partial class ArchiverClient : Form
    {
        private DataTable clientsTable;

        public ArchiverClient()
        {
            InitializeComponent();
            LoadClients();
            SetupEventHandlers();
        }

        private void SetupEventHandlers()
        {
            btnArchiver.Click += BtnArchiver_Click;
            btnDesarchiver.Click += BtnDesarchiver_Click;
            btnFermer.Click += (s, e) => this.Close();
            comboStatut.SelectedIndexChanged += ComboStatut_SelectedIndexChanged;
        }

        private void LoadClients()
        {
            try
            {
                SqlConnection connection = Connexion.connecter();
                string sql = @"SELECT id, nom_complet AS 'Nom', 
                              telephone AS 'Téléphone', 
                              adresse AS 'Adresse',
                              CASE WHEN est_actif = 1 THEN 'Actif' ELSE 'Archivé' END AS 'Statut',
                              est_actif
                              FROM client 
                              ORDER BY nom_complet";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                clientsTable = new DataTable();
                adapter.Fill(clientsTable);

                guna2DataGridView1.DataSource = clientsTable;

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

                connection.Close();
                ApplyFilter();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des clients: " + ex.Message,
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ComboStatut_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void ApplyFilter()
        {
            if (clientsTable == null) return;

            try
            {
                DataView dv = clientsTable.DefaultView;
                
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
                MessageBox.Show("Veuillez sélectionner un client à archiver.",
                    "Sélection requise", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int clientId = Convert.ToInt32(guna2DataGridView1.SelectedRows[0].Cells["id"].Value);
            string clientNom = guna2DataGridView1.SelectedRows[0].Cells["Nom"].Value.ToString();
            bool estActif = Convert.ToBoolean(guna2DataGridView1.SelectedRows[0].Cells["est_actif"].Value);

            if (!estActif)
            {
                MessageBox.Show("Ce client est déjà archivé.",
                    "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Êtes-vous sûr de vouloir archiver le client '{clientNom}'?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                UpdateClientStatus(clientId, false);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void BtnDesarchiver_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un client à désarchiver.",
                    "Sélection requise", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int clientId = Convert.ToInt32(guna2DataGridView1.SelectedRows[0].Cells["id"].Value);
            string clientNom = guna2DataGridView1.SelectedRows[0].Cells["Nom"].Value.ToString();
            bool estActif = Convert.ToBoolean(guna2DataGridView1.SelectedRows[0].Cells["est_actif"].Value);

            if (estActif)
            {
                MessageBox.Show("Ce client est déjà actif.",
                    "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Êtes-vous sûr de vouloir désarchiver le client '{clientNom}'?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                UpdateClientStatus(clientId, true);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void UpdateClientStatus(int clientId, bool estActif)
        {
            try
            {
                SqlConnection connection = Connexion.connecter();
                string sql = "UPDATE client SET est_actif = @EstActif WHERE id = @Id";

                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@EstActif", estActif);
                    cmd.Parameters.AddWithValue("@Id", clientId);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }

                MessageBox.Show(
                    estActif ? "Client désarchivé avec succès!" : "Client archivé avec succès!",
                    "Succès",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadClients(); // Refresh the grid
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la mise à jour: " + ex.Message,
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
