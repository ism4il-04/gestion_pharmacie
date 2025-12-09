using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace GestionPharmacie
{
    public partial class GenererFacture : Form
    {
        private int commandeId;
        private Facture facture;
        private DataTable orderDetails;
        private string clientName;
        private DateTime orderDate;
        private decimal orderTotal;

        public GenererFacture(int commandeId)
        {
            InitializeComponent();
            this.commandeId = commandeId;
            LoadOrderData();
            CheckExistingInvoice();
        }

        private void LoadOrderData()
        {
            try
            {
                SqlConnection connection = Connexion.connecter();

                // Get order information
                string sqlOrder = @"SELECT c.id, c.date_commande, c.total, cl.nom_complet, cl.telephone, cl.email
                                   FROM commande c
                                   LEFT JOIN client cl ON c.client_id = cl.id
                                   WHERE c.id = @CommandeId";

                SqlCommand cmdOrder = new SqlCommand(sqlOrder, connection);
                cmdOrder.Parameters.AddWithValue("@CommandeId", commandeId);

                connection.Open();
                using (SqlDataReader reader = cmdOrder.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        lblCommandeId.Text = $"Commande #{reader.GetInt32(0)}";
                        orderDate = reader.GetDateTime(1);
                        lblDateCommande.Text = orderDate.ToString("dd/MM/yyyy HH:mm");
                        orderTotal = reader.IsDBNull(2) ? 0 : reader.GetDecimal(2);
                        clientName = reader.IsDBNull(3) ? "Client anonyme" : reader.GetString(3);
                        lblClient.Text = clientName;
                        lblTelephone.Text = reader.IsDBNull(4) ? "N/A" : reader.GetString(4);
                        lblEmail.Text = reader.IsDBNull(5) ? "N/A" : reader.GetString(5);
                    }
                }
                connection.Close();

                // Get order details
                string sqlDetails = @"SELECT 
                                        m.nom AS 'Médicament',
                                        cd.quantite AS 'Quantité',
                                        cd.prix_unitaire AS 'Prix Unitaire',
                                        (cd.quantite * cd.prix_unitaire) AS 'Total'
                                      FROM commande_details cd
                                      INNER JOIN medicament m ON cd.medicament_id = m.id
                                      WHERE cd.commande_id = @CommandeId";

                SqlDataAdapter adapter = new SqlDataAdapter(sqlDetails, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@CommandeId", commandeId);
                orderDetails = new DataTable();
                adapter.Fill(orderDetails);

                dgvDetails.DataSource = orderDetails;

                // Format columns
                if (dgvDetails.Columns["Prix Unitaire"] != null)
                {
                    dgvDetails.Columns["Prix Unitaire"].DefaultCellStyle.Format = "N2";
                    dgvDetails.Columns["Prix Unitaire"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
                if (dgvDetails.Columns["Total"] != null)
                {
                    dgvDetails.Columns["Total"].DefaultCellStyle.Format = "N2";
                    dgvDetails.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }

                lblMontantTotal.Text = $"{orderTotal:N2} DH";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des données: " + ex.Message,
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CheckExistingInvoice()
        {
            facture = Facture.GetByCommandeId(commandeId);

            if (facture != null)
            {
                // Invoice exists, load it
                lblFactureId.Text = $"Facture #{facture.Id}";
                lblDateFacture.Text = facture.DateFacture.ToString("dd/MM/yyyy HH:mm");
                lblStatutPaiement.Text = "PAYÉ ✓";
                lblStatutPaiement.ForeColor = Color.FromArgb(16, 185, 129);
                btnGenerer.Text = "Facture Existante";
                btnGenerer.Enabled = false;
            }
            else
            {
                // New invoice
                lblFactureId.Text = "Nouvelle facture";
                lblDateFacture.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                lblStatutPaiement.Text = "À générer";
                lblStatutPaiement.ForeColor = Color.FromArgb(107, 114, 128);
                btnGenerer.Text = "Générer Facture";
                btnGenerer.Enabled = true;
            }
        }

        private void btnGenerer_Click(object sender, EventArgs e)
        {
            try
            {
                if (facture == null)
                {
                    // Create new invoice - always set as "payee"
                    facture = new Facture
                    {
                        CommandeId = commandeId,
                        DateFacture = DateTime.Now,
                        MontantTotal = orderTotal,
                        StatutPaiement = "payee" // Always set as paid (matches DB constraint)
                    };

                    int factureId = facture.Ajouter();

                    MessageBox.Show($"Facture #{factureId} créée avec succès!\nStatut: PAYÉ",
                        "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblFactureId.Text = $"Facture #{factureId}";
                    lblStatutPaiement.Text = "PAYÉ ✓";
                    lblStatutPaiement.ForeColor = Color.FromArgb(16, 185, 129);
                    btnGenerer.Text = "Facture Existante";
                    btnGenerer.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la création de la facture:\n{ex.Message}", 
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExporterPDF_Click(object sender, EventArgs e)
        {
            if (facture == null || facture.Id == 0)
            {
                MessageBox.Show("Veuillez d'abord générer la facture avant de l'exporter.",
                    "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                PrintDocument printDoc = new PrintDocument();
                printDoc.PrintPage += new PrintPageEventHandler(PrintInvoice);

                PrintDialog printDialog = new PrintDialog();
                printDialog.Document = printDoc;

                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDoc.Print();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'export: " + ex.Message,
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PrintInvoice(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font titleFont = new Font("Arial", 20, FontStyle.Bold);
            Font headerFont = new Font("Arial", 12, FontStyle.Bold);
            Font normalFont = new Font("Arial", 10);
            Font smallFont = new Font("Arial", 9);

            int yPos = 50;
            int leftMargin = 50;

            // Title
            g.DrawString("FACTURE", titleFont, Brushes.Black, leftMargin, yPos);
            yPos += 40;

            // Invoice info
            g.DrawString($"Facture N°: {facture.Id}", headerFont, Brushes.Black, leftMargin, yPos);
            g.DrawString($"Date: {facture.DateFacture:dd/MM/yyyy}", normalFont, Brushes.Black, 400, yPos);
            yPos += 30;

            // Client info
            g.DrawString("CLIENT:", headerFont, Brushes.Black, leftMargin, yPos);
            yPos += 25;
            g.DrawString(clientName, normalFont, Brushes.Black, leftMargin, yPos);
            yPos += 20;
            g.DrawString($"Tél: {lblTelephone.Text}", normalFont, Brushes.Black, leftMargin, yPos);
            yPos += 20;
            g.DrawString($"Email: {lblEmail.Text}", normalFont, Brushes.Black, leftMargin, yPos);
            yPos += 40;

            // Order details
            g.DrawString("DÉTAILS DE LA COMMANDE:", headerFont, Brushes.Black, leftMargin, yPos);
            yPos += 30;

            // Table header
            g.DrawString("Médicament", headerFont, Brushes.Black, leftMargin, yPos);
            g.DrawString("Qté", headerFont, Brushes.Black, 350, yPos);
            g.DrawString("Prix Unit.", headerFont, Brushes.Black, 420, yPos);
            g.DrawString("Total", headerFont, Brushes.Black, 520, yPos);
            yPos += 25;

            // Draw line
            g.DrawLine(Pens.Black, leftMargin, yPos, 600, yPos);
            yPos += 10;

            // Items
            foreach (DataRow row in orderDetails.Rows)
            {
                g.DrawString(row["Médicament"].ToString(), normalFont, Brushes.Black, leftMargin, yPos);
                g.DrawString(row["Quantité"].ToString(), normalFont, Brushes.Black, 350, yPos);
                g.DrawString($"{Convert.ToDecimal(row["Prix Unitaire"]):N2} DH", normalFont, Brushes.Black, 420, yPos);
                g.DrawString($"{Convert.ToDecimal(row["Total"]):N2} DH", normalFont, Brushes.Black, 520, yPos);
                yPos += 20;
            }

            yPos += 10;
            g.DrawLine(Pens.Black, leftMargin, yPos, 600, yPos);
            yPos += 20;

            // Total
            g.DrawString("TOTAL:", headerFont, Brushes.Black, 420, yPos);
            g.DrawString($"{orderTotal:N2} DH", headerFont, Brushes.Black, 520, yPos);
            yPos += 40;

            // Payment status - always PAYÉ
            g.DrawString("Statut: PAYÉ", headerFont, Brushes.Green, leftMargin, yPos);

            yPos += 60;

            // Footer
            g.DrawString("Merci pour votre confiance!", smallFont, Brushes.Gray, leftMargin, yPos);
        }

        private void btnImprimer_Click(object sender, EventArgs e)
        {
            if (facture == null || facture.Id == 0)
            {
                MessageBox.Show("Veuillez d'abord générer la facture avant de l'imprimer.",
                    "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                PrintDocument printDoc = new PrintDocument();
                printDoc.PrintPage += new PrintPageEventHandler(PrintInvoice);

                PrintPreviewDialog previewDialog = new PrintPreviewDialog();
                previewDialog.Document = printDoc;
                previewDialog.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'impression: " + ex.Message,
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
