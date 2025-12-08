namespace GestionPharmacie
{
    partial class AccueilClient
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            menuStrip1 = new MenuStrip();
            medicamentsToolStripMenuItem = new ToolStripMenuItem();
            clientsToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripMenuItem();
            commandesToolStripMenuItem = new ToolStripMenuItem();
            panelTotalClients = new Guna.UI2.WinForms.Guna2Panel();
            lblTotalClientsValue = new Label();
            lblTotalClientsTitle = new Label();
            panelNewClients = new Guna.UI2.WinForms.Guna2Panel();
            lblNewClientsValue = new Label();
            lblNewClientsTitle = new Label();
            panelActiveClients = new Guna.UI2.WinForms.Guna2Panel();
            lblActiveClientsValue = new Label();
            lblActiveClientsTitle = new Label();
            panelInactiveClients = new Guna.UI2.WinForms.Guna2Panel();
            lblInactiveClientsValue = new Label();
            lblInactiveClientsTitle = new Label();
            txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            gunaDataGridViewClients = new Guna.UI2.WinForms.Guna2DataGridView();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            panelTotalClients.SuspendLayout();
            panelNewClients.SuspendLayout();
            panelActiveClients.SuspendLayout();
            panelInactiveClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gunaDataGridViewClients).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(30, 39, 73);
            menuStrip1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            menuStrip1.ForeColor = Color.White;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { medicamentsToolStripMenuItem, clientsToolStripMenuItem, commandesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(12, 8, 0, 8);
            menuStrip1.Size = new Size(1600, 50);
            menuStrip1.TabIndex = 3;
            // 
            // medicamentsToolStripMenuItem
            // 
            medicamentsToolStripMenuItem.ForeColor = Color.White;
            medicamentsToolStripMenuItem.Name = "medicamentsToolStripMenuItem";
            medicamentsToolStripMenuItem.Padding = new Padding(12, 0, 12, 0);
            medicamentsToolStripMenuItem.Size = new Size(218, 34);
            medicamentsToolStripMenuItem.Text = "💊 Médicaments";
            medicamentsToolStripMenuItem.Click += medicamentsToolStripMenuItem_Click_1;
            // 
            // clientsToolStripMenuItem
            // 
            clientsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem4, toolStripMenuItem5 });
            clientsToolStripMenuItem.ForeColor = Color.White;
            clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            clientsToolStripMenuItem.Padding = new Padding(12, 0, 12, 0);
            clientsToolStripMenuItem.Size = new Size(148, 34);
            clientsToolStripMenuItem.Text = "👥 Clients";
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.BackColor = Color.White;
            toolStripMenuItem4.ForeColor = Color.FromArgb(30, 39, 73);
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(271, 38);
            toolStripMenuItem4.Text = "Ajouter Client";
            toolStripMenuItem4.Click += ajouterClientToolStripMenuItem_Click;
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.BackColor = Color.White;
            toolStripMenuItem5.ForeColor = Color.FromArgb(30, 39, 73);
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(271, 38);
            toolStripMenuItem5.Text = "Modifier Client";
            toolStripMenuItem5.Click += modifierClientToolStripMenuItem_Click;
            // 
            // commandesToolStripMenuItem
            // 
            commandesToolStripMenuItem.ForeColor = Color.White;
            commandesToolStripMenuItem.Name = "commandesToolStripMenuItem";
            commandesToolStripMenuItem.Padding = new Padding(12, 0, 12, 0);
            commandesToolStripMenuItem.Size = new Size(206, 34);
            commandesToolStripMenuItem.Text = "📦 Commandes";
            commandesToolStripMenuItem.Click += commandesToolStripMenuItem_Click;
            // 
            // panelTotalClients
            // 
            panelTotalClients.BackColor = Color.Transparent;
            panelTotalClients.BorderRadius = 15;
            panelTotalClients.Controls.Add(lblTotalClientsValue);
            panelTotalClients.Controls.Add(lblTotalClientsTitle);
            panelTotalClients.CustomizableEdges = customizableEdges1;
            panelTotalClients.FillColor = Color.FromArgb(99, 102, 241);
            panelTotalClients.Location = new Point(50, 75);
            panelTotalClients.Name = "panelTotalClients";
            panelTotalClients.ShadowDecoration.BorderRadius = 15;
            panelTotalClients.ShadowDecoration.Color = Color.FromArgb(99, 102, 241);
            panelTotalClients.ShadowDecoration.CustomizableEdges = customizableEdges2;
            panelTotalClients.ShadowDecoration.Depth = 20;
            panelTotalClients.ShadowDecoration.Enabled = true;
            panelTotalClients.ShadowDecoration.Shadow = new Padding(0, 0, 8, 8);
            panelTotalClients.Size = new Size(350, 140);
            panelTotalClients.TabIndex = 4;
            // 
            // lblTotalClientsValue
            // 
            lblTotalClientsValue.BackColor = Color.Transparent;
            lblTotalClientsValue.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            lblTotalClientsValue.ForeColor = Color.White;
            lblTotalClientsValue.Location = new Point(20, 55);
            lblTotalClientsValue.Name = "lblTotalClientsValue";
            lblTotalClientsValue.Size = new Size(310, 85);
            lblTotalClientsValue.TabIndex = 1;
            lblTotalClientsValue.Text = "0";
            lblTotalClientsValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTotalClientsTitle
            // 
            lblTotalClientsTitle.BackColor = Color.Transparent;
            lblTotalClientsTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotalClientsTitle.ForeColor = Color.White;
            lblTotalClientsTitle.Location = new Point(20, 20);
            lblTotalClientsTitle.Name = "lblTotalClientsTitle";
            lblTotalClientsTitle.Size = new Size(310, 35);
            lblTotalClientsTitle.TabIndex = 0;
            lblTotalClientsTitle.Text = "👥 Total Clients";
            lblTotalClientsTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelNewClients
            // 
            panelNewClients.BackColor = Color.Transparent;
            panelNewClients.BorderRadius = 15;
            panelNewClients.Controls.Add(lblNewClientsValue);
            panelNewClients.Controls.Add(lblNewClientsTitle);
            panelNewClients.CustomizableEdges = customizableEdges3;
            panelNewClients.FillColor = Color.FromArgb(16, 185, 129);
            panelNewClients.Location = new Point(425, 75);
            panelNewClients.Name = "panelNewClients";
            panelNewClients.ShadowDecoration.BorderRadius = 15;
            panelNewClients.ShadowDecoration.Color = Color.FromArgb(16, 185, 129);
            panelNewClients.ShadowDecoration.CustomizableEdges = customizableEdges4;
            panelNewClients.ShadowDecoration.Depth = 20;
            panelNewClients.ShadowDecoration.Enabled = true;
            panelNewClients.ShadowDecoration.Shadow = new Padding(0, 0, 8, 8);
            panelNewClients.Size = new Size(350, 140);
            panelNewClients.TabIndex = 5;
            // 
            // lblNewClientsValue
            // 
            lblNewClientsValue.BackColor = Color.Transparent;
            lblNewClientsValue.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            lblNewClientsValue.ForeColor = Color.White;
            lblNewClientsValue.Location = new Point(20, 55);
            lblNewClientsValue.Name = "lblNewClientsValue";
            lblNewClientsValue.Size = new Size(310, 85);
            lblNewClientsValue.TabIndex = 1;
            lblNewClientsValue.Text = "0";
            lblNewClientsValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblNewClientsTitle
            // 
            lblNewClientsTitle.BackColor = Color.Transparent;
            lblNewClientsTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblNewClientsTitle.ForeColor = Color.White;
            lblNewClientsTitle.Location = new Point(20, 20);
            lblNewClientsTitle.Name = "lblNewClientsTitle";
            lblNewClientsTitle.Size = new Size(310, 35);
            lblNewClientsTitle.TabIndex = 0;
            lblNewClientsTitle.Text = "✨ Nouveaux (Mois)";
            lblNewClientsTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelActiveClients
            // 
            panelActiveClients.BackColor = Color.Transparent;
            panelActiveClients.BorderRadius = 15;
            panelActiveClients.Controls.Add(lblActiveClientsValue);
            panelActiveClients.Controls.Add(lblActiveClientsTitle);
            panelActiveClients.CustomizableEdges = customizableEdges5;
            panelActiveClients.FillColor = Color.FromArgb(251, 146, 60);
            panelActiveClients.Location = new Point(800, 75);
            panelActiveClients.Name = "panelActiveClients";
            panelActiveClients.ShadowDecoration.BorderRadius = 15;
            panelActiveClients.ShadowDecoration.Color = Color.FromArgb(251, 146, 60);
            panelActiveClients.ShadowDecoration.CustomizableEdges = customizableEdges6;
            panelActiveClients.ShadowDecoration.Depth = 20;
            panelActiveClients.ShadowDecoration.Enabled = true;
            panelActiveClients.ShadowDecoration.Shadow = new Padding(0, 0, 8, 8);
            panelActiveClients.Size = new Size(350, 140);
            panelActiveClients.TabIndex = 6;
            // 
            // lblActiveClientsValue
            // 
            lblActiveClientsValue.BackColor = Color.Transparent;
            lblActiveClientsValue.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            lblActiveClientsValue.ForeColor = Color.White;
            lblActiveClientsValue.Location = new Point(20, 55);
            lblActiveClientsValue.Name = "lblActiveClientsValue";
            lblActiveClientsValue.Size = new Size(310, 85);
            lblActiveClientsValue.TabIndex = 1;
            lblActiveClientsValue.Text = "0";
            lblActiveClientsValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblActiveClientsTitle
            // 
            lblActiveClientsTitle.BackColor = Color.Transparent;
            lblActiveClientsTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblActiveClientsTitle.ForeColor = Color.White;
            lblActiveClientsTitle.Location = new Point(20, 20);
            lblActiveClientsTitle.Name = "lblActiveClientsTitle";
            lblActiveClientsTitle.Size = new Size(310, 35);
            lblActiveClientsTitle.TabIndex = 0;
            lblActiveClientsTitle.Text = "✅ Clients Actifs";
            lblActiveClientsTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelInactiveClients
            // 
            panelInactiveClients.BackColor = Color.Transparent;
            panelInactiveClients.BorderRadius = 15;
            panelInactiveClients.Controls.Add(lblInactiveClientsValue);
            panelInactiveClients.Controls.Add(lblInactiveClientsTitle);
            panelInactiveClients.CustomizableEdges = customizableEdges7;
            panelInactiveClients.FillColor = Color.FromArgb(239, 68, 68);
            panelInactiveClients.Location = new Point(1175, 75);
            panelInactiveClients.Name = "panelInactiveClients";
            panelInactiveClients.ShadowDecoration.BorderRadius = 15;
            panelInactiveClients.ShadowDecoration.Color = Color.FromArgb(239, 68, 68);
            panelInactiveClients.ShadowDecoration.CustomizableEdges = customizableEdges8;
            panelInactiveClients.ShadowDecoration.Depth = 20;
            panelInactiveClients.ShadowDecoration.Enabled = true;
            panelInactiveClients.ShadowDecoration.Shadow = new Padding(0, 0, 8, 8);
            panelInactiveClients.Size = new Size(350, 140);
            panelInactiveClients.TabIndex = 7;
            // 
            // lblInactiveClientsValue
            // 
            lblInactiveClientsValue.BackColor = Color.Transparent;
            lblInactiveClientsValue.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            lblInactiveClientsValue.ForeColor = Color.White;
            lblInactiveClientsValue.Location = new Point(20, 55);
            lblInactiveClientsValue.Name = "lblInactiveClientsValue";
            lblInactiveClientsValue.Size = new Size(310, 85);
            lblInactiveClientsValue.TabIndex = 1;
            lblInactiveClientsValue.Text = "0";
            lblInactiveClientsValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblInactiveClientsTitle
            // 
            lblInactiveClientsTitle.BackColor = Color.Transparent;
            lblInactiveClientsTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblInactiveClientsTitle.ForeColor = Color.White;
            lblInactiveClientsTitle.Location = new Point(20, 20);
            lblInactiveClientsTitle.Name = "lblInactiveClientsTitle";
            lblInactiveClientsTitle.Size = new Size(310, 35);
            lblInactiveClientsTitle.TabIndex = 0;
            lblInactiveClientsTitle.Text = "💤 Clients Inactifs";
            lblInactiveClientsTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.Transparent;
            txtSearch.BorderRadius = 10;
            txtSearch.CustomizableEdges = customizableEdges9;
            txtSearch.DefaultText = "";
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.Location = new Point(50, 245);
            txtSearch.Margin = new Padding(4, 5, 4, 5);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "🔍 Rechercher par nom, téléphone ou email...";
            txtSearch.SelectedText = "";
            txtSearch.ShadowDecoration.BorderRadius = 10;
            txtSearch.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtSearch.ShadowDecoration.Depth = 5;
            txtSearch.ShadowDecoration.Enabled = true;
            txtSearch.Size = new Size(550, 50);
            txtSearch.TabIndex = 8;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Transparent;
            btnRefresh.BorderRadius = 10;
            btnRefresh.CustomizableEdges = customizableEdges11;
            btnRefresh.FillColor = Color.FromArgb(99, 102, 241);
            btnRefresh.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(625, 245);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.ShadowDecoration.BorderRadius = 10;
            btnRefresh.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnRefresh.ShadowDecoration.Depth = 8;
            btnRefresh.ShadowDecoration.Enabled = true;
            btnRefresh.Size = new Size(180, 50);
            btnRefresh.TabIndex = 9;
            btnRefresh.Text = "🔄 Actualiser";
            btnRefresh.Click += btnRefresh_Click;
            // 
            // gunaDataGridViewClients
            // 
            gunaDataGridViewClients.AllowUserToAddRows = false;
            gunaDataGridViewClients.AllowUserToDeleteRows = false;
            gunaDataGridViewClients.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(245, 247, 250);
            gunaDataGridViewClients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(99, 102, 241);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(99, 102, 241);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            gunaDataGridViewClients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            gunaDataGridViewClients.ColumnHeadersHeight = 45;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            gunaDataGridViewClients.DefaultCellStyle = dataGridViewCellStyle3;
            gunaDataGridViewClients.GridColor = Color.FromArgb(231, 229, 255);
            gunaDataGridViewClients.Location = new Point(50, 375);
            gunaDataGridViewClients.Name = "gunaDataGridViewClients";
            gunaDataGridViewClients.ReadOnly = true;
            gunaDataGridViewClients.RowHeadersVisible = false;
            gunaDataGridViewClients.RowHeadersWidth = 51;
            gunaDataGridViewClients.RowTemplate.Height = 40;
            gunaDataGridViewClients.Size = new Size(1475, 430);
            gunaDataGridViewClients.TabIndex = 0;
            gunaDataGridViewClients.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(245, 247, 250);
            gunaDataGridViewClients.ThemeStyle.AlternatingRowsStyle.Font = null;
            gunaDataGridViewClients.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            gunaDataGridViewClients.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            gunaDataGridViewClients.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            gunaDataGridViewClients.ThemeStyle.BackColor = Color.White;
            gunaDataGridViewClients.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            gunaDataGridViewClients.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(99, 102, 241);
            gunaDataGridViewClients.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            gunaDataGridViewClients.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gunaDataGridViewClients.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            gunaDataGridViewClients.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            gunaDataGridViewClients.ThemeStyle.HeaderStyle.Height = 45;
            gunaDataGridViewClients.ThemeStyle.ReadOnly = true;
            gunaDataGridViewClients.ThemeStyle.RowsStyle.BackColor = Color.White;
            gunaDataGridViewClients.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gunaDataGridViewClients.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9.5F);
            gunaDataGridViewClients.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            gunaDataGridViewClients.ThemeStyle.RowsStyle.Height = 40;
            gunaDataGridViewClients.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            gunaDataGridViewClients.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            gunaDataGridViewClients.CellContentClick += gunaDataGridViewClients_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(30, 39, 73);
            label1.Location = new Point(50, 320);
            label1.Name = "label1";
            label1.Size = new Size(299, 45);
            label1.TabIndex = 20;
            label1.Text = "📋 Liste des clients";
            // 
            // AccueilClient
            // 
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(1600, 850);
            Controls.Add(btnRefresh);
            Controls.Add(txtSearch);
            Controls.Add(panelInactiveClients);
            Controls.Add(panelActiveClients);
            Controls.Add(panelNewClients);
            Controls.Add(panelTotalClients);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Controls.Add(gunaDataGridViewClients);
            Name = "AccueilClient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "🏥 Gestion Clients - Dashboard";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panelTotalClients.ResumeLayout(false);
            panelNewClients.ResumeLayout(false);
            panelActiveClients.ResumeLayout(false);
            panelInactiveClients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gunaDataGridViewClients).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView gunaDataGridViewClients;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem medicamentsToolStripMenuItem;
        private ToolStripMenuItem clientsToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem commandesToolStripMenuItem;
        private Label label1;

        // Statistics Cards
        private Guna.UI2.WinForms.Guna2Panel panelTotalClients;
        private Label lblTotalClientsTitle;
        private Label lblTotalClientsValue;
        private Guna.UI2.WinForms.Guna2Panel panelNewClients;
        private Label lblNewClientsTitle;
        private Label lblNewClientsValue;
        private Guna.UI2.WinForms.Guna2Panel panelActiveClients;
        private Label lblActiveClientsTitle;
        private Label lblActiveClientsValue;
        private Guna.UI2.WinForms.Guna2Panel panelInactiveClients;
        private Label lblInactiveClientsTitle;
        private Label lblInactiveClientsValue;

        // Search and Filter
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
    }
}