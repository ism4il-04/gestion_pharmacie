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
    public partial class AccueilCommande : Form
    {
        private DataTable commandesTable;

        public AccueilCommande()
        {
            InitializeComponent();
            StyleForm();
            LoadCommandes();
            LoadStatistics();
            InitializeContextMenu();
            
            this.Load += AccueilCommande_Load;
        }

        private void AccueilCommande_Load(object sender, EventArgs e)
        {
            // Additional initialization if needed
        }

        private void StyleForm()
        {
            // Set form properties
            this.BackColor = Color.FromArgb(240, 244, 248);
            
            // Style the DataGridView
            guna2DataGridView1.BorderStyle = BorderStyle.None;
            guna2DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
            guna2DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            guna2DataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 122, 204);
            guna2DataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
            guna2DataGridView1.BackgroundColor = Color.White;
            guna2DataGridView1.EnableHeadersVisualStyles = false;
            guna2DataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            guna2DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 122, 204);
            guna2DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            guna2DataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            guna2DataGridView1.ColumnHeadersHeight = 40;
            guna2DataGridView1.RowTemplate.Height = 35;
            guna2DataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            guna2DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            guna2DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            guna2DataGridView1.MultiSelect = false;
            guna2DataGridView1.ReadOnly = true;
            guna2DataGridView1.AllowUserToAddRows = false;
            guna2DataGridView1.AllowUserToDeleteRows = false;
        }

        private void LoadCommandes()
        {
            try
            {
                SqlConnection connection = Connexion.connecter();
                string sql = @"
                    SELECT 
                        c.id AS 'ID',
                        cl.nom_complet AS 'Client',
                        u.nom + ' ' + u.prenom AS 'Utilisateur',
                        c.date_commande AS 'Date',
                        c.statut AS 'Statut',
                        c.total AS 'Total (DH)',
                        COUNT(cd.id) AS 'Nb Articles'
                    FROM commande c
                    INNER JOIN client cl ON c.client_id = cl.id
                    INNER JOIN utilisateur u ON c.utilisateur_id = u.id
                    LEFT JOIN commande_details cd ON c.id = cd.commande_id
                    GROUP BY c.id, cl.nom_complet, u.nom, u.prenom, c.date_commande, c.statut, c.total
                    ORDER BY c.date_commande DESC";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                commandesTable = new DataTable();
                adapter.Fill(commandesTable);

                guna2DataGridView1.DataSource = commandesTable;

                // Hide ID column
                if (guna2DataGridView1.Columns["ID"] != null)
                {
                    guna2DataGridView1.Columns["ID"].Visible = false;
                }

                // Format date column
                if (guna2DataGridView1.Columns["Date"] != null)
                {
                    guna2DataGridView1.Columns["Date"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                }

                // Format total column
                if (guna2DataGridView1.Columns["Total (DH)"] != null)
                {
                    guna2DataGridView1.Columns["Total (DH)"].DefaultCellStyle.Format = "N2";
                    guna2DataGridView1.Columns["Total (DH)"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }

                // Style status column with colors
                StyleStatusColumn();

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des commandes: " + ex.Message,
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StyleStatusColumn()
        {
            // Add color coding for status
            foreach (DataGridViewRow row in guna2DataGridView1.Rows)
            {
                if (row.Cells["Statut"].Value != null)
                {
                    string statut = row.Cells["Statut"].Value.ToString();
                    switch (statut.ToLower())
                    {
                        case "en_cours":
                            row.Cells["Statut"].Style.BackColor = Color.FromArgb(255, 243, 205);
                            row.Cells["Statut"].Style.ForeColor = Color.FromArgb(180, 83, 9);
                            break;
                        case "livree":
                            row.Cells["Statut"].Style.BackColor = Color.FromArgb(209, 250, 229);
                            row.Cells["Statut"].Style.ForeColor = Color.FromArgb(6, 95, 70);
                            break;
                        case "annulee":
                            row.Cells["Statut"].Style.BackColor = Color.FromArgb(254, 226, 226);
                            row.Cells["Statut"].Style.ForeColor = Color.FromArgb(153, 27, 27);
                            break;
                    }
                }
            }
        }

        private void LoadStatistics()
        {
            try
            {
                SqlConnection connection = Connexion.connecter();
                
                // Get total orders count
                string sqlCount = "SELECT COUNT(*) FROM commande";
                SqlCommand cmdCount = new SqlCommand(sqlCount, connection);
                connection.Open();
                int totalOrders = (int)cmdCount.ExecuteScalar();
                connection.Close();

                // Get total revenue
                string sqlRevenue = "SELECT ISNULL(SUM(total), 0) FROM commande WHERE statut != 'annulee'";
                SqlCommand cmdRevenue = new SqlCommand(sqlRevenue, connection);
                connection.Open();
                decimal totalRevenue = (decimal)cmdRevenue.ExecuteScalar();
                connection.Close();

                // Get today's orders
                string sqlToday = "SELECT COUNT(*) FROM commande WHERE CAST(date_commande AS DATE) = CAST(GETDATE() AS DATE)";
                SqlCommand cmdToday = new SqlCommand(sqlToday, connection);
                connection.Open();
                int todayOrders = (int)cmdToday.ExecuteScalar();
                connection.Close();

                // Get pending orders
                string sqlPending = "SELECT COUNT(*) FROM commande WHERE statut = 'en_cours'";
                SqlCommand cmdPending = new SqlCommand(sqlPending, connection);
                connection.Open();
                int pendingOrders = (int)cmdPending.ExecuteScalar();
                connection.Close();

                // Update statistics cards
                lblTotalOrdersValue.Text = totalOrders.ToString();
                lblRevenueValue.Text = $"{totalRevenue:N2} DH";
                lblTodayOrdersValue.Text = todayOrders.ToString();
                lblPendingOrdersValue.Text = pendingOrders.ToString();

                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors du chargement des statistiques: " + ex.Message);
            }
        }

        public void RefreshData()
        {
            LoadCommandes();
            LoadStatistics();
        }

        private void ajouterUneCommandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjouterCommande f = new AjouterCommande();
            f.Show();
            this.Hide();
        }

        private void medicamentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Accueil f = new Accueil();
            f.Show();
            this.Hide();
        }

        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccueilClient f = new AccueilClient();
            f.Show();
            this.Hide();
        }

        private void guna2DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int commandeId = Convert.ToInt32(guna2DataGridView1.Rows[e.RowIndex].Cells["ID"].Value);
                GenererFacture factureForm = new GenererFacture(commandeId);
                factureForm.ShowDialog();
                RefreshData(); // Refresh to show updated invoice status
            }
        }
        
        // Initialize context menu for invoice generation
        private void InitializeContextMenu()
        {
            ContextMenuStrip contextMenu = new ContextMenuStrip();
            
            ToolStripMenuItem genererFacture = new ToolStripMenuItem("📄 Générer Facture");
            genererFacture.Click += (s, e) => {
                if (guna2DataGridView1.SelectedRows.Count > 0)
                {
                    int commandeId = Convert.ToInt32(guna2DataGridView1.SelectedRows[0].Cells["ID"].Value);
                    GenererFacture factureForm = new GenererFacture(commandeId);
                    factureForm.ShowDialog();
                    RefreshData();
                }
            };

            ToolStripMenuItem viewDetails = new ToolStripMenuItem("👁️ Voir les détails");
            viewDetails.Click += (s, e) => {
                if (guna2DataGridView1.SelectedRows.Count > 0)
                {
                    int commandeId = Convert.ToInt32(guna2DataGridView1.SelectedRows[0].Cells["ID"].Value);
                    MessageBox.Show($"Détails de la commande #{commandeId}\n(Fonctionnalité à implémenter)");
                }
            };

            contextMenu.Items.Add(genererFacture);
            contextMenu.Items.Add(viewDetails);
            
            guna2DataGridView1.ContextMenuStrip = contextMenu;
        }
        
        // Search functionality
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }
        
        // Status filter
        private void comboStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }
        
        // Apply all filters
        private void ApplyFilters()
        {
            if (commandesTable == null) return;
            
            try
            {
                string filterExpression = "";
                List<string> filters = new List<string>();
                
                // Search filter
                if (!string.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    filters.Add($"Client LIKE '%{txtSearch.Text}%'");
                }
                
                // Status filter
                if (comboStatusFilter.SelectedIndex > 0) // 0 is "Tous les statuts"
                {
                    string selectedStatus = comboStatusFilter.SelectedItem.ToString();
                    filters.Add($"Statut = '{selectedStatus}'");
                }
                
                // Combine filters
                if (filters.Count > 0)
                {
                    filterExpression = string.Join(" AND ", filters);
                }
                
                // Apply filter
                DataView dv = commandesTable.DefaultView;
                dv.RowFilter = filterExpression;
                
                // Update status column styling after filter
                StyleStatusColumn();
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
            comboStatusFilter.SelectedIndex = 0;
            
            // Reload data
            RefreshData();
            
            MessageBox.Show("Données actualisées!", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
