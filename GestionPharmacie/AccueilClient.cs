using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionPharmacie
{
    public partial class AccueilClient : Form
    {
        SqlConnection sqlConnection;
        private DataTable dataTable;

        public AccueilClient()
        {
            InitializeComponent();
            sqlConnection = Connexion.connecter();
            StyleForm();
            ChargerClients();
            LoadStatistics();
        }

        private void StyleForm()
        {
            // Set form properties
            this.BackColor = Color.FromArgb(240, 244, 248);

            // Style the DataGridView
            gunaDataGridViewClients.BorderStyle = BorderStyle.None;
            gunaDataGridViewClients.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
            gunaDataGridViewClients.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gunaDataGridViewClients.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 122, 204);
            gunaDataGridViewClients.DefaultCellStyle.SelectionForeColor = Color.White;
            gunaDataGridViewClients.BackgroundColor = Color.White;
            gunaDataGridViewClients.EnableHeadersVisualStyles = false;
            gunaDataGridViewClients.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            gunaDataGridViewClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gunaDataGridViewClients.ReadOnly = true;
            gunaDataGridViewClients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gunaDataGridViewClients.MultiSelect = false;
            gunaDataGridViewClients.AllowUserToAddRows = false;
            gunaDataGridViewClients.AllowUserToDeleteRows = false;
        }

        public void ChargerClients()
        {
            try
            {
                Client client = new Client();
                dataTable = client.Lister();
                gunaDataGridViewClients.DataSource = dataTable;

                // Hide ID column if exists
                if (gunaDataGridViewClients.Columns["id"] != null)
                {
                    gunaDataGridViewClients.Columns["id"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des clients : " + ex.Message,
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadStatistics()
        {
            try
            {
                SqlConnection connection = Connexion.connecter();

                // Get total clients count
                string sqlCount = "SELECT COUNT(*) FROM client";
                SqlCommand cmdCount = new SqlCommand(sqlCount, connection);
                connection.Open();
                int totalClients = (int)cmdCount.ExecuteScalar();
                connection.Close();

                // Get new clients this month
                string sqlNewClients = @"SELECT COUNT(*) FROM client 
                                        WHERE MONTH(date_creation) = MONTH(GETDATE()) 
                                        AND YEAR(date_creation) = YEAR(GETDATE())";
                SqlCommand cmdNewClients = new SqlCommand(sqlNewClients, connection);
                connection.Open();
                int newClients = (int)cmdNewClients.ExecuteScalar();
                connection.Close();

                // Get active clients (clients with orders)
                string sqlActiveClients = "SELECT COUNT(DISTINCT client_id) FROM commande";
                SqlCommand cmdActiveClients = new SqlCommand(sqlActiveClients, connection);
                connection.Open();
                int activeClients = (int)cmdActiveClients.ExecuteScalar();
                connection.Close();

                // Get inactive clients
                string sqlInactiveClients = @"SELECT COUNT(*) FROM client 
                                             WHERE id NOT IN (SELECT DISTINCT client_id FROM commande)";
                SqlCommand cmdInactiveClients = new SqlCommand(sqlInactiveClients, connection);
                connection.Open();
                int inactiveClients = (int)cmdInactiveClients.ExecuteScalar();
                connection.Close();

                // Update statistics cards
                lblTotalClientsValue.Text = totalClients.ToString();
                lblNewClientsValue.Text = newClients.ToString();
                lblActiveClientsValue.Text = activeClients.ToString();
                lblInactiveClientsValue.Text = inactiveClients.ToString();

                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors du chargement des statistiques: " + ex.Message);
            }
        }

        public void RefreshData()
        {
            ChargerClients();
            LoadStatistics();
        }

        private void medicamentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Accueil f = new Accueil();
            this.Hide();
            f.Show();
        }

        private void gunaDataGridViewClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Optional: Handle cell click
        }
        private void ajouterClientToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AjouterClient ajouterClientForm = new AjouterClient();

            // Open as modal dialog → stops everything until the popup is closed
            var result = ajouterClientForm.ShowDialog();

            // If fournisseur successfully added → reload combo box
            if (result == DialogResult.OK)
            {
                this.RefreshData();
            }
        }

        private void modifierClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModifierClient modifierClientForm = new ModifierClient();
            modifierClientForm.Show();
        }

        private void medicamentsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Accueil accueilForm = new Accueil();
            accueilForm.Show();
        }

        private void commandesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccueilCommande f = new AccueilCommande();
            this.Hide();
            f.Show();
        }

        // Search functionality
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        // Apply search filter
        private void ApplyFilters()
        {
            if (dataTable == null) return;

            try
            {
                string filterExpression = "";

                // Search filter - search in name, phone, or email
                if (!string.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    string searchText = txtSearch.Text;
                    filterExpression = $"Nom LIKE '%{searchText}%' OR [Téléphone] LIKE '%{searchText}%' OR Email LIKE '%{searchText}%'";
                }

                // Apply filter
                DataView dv = dataTable.DefaultView;
                dv.RowFilter = filterExpression;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de l'application des filtres: " + ex.Message);
            }
        }

        // Refresh button
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // Reset filters
            txtSearch.Clear();

            // Reload data
            RefreshData();

            MessageBox.Show("Données actualisées!", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void archiverClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArchiverClient archiverClientForm = new ArchiverClient();
            archiverClientForm.ShowDialog();
            this.RefreshData();

        }
    }
}
