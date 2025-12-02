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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
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

            menuStrip1 = new MenuStrip();
            medicamentsToolStripMenuItem = new ToolStripMenuItem();
            clientsToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripMenuItem();
            commandesToolStripMenuItem = new ToolStripMenuItem();

            // Statistics Cards
            panelTotalClients = new Guna.UI2.WinForms.Guna2Panel();
            lblTotalClientsTitle = new Label();
            lblTotalClientsValue = new Label();

            panelNewClients = new Guna.UI2.WinForms.Guna2Panel();
            lblNewClientsTitle = new Label();
            lblNewClientsValue = new Label();

            panelActiveClients = new Guna.UI2.WinForms.Guna2Panel();
            lblActiveClientsTitle = new Label();
            lblActiveClientsValue = new Label();

            panelInactiveClients = new Guna.UI2.WinForms.Guna2Panel();
            lblInactiveClientsTitle = new Label();
            lblInactiveClientsValue = new Label();

            // Search and Filter
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

            // menuStrip1
            menuStrip1.BackColor = Color.FromArgb(0, 122, 204);
            menuStrip1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            menuStrip1.ForeColor = Color.White;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { medicamentsToolStripMenuItem, clientsToolStripMenuItem, commandesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1600, 33);
            menuStrip1.TabIndex = 3;

            // medicamentsToolStripMenuItem
            medicamentsToolStripMenuItem.Name = "medicamentsToolStripMenuItem";
            medicamentsToolStripMenuItem.Size = new Size(144, 29);
            medicamentsToolStripMenuItem.Text = "Medicaments";
            medicamentsToolStripMenuItem.Click += medicamentsToolStripMenuItem_Click_1;

            // clientsToolStripMenuItem
            clientsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem4, toolStripMenuItem5 });
            clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            clientsToolStripMenuItem.Size = new Size(85, 29);
            clientsToolStripMenuItem.Text = "Clients";

            // toolStripMenuItem4
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(231, 30);
            toolStripMenuItem4.Text = "Ajouter Client";
            toolStripMenuItem4.Click += ajouterClientToolStripMenuItem_Click;

            // toolStripMenuItem5
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(231, 30);
            toolStripMenuItem5.Text = "Modifier Client";
            toolStripMenuItem5.Click += modifierClientToolStripMenuItem_Click;

            // commandesToolStripMenuItem
            commandesToolStripMenuItem.Name = "commandesToolStripMenuItem";
            commandesToolStripMenuItem.Size = new Size(136, 29);
            commandesToolStripMenuItem.Text = "Commandes";
            commandesToolStripMenuItem.Click += commandesToolStripMenuItem_Click;

            // panelTotalClients
            panelTotalClients.BackColor = Color.Transparent;
            panelTotalClients.BorderRadius = 10;
            panelTotalClients.Controls.Add(lblTotalClientsValue);
            panelTotalClients.Controls.Add(lblTotalClientsTitle);
            panelTotalClients.CustomizableEdges = customizableEdges1;
            panelTotalClients.FillColor = Color.FromArgb(94, 148, 255);
            panelTotalClients.Location = new Point(50, 60);
            panelTotalClients.Name = "panelTotalClients";
            panelTotalClients.ShadowDecoration.CustomizableEdges = customizableEdges2;
            panelTotalClients.ShadowDecoration.Enabled = true;
            panelTotalClients.Size = new Size(350, 120);
            panelTotalClients.TabIndex = 4;

            // lblTotalClientsTitle
            lblTotalClientsTitle.AutoSize = true;
            lblTotalClientsTitle.BackColor = Color.Transparent;
            lblTotalClientsTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotalClientsTitle.ForeColor = Color.White;
            lblTotalClientsTitle.Location = new Point(20, 20);
            lblTotalClientsTitle.Name = "lblTotalClientsTitle";
            lblTotalClientsTitle.Size = new Size(150, 28);
            lblTotalClientsTitle.TabIndex = 0;
            lblTotalClientsTitle.Text = "👥 Total Clients";

            // lblTotalClientsValue
            lblTotalClientsValue.AutoSize = true;
            lblTotalClientsValue.BackColor = Color.Transparent;
            lblTotalClientsValue.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblTotalClientsValue.ForeColor = Color.White;
            lblTotalClientsValue.Location = new Point(20, 55);
            lblTotalClientsValue.Name = "lblTotalClientsValue";
            lblTotalClientsValue.Size = new Size(50, 62);
            lblTotalClientsValue.TabIndex = 1;
            lblTotalClientsValue.Text = "0";

            // panelNewClients
            panelNewClients.BackColor = Color.Transparent;
            panelNewClients.BorderRadius = 10;
            panelNewClients.Controls.Add(lblNewClientsValue);
            panelNewClients.Controls.Add(lblNewClientsTitle);
            panelNewClients.CustomizableEdges = customizableEdges3;
            panelNewClients.FillColor = Color.FromArgb(16, 185, 129);
            panelNewClients.Location = new Point(425, 60);
            panelNewClients.Name = "panelNewClients";
            panelNewClients.ShadowDecoration.CustomizableEdges = customizableEdges4;
            panelNewClients.ShadowDecoration.Enabled = true;
            panelNewClients.Size = new Size(350, 120);
            panelNewClients.TabIndex = 5;

            // lblNewClientsTitle
            lblNewClientsTitle.AutoSize = true;
            lblNewClientsTitle.BackColor = Color.Transparent;
            lblNewClientsTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblNewClientsTitle.ForeColor = Color.White;
            lblNewClientsTitle.Location = new Point(20, 20);
            lblNewClientsTitle.Name = "lblNewClientsTitle";
            lblNewClientsTitle.Size = new Size(180, 28);
            lblNewClientsTitle.TabIndex = 0;
            lblNewClientsTitle.Text = "✨ Nouveaux (Mois)";

            // lblNewClientsValue
            lblNewClientsValue.AutoSize = true;
            lblNewClientsValue.BackColor = Color.Transparent;
            lblNewClientsValue.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblNewClientsValue.ForeColor = Color.White;
            lblNewClientsValue.Location = new Point(20, 55);
            lblNewClientsValue.Name = "lblNewClientsValue";
            lblNewClientsValue.Size = new Size(50, 62);
            lblNewClientsValue.TabIndex = 1;
            lblNewClientsValue.Text = "0";

            // panelActiveClients
            panelActiveClients.BackColor = Color.Transparent;
            panelActiveClients.BorderRadius = 10;
            panelActiveClients.Controls.Add(lblActiveClientsValue);
            panelActiveClients.Controls.Add(lblActiveClientsTitle);
            panelActiveClients.CustomizableEdges = customizableEdges5;
            panelActiveClients.FillColor = Color.FromArgb(251, 146, 60);
            panelActiveClients.Location = new Point(800, 60);
            panelActiveClients.Name = "panelActiveClients";
            panelActiveClients.ShadowDecoration.CustomizableEdges = customizableEdges6;
            panelActiveClients.ShadowDecoration.Enabled = true;
            panelActiveClients.Size = new Size(350, 120);
            panelActiveClients.TabIndex = 6;

            // lblActiveClientsTitle
            lblActiveClientsTitle.AutoSize = true;
            lblActiveClientsTitle.BackColor = Color.Transparent;
            lblActiveClientsTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblActiveClientsTitle.ForeColor = Color.White;
            lblActiveClientsTitle.Location = new Point(20, 20);
            lblActiveClientsTitle.Name = "lblActiveClientsTitle";
            lblActiveClientsTitle.Size = new Size(140, 28);
            lblActiveClientsTitle.TabIndex = 0;
            lblActiveClientsTitle.Text = "✅ Actifs";

            // lblActiveClientsValue
            lblActiveClientsValue.AutoSize = true;
            lblActiveClientsValue.BackColor = Color.Transparent;
            lblActiveClientsValue.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblActiveClientsValue.ForeColor = Color.White;
            lblActiveClientsValue.Location = new Point(20, 55);
            lblActiveClientsValue.Name = "lblActiveClientsValue";
            lblActiveClientsValue.Size = new Size(50, 62);
            lblActiveClientsValue.TabIndex = 1;
            lblActiveClientsValue.Text = "0";

            // panelInactiveClients
            panelInactiveClients.BackColor = Color.Transparent;
            panelInactiveClients.BorderRadius = 10;
            panelInactiveClients.Controls.Add(lblInactiveClientsValue);
            panelInactiveClients.Controls.Add(lblInactiveClientsTitle);
            panelInactiveClients.CustomizableEdges = customizableEdges7;
            panelInactiveClients.FillColor = Color.FromArgb(239, 68, 68);
            panelInactiveClients.Location = new Point(1175, 60);
            panelInactiveClients.Name = "panelInactiveClients";
            panelInactiveClients.ShadowDecoration.CustomizableEdges = customizableEdges8;
            panelInactiveClients.ShadowDecoration.Enabled = true;
            panelInactiveClients.Size = new Size(350, 120);
            panelInactiveClients.TabIndex = 7;

            // lblInactiveClientsTitle
            lblInactiveClientsTitle.AutoSize = true;
            lblInactiveClientsTitle.BackColor = Color.Transparent;
            lblInactiveClientsTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblInactiveClientsTitle.ForeColor = Color.White;
            lblInactiveClientsTitle.Location = new Point(20, 20);
            lblInactiveClientsTitle.Name = "lblInactiveClientsTitle";
            lblInactiveClientsTitle.Size = new Size(120, 28);
            lblInactiveClientsTitle.TabIndex = 0;
            lblInactiveClientsTitle.Text = "💤 Inactifs";

            // lblInactiveClientsValue
            lblInactiveClientsValue.AutoSize = true;
            lblInactiveClientsValue.BackColor = Color.Transparent;
            lblInactiveClientsValue.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblInactiveClientsValue.ForeColor = Color.White;
            lblInactiveClientsValue.Location = new Point(20, 55);
            lblInactiveClientsValue.Name = "lblInactiveClientsValue";
            lblInactiveClientsValue.Size = new Size(50, 62);
            lblInactiveClientsValue.TabIndex = 1;
            lblInactiveClientsValue.Text = "0";

            // txtSearch
            txtSearch.BorderRadius = 8;
            txtSearch.CustomizableEdges = customizableEdges9;
            txtSearch.DefaultText = "";
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.Location = new Point(50, 210);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "🔍 Rechercher par nom, téléphone ou email...";
            txtSearch.SelectedText = "";
            txtSearch.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtSearch.Size = new Size(500, 40);
            txtSearch.TabIndex = 8;
            txtSearch.TextChanged += txtSearch_TextChanged;

            // btnRefresh
            btnRefresh.BorderRadius = 8;
            btnRefresh.CustomizableEdges = customizableEdges11;
            btnRefresh.FillColor = Color.FromArgb(0, 122, 204);
            btnRefresh.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(570, 210);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnRefresh.Size = new Size(150, 40);
            btnRefresh.TabIndex = 9;
            btnRefresh.Text = "🔄 Actualiser";
            btnRefresh.Click += btnRefresh_Click;

            // gunaDataGridViewClients
            gunaDataGridViewClients.AllowUserToAddRows = false;
            gunaDataGridViewClients.AllowUserToDeleteRows = false;
            gunaDataGridViewClients.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            gunaDataGridViewClients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 122, 204);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            gunaDataGridViewClients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            gunaDataGridViewClients.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(200, 230, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            gunaDataGridViewClients.DefaultCellStyle = dataGridViewCellStyle3;
            gunaDataGridViewClients.GridColor = Color.LightGray;
            gunaDataGridViewClients.Location = new Point(50, 310);
            gunaDataGridViewClients.Name = "gunaDataGridViewClients";
            gunaDataGridViewClients.RowHeadersVisible = false;
            gunaDataGridViewClients.RowHeadersWidth = 51;
            gunaDataGridViewClients.RowTemplate.Height = 38;
            gunaDataGridViewClients.Size = new Size(1475, 480);
            gunaDataGridViewClients.TabIndex = 0;
            gunaDataGridViewClients.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            gunaDataGridViewClients.ThemeStyle.AlternatingRowsStyle.Font = null;
            gunaDataGridViewClients.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            gunaDataGridViewClients.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            gunaDataGridViewClients.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            gunaDataGridViewClients.ThemeStyle.BackColor = Color.White;
            gunaDataGridViewClients.ThemeStyle.GridColor = Color.LightGray;
            gunaDataGridViewClients.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(0, 122, 204);
            gunaDataGridViewClients.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            gunaDataGridViewClients.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            gunaDataGridViewClients.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            gunaDataGridViewClients.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            gunaDataGridViewClients.ThemeStyle.HeaderStyle.Height = 40;
            gunaDataGridViewClients.ThemeStyle.ReadOnly = false;
            gunaDataGridViewClients.ThemeStyle.RowsStyle.BackColor = Color.White;
            gunaDataGridViewClients.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gunaDataGridViewClients.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 10F);
            gunaDataGridViewClients.ThemeStyle.RowsStyle.ForeColor = Color.Black;
            gunaDataGridViewClients.ThemeStyle.RowsStyle.Height = 38;
            gunaDataGridViewClients.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(200, 230, 255);
            gunaDataGridViewClients.ThemeStyle.RowsStyle.SelectionForeColor = Color.Black;
            gunaDataGridViewClients.CellContentClick += gunaDataGridViewClients_CellContentClick;

            // label1
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(50, 270);
            label1.Name = "label1";
            label1.Size = new Size(180, 32);
            label1.TabIndex = 20;
            label1.Text = "Liste des clients";

            // AccueilClient
            BackColor = Color.FromArgb(240, 244, 248);
            ClientSize = new Size(1600, 830);
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
            Text = "Dashboard Clients";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panelTotalClients.ResumeLayout(false);
            panelTotalClients.PerformLayout();
            panelNewClients.ResumeLayout(false);
            panelNewClients.PerformLayout();
            panelActiveClients.ResumeLayout(false);
            panelActiveClients.PerformLayout();
            panelInactiveClients.ResumeLayout(false);
            panelInactiveClients.PerformLayout();
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