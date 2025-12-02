namespace GestionPharmacie
{
    partial class GenererFacture
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();

            this.panelHeader = new Panel();
            this.lblTitle = new Label();
            this.lblFactureId = new Label();
            this.lblDateFacture = new Label();

            this.groupBoxCommande = new GroupBox();
            this.lblCommandeId = new Label();
            this.lblDateCommande = new Label();
            this.label1 = new Label();
            this.label2 = new Label();

            this.groupBoxClient = new GroupBox();
            this.lblClient = new Label();
            this.lblTelephone = new Label();
            this.lblEmail = new Label();
            this.label3 = new Label();
            this.label4 = new Label();
            this.label5 = new Label();

            this.groupBoxDetails = new GroupBox();
            this.dgvDetails = new Guna.UI2.WinForms.Guna2DataGridView();

            this.groupBoxFacture = new GroupBox();
            this.label6 = new Label();
            this.lblStatutPaiement = new Label();
            this.label7 = new Label();
            this.lblMontantTotal = new Label();

            this.btnGenerer = new Button();
            this.btnExporterPDF = new Button();
            this.btnImprimer = new Button();
            this.btnFermer = new Button();

            this.groupBoxCommande.SuspendLayout();
            this.groupBoxClient.SuspendLayout();
            this.groupBoxDetails.SuspendLayout();
            this.groupBoxFacture.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            this.SuspendLayout();

            // panelHeader
            this.panelHeader.BackColor = Color.FromArgb(0, 122, 204);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.lblFactureId);
            this.panelHeader.Controls.Add(this.lblDateFacture);
            this.panelHeader.Dock = DockStyle.Top;
            this.panelHeader.Location = new Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new Size(1000, 80);
            this.panelHeader.TabIndex = 0;

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.White;
            this.lblTitle.Location = new Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new Size(250, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "📄 Génération de Facture";

            // lblFactureId
            this.lblFactureId.AutoSize = true;
            this.lblFactureId.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.lblFactureId.ForeColor = Color.White;
            this.lblFactureId.Location = new Point(650, 20);
            this.lblFactureId.Name = "lblFactureId";
            this.lblFactureId.Size = new Size(150, 28);
            this.lblFactureId.TabIndex = 1;
            this.lblFactureId.Text = "Nouvelle facture";

            // lblDateFacture
            this.lblDateFacture.AutoSize = true;
            this.lblDateFacture.Font = new Font("Segoe UI", 10F);
            this.lblDateFacture.ForeColor = Color.White;
            this.lblDateFacture.Location = new Point(650, 50);
            this.lblDateFacture.Name = "lblDateFacture";
            this.lblDateFacture.Size = new Size(100, 23);
            this.lblDateFacture.TabIndex = 2;
            this.lblDateFacture.Text = "01/01/2025";

            // groupBoxCommande
            this.groupBoxCommande.Controls.Add(this.label1);
            this.groupBoxCommande.Controls.Add(this.lblCommandeId);
            this.groupBoxCommande.Controls.Add(this.label2);
            this.groupBoxCommande.Controls.Add(this.lblDateCommande);
            this.groupBoxCommande.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.groupBoxCommande.Location = new Point(30, 100);
            this.groupBoxCommande.Name = "groupBoxCommande";
            this.groupBoxCommande.Size = new Size(460, 100);
            this.groupBoxCommande.TabIndex = 1;
            this.groupBoxCommande.TabStop = false;
            this.groupBoxCommande.Text = "Informations Commande";

            // label1
            this.label1.AutoSize = true;
            this.label1.Font = new Font("Segoe UI", 10F);
            this.label1.Location = new Point(20, 35);
            this.label1.Name = "label1";
            this.label1.Size = new Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Commande:";

            // lblCommandeId
            this.lblCommandeId.AutoSize = true;
            this.lblCommandeId.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblCommandeId.Location = new Point(150, 35);
            this.lblCommandeId.Name = "lblCommandeId";
            this.lblCommandeId.Size = new Size(100, 23);
            this.lblCommandeId.TabIndex = 1;
            this.lblCommandeId.Text = "#0";

            // label2
            this.label2.AutoSize = true;
            this.label2.Font = new Font("Segoe UI", 10F);
            this.label2.Location = new Point(20, 65);
            this.label2.Name = "label2";
            this.label2.Size = new Size(50, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date:";

            // lblDateCommande
            this.lblDateCommande.AutoSize = true;
            this.lblDateCommande.Font = new Font("Segoe UI", 10F);
            this.lblDateCommande.Location = new Point(150, 65);
            this.lblDateCommande.Name = "lblDateCommande";
            this.lblDateCommande.Size = new Size(100, 23);
            this.lblDateCommande.TabIndex = 3;
            this.lblDateCommande.Text = "01/01/2025";

            // groupBoxClient
            this.groupBoxClient.Controls.Add(this.label3);
            this.groupBoxClient.Controls.Add(this.lblClient);
            this.groupBoxClient.Controls.Add(this.label4);
            this.groupBoxClient.Controls.Add(this.lblTelephone);
            this.groupBoxClient.Controls.Add(this.label5);
            this.groupBoxClient.Controls.Add(this.lblEmail);
            this.groupBoxClient.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.groupBoxClient.Location = new Point(510, 100);
            this.groupBoxClient.Name = "groupBoxClient";
            this.groupBoxClient.Size = new Size(460, 100);
            this.groupBoxClient.TabIndex = 2;
            this.groupBoxClient.TabStop = false;
            this.groupBoxClient.Text = "Informations Client";

            // label3
            this.label3.AutoSize = true;
            this.label3.Font = new Font("Segoe UI", 10F);
            this.label3.Location = new Point(20, 35);
            this.label3.Name = "label3";
            this.label3.Size = new Size(50, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nom:";

            // lblClient
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblClient.Location = new Point(120, 35);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new Size(100, 23);
            this.lblClient.TabIndex = 1;
            this.lblClient.Text = "Client";

            // label4
            this.label4.AutoSize = true;
            this.label4.Font = new Font("Segoe UI", 10F);
            this.label4.Location = new Point(20, 60);
            this.label4.Name = "label4";
            this.label4.Size = new Size(40, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tél:";

            // lblTelephone
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Font = new Font("Segoe UI", 10F);
            this.lblTelephone.Location = new Point(120, 60);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new Size(100, 23);
            this.lblTelephone.TabIndex = 3;
            this.lblTelephone.Text = "N/A";

            // label5
            this.label5.AutoSize = true;
            this.label5.Font = new Font("Segoe UI", 10F);
            this.label5.Location = new Point(250, 60);
            this.label5.Name = "label5";
            this.label5.Size = new Size(55, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email:";

            // lblEmail
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new Font("Segoe UI", 10F);
            this.lblEmail.Location = new Point(310, 60);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new Size(100, 23);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "N/A";

            // groupBoxDetails
            this.groupBoxDetails.Controls.Add(this.dgvDetails);
            this.groupBoxDetails.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.groupBoxDetails.Location = new Point(30, 220);
            this.groupBoxDetails.Name = "groupBoxDetails";
            this.groupBoxDetails.Size = new Size(940, 300);
            this.groupBoxDetails.TabIndex = 3;
            this.groupBoxDetails.TabStop = false;
            this.groupBoxDetails.Text = "Détails de la Commande";

            // dgvDetails
            this.dgvDetails.AllowUserToAddRows = false;
            this.dgvDetails.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            this.dgvDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 122, 204);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            this.dgvDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDetails.ColumnHeadersHeight = 35;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(200, 230, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            this.dgvDetails.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDetails.GridColor = Color.LightGray;
            this.dgvDetails.Location = new Point(20, 35);
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.ReadOnly = true;
            this.dgvDetails.RowHeadersVisible = false;
            this.dgvDetails.RowTemplate.Height = 30;
            this.dgvDetails.Size = new Size(900, 250);
            this.dgvDetails.TabIndex = 0;

            // groupBoxFacture
            this.groupBoxFacture.Controls.Add(this.label6);
            this.groupBoxFacture.Controls.Add(this.lblStatutPaiement);
            this.groupBoxFacture.Controls.Add(this.label7);
            this.groupBoxFacture.Controls.Add(this.lblMontantTotal);
            this.groupBoxFacture.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.groupBoxFacture.Location = new Point(30, 540);
            this.groupBoxFacture.Name = "groupBoxFacture";
            this.groupBoxFacture.Size = new Size(940, 80);
            this.groupBoxFacture.TabIndex = 4;
            this.groupBoxFacture.TabStop = false;
            this.groupBoxFacture.Text = "Facture";

            // label6
            this.label6.AutoSize = true;
            this.label6.Font = new Font("Segoe UI", 10F);
            this.label6.Location = new Point(20, 40);
            this.label6.Name = "label6";
            this.label6.Size = new Size(150, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Statut de paiement:";

            // lblStatutPaiement
            this.lblStatutPaiement.AutoSize = true;
            this.lblStatutPaiement.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblStatutPaiement.ForeColor = Color.FromArgb(16, 185, 129);
            this.lblStatutPaiement.Location = new Point(180, 40);
            this.lblStatutPaiement.Name = "lblStatutPaiement";
            this.lblStatutPaiement.Size = new Size(100, 25);
            this.lblStatutPaiement.TabIndex = 1;
            this.lblStatutPaiement.Text = "PAYÉ ✓";

            // label7
            this.label7.AutoSize = true;
            this.label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.label7.Location = new Point(600, 40);
            this.label7.Name = "label7";
            this.label7.Size = new Size(150, 28);
            this.label7.TabIndex = 2;
            this.label7.Text = "Montant Total:";

            // lblMontantTotal
            this.lblMontantTotal.AutoSize = true;
            this.lblMontantTotal.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.lblMontantTotal.ForeColor = Color.FromArgb(0, 122, 204);
            this.lblMontantTotal.Location = new Point(760, 37);
            this.lblMontantTotal.Name = "lblMontantTotal";
            this.lblMontantTotal.Size = new Size(100, 32);
            this.lblMontantTotal.TabIndex = 3;
            this.lblMontantTotal.Text = "0.00 DH";

            // btnGenerer
            this.btnGenerer.BackColor = Color.FromArgb(16, 185, 129);
            this.btnGenerer.FlatStyle = FlatStyle.Flat;
            this.btnGenerer.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.btnGenerer.ForeColor = Color.White;
            this.btnGenerer.Location = new Point(30, 640);
            this.btnGenerer.Name = "btnGenerer";
            this.btnGenerer.Size = new Size(200, 45);
            this.btnGenerer.TabIndex = 5;
            this.btnGenerer.Text = "✅ Générer Facture";
            this.btnGenerer.UseVisualStyleBackColor = false;
            this.btnGenerer.Click += new EventHandler(this.btnGenerer_Click);

            // btnExporterPDF
            this.btnExporterPDF.BackColor = Color.FromArgb(239, 68, 68);
            this.btnExporterPDF.FlatStyle = FlatStyle.Flat;
            this.btnExporterPDF.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.btnExporterPDF.ForeColor = Color.White;
            this.btnExporterPDF.Location = new Point(250, 640);
            this.btnExporterPDF.Name = "btnExporterPDF";
            this.btnExporterPDF.Size = new Size(200, 45);
            this.btnExporterPDF.TabIndex = 6;
            this.btnExporterPDF.Text = "📄 Exporter PDF";
            this.btnExporterPDF.UseVisualStyleBackColor = false;
            this.btnExporterPDF.Click += new EventHandler(this.btnExporterPDF_Click);

            // btnImprimer
            this.btnImprimer.BackColor = Color.FromArgb(251, 146, 60);
            this.btnImprimer.FlatStyle = FlatStyle.Flat;
            this.btnImprimer.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.btnImprimer.ForeColor = Color.White;
            this.btnImprimer.Location = new Point(470, 640);
            this.btnImprimer.Name = "btnImprimer";
            this.btnImprimer.Size = new Size(200, 45);
            this.btnImprimer.TabIndex = 7;
            this.btnImprimer.Text = "🖨️ Imprimer";
            this.btnImprimer.UseVisualStyleBackColor = false;
            this.btnImprimer.Click += new EventHandler(this.btnImprimer_Click);

            // btnFermer
            this.btnFermer.BackColor = Color.FromArgb(107, 114, 128);
            this.btnFermer.FlatStyle = FlatStyle.Flat;
            this.btnFermer.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.btnFermer.ForeColor = Color.White;
            this.btnFermer.Location = new Point(690, 640);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new Size(200, 45);
            this.btnFermer.TabIndex = 8;
            this.btnFermer.Text = "❌ Fermer";
            this.btnFermer.UseVisualStyleBackColor = false;
            this.btnFermer.Click += new EventHandler(this.btnFermer_Click);

            // GenererFacture
            this.AutoScaleDimensions = new SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(240, 244, 248);
            this.ClientSize = new Size(1000, 710);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnImprimer);
            this.Controls.Add(this.btnExporterPDF);
            this.Controls.Add(this.btnGenerer);
            this.Controls.Add(this.groupBoxFacture);
            this.Controls.Add(this.groupBoxDetails);
            this.Controls.Add(this.groupBoxClient);
            this.Controls.Add(this.groupBoxCommande);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "GenererFacture";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Génération de Facture";
            this.groupBoxCommande.ResumeLayout(false);
            this.groupBoxCommande.PerformLayout();
            this.groupBoxClient.ResumeLayout(false);
            this.groupBoxClient.PerformLayout();
            this.groupBoxDetails.ResumeLayout(false);
            this.groupBoxFacture.ResumeLayout(false);
            this.groupBoxFacture.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblTitle;
        private Label lblFactureId;
        private Label lblDateFacture;
        private GroupBox groupBoxCommande;
        private Label label1;
        private Label lblCommandeId;
        private Label label2;
        private Label lblDateCommande;
        private GroupBox groupBoxClient;
        private Label label3;
        private Label lblClient;
        private Label label4;
        private Label lblTelephone;
        private Label label5;
        private Label lblEmail;
        private GroupBox groupBoxDetails;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDetails;
        private GroupBox groupBoxFacture;
        private Label label6;
        private Label lblStatutPaiement;
        private Label label7;
        private Label lblMontantTotal;
        private Button btnGenerer;
        private Button btnExporterPDF;
        private Button btnImprimer;
        private Button btnFermer;
    }
}
