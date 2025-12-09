namespace GestionPharmacie
{
    partial class AccueilCommande
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panelTotalOrders = new Guna.UI2.WinForms.Guna2Panel();
            lblTotalOrdersValue = new Label();
            lblTotalOrdersTitle = new Label();
            panelRevenue = new Guna.UI2.WinForms.Guna2Panel();
            lblRevenueValue = new Label();
            lblRevenueTitle = new Label();
            panelTodayOrders = new Guna.UI2.WinForms.Guna2Panel();
            lblTodayOrdersValue = new Label();
            lblTodayOrdersTitle = new Label();
            panelPendingOrders = new Guna.UI2.WinForms.Guna2Panel();
            lblPendingOrdersValue = new Label();
            lblPendingOrdersTitle = new Label();
            btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            medicamentsToolStripMenuItem = new ToolStripMenuItem();
            clientsToolStripMenuItem = new ToolStripMenuItem();
            commandesToolStripMenuItem = new ToolStripMenuItem();
            ajouterCommandeToolStripMenuItem = new ToolStripMenuItem();
            panelTotalOrders.SuspendLayout();
            panelRevenue.SuspendLayout();
            panelTodayOrders.SuspendLayout();
            panelPendingOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panelTotalOrders
            // 
            panelTotalOrders.BackColor = Color.Transparent;
            panelTotalOrders.BorderRadius = 15;
            panelTotalOrders.Controls.Add(lblTotalOrdersValue);
            panelTotalOrders.Controls.Add(lblTotalOrdersTitle);
            panelTotalOrders.CustomizableEdges = customizableEdges1;
            panelTotalOrders.FillColor = Color.FromArgb(99, 102, 241);
            panelTotalOrders.Location = new Point(30, 98);
            panelTotalOrders.Name = "panelTotalOrders";
            panelTotalOrders.ShadowDecoration.BorderRadius = 15;
            panelTotalOrders.ShadowDecoration.Color = Color.FromArgb(99, 102, 241);
            panelTotalOrders.ShadowDecoration.CustomizableEdges = customizableEdges2;
            panelTotalOrders.ShadowDecoration.Depth = 20;
            panelTotalOrders.ShadowDecoration.Enabled = true;
            panelTotalOrders.ShadowDecoration.Shadow = new Padding(0, 0, 8, 8);
            panelTotalOrders.Size = new Size(350, 128);
            panelTotalOrders.TabIndex = 4;
            // 
            // lblTotalOrdersValue
            // 
            lblTotalOrdersValue.BackColor = Color.Transparent;
            lblTotalOrdersValue.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            lblTotalOrdersValue.ForeColor = Color.White;
            lblTotalOrdersValue.Location = new Point(20, 48);
            lblTotalOrdersValue.Name = "lblTotalOrdersValue";
            lblTotalOrdersValue.Size = new Size(310, 68);
            lblTotalOrdersValue.TabIndex = 1;
            lblTotalOrdersValue.Text = "0";
            lblTotalOrdersValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTotalOrdersTitle
            // 
            lblTotalOrdersTitle.BackColor = Color.Transparent;
            lblTotalOrdersTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotalOrdersTitle.ForeColor = Color.White;
            lblTotalOrdersTitle.Location = new Point(20, 16);
            lblTotalOrdersTitle.Name = "lblTotalOrdersTitle";
            lblTotalOrdersTitle.Size = new Size(310, 32);
            lblTotalOrdersTitle.TabIndex = 0;
            lblTotalOrdersTitle.Text = "📦 Total Commandes";
            lblTotalOrdersTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelRevenue
            // 
            panelRevenue.BackColor = Color.Transparent;
            panelRevenue.BorderRadius = 15;
            panelRevenue.Controls.Add(lblRevenueValue);
            panelRevenue.Controls.Add(lblRevenueTitle);
            panelRevenue.CustomizableEdges = customizableEdges3;
            panelRevenue.FillColor = Color.FromArgb(16, 185, 129);
            panelRevenue.Location = new Point(400, 98);
            panelRevenue.Name = "panelRevenue";
            panelRevenue.ShadowDecoration.BorderRadius = 15;
            panelRevenue.ShadowDecoration.Color = Color.FromArgb(16, 185, 129);
            panelRevenue.ShadowDecoration.CustomizableEdges = customizableEdges4;
            panelRevenue.ShadowDecoration.Depth = 20;
            panelRevenue.ShadowDecoration.Enabled = true;
            panelRevenue.ShadowDecoration.Shadow = new Padding(0, 0, 8, 8);
            panelRevenue.Size = new Size(350, 128);
            panelRevenue.TabIndex = 5;
            // 
            // lblRevenueValue
            // 
            lblRevenueValue.BackColor = Color.Transparent;
            lblRevenueValue.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            lblRevenueValue.ForeColor = Color.White;
            lblRevenueValue.Location = new Point(20, 48);
            lblRevenueValue.Name = "lblRevenueValue";
            lblRevenueValue.Size = new Size(310, 68);
            lblRevenueValue.TabIndex = 1;
            lblRevenueValue.Text = "0 DH";
            lblRevenueValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblRevenueTitle
            // 
            lblRevenueTitle.BackColor = Color.Transparent;
            lblRevenueTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblRevenueTitle.ForeColor = Color.White;
            lblRevenueTitle.Location = new Point(20, 16);
            lblRevenueTitle.Name = "lblRevenueTitle";
            lblRevenueTitle.Size = new Size(310, 32);
            lblRevenueTitle.TabIndex = 0;
            lblRevenueTitle.Text = "💰 Revenu Total";
            lblRevenueTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelTodayOrders
            // 
            panelTodayOrders.BackColor = Color.Transparent;
            panelTodayOrders.BorderRadius = 15;
            panelTodayOrders.Controls.Add(lblTodayOrdersValue);
            panelTodayOrders.Controls.Add(lblTodayOrdersTitle);
            panelTodayOrders.CustomizableEdges = customizableEdges5;
            panelTodayOrders.FillColor = Color.FromArgb(251, 146, 60);
            panelTodayOrders.Location = new Point(770, 98);
            panelTodayOrders.Name = "panelTodayOrders";
            panelTodayOrders.ShadowDecoration.BorderRadius = 15;
            panelTodayOrders.ShadowDecoration.Color = Color.FromArgb(251, 146, 60);
            panelTodayOrders.ShadowDecoration.CustomizableEdges = customizableEdges6;
            panelTodayOrders.ShadowDecoration.Depth = 20;
            panelTodayOrders.ShadowDecoration.Enabled = true;
            panelTodayOrders.ShadowDecoration.Shadow = new Padding(0, 0, 8, 8);
            panelTodayOrders.Size = new Size(350, 128);
            panelTodayOrders.TabIndex = 6;
            // 
            // lblTodayOrdersValue
            // 
            lblTodayOrdersValue.BackColor = Color.Transparent;
            lblTodayOrdersValue.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            lblTodayOrdersValue.ForeColor = Color.White;
            lblTodayOrdersValue.Location = new Point(20, 48);
            lblTodayOrdersValue.Name = "lblTodayOrdersValue";
            lblTodayOrdersValue.Size = new Size(310, 68);
            lblTodayOrdersValue.TabIndex = 1;
            lblTodayOrdersValue.Text = "0";
            lblTodayOrdersValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTodayOrdersTitle
            // 
            lblTodayOrdersTitle.BackColor = Color.Transparent;
            lblTodayOrdersTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTodayOrdersTitle.ForeColor = Color.White;
            lblTodayOrdersTitle.Location = new Point(20, 16);
            lblTodayOrdersTitle.Name = "lblTodayOrdersTitle";
            lblTodayOrdersTitle.Size = new Size(310, 32);
            lblTodayOrdersTitle.TabIndex = 0;
            lblTodayOrdersTitle.Text = "📅 Aujourd'hui";
            lblTodayOrdersTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelPendingOrders
            // 
            panelPendingOrders.BackColor = Color.Transparent;
            panelPendingOrders.BorderRadius = 15;
            panelPendingOrders.Controls.Add(lblPendingOrdersValue);
            panelPendingOrders.Controls.Add(lblPendingOrdersTitle);
            panelPendingOrders.CustomizableEdges = customizableEdges7;
            panelPendingOrders.FillColor = Color.FromArgb(239, 68, 68);
            panelPendingOrders.Location = new Point(1140, 98);
            panelPendingOrders.Name = "panelPendingOrders";
            panelPendingOrders.ShadowDecoration.BorderRadius = 15;
            panelPendingOrders.ShadowDecoration.Color = Color.FromArgb(239, 68, 68);
            panelPendingOrders.ShadowDecoration.CustomizableEdges = customizableEdges8;
            panelPendingOrders.ShadowDecoration.Depth = 20;
            panelPendingOrders.ShadowDecoration.Enabled = true;
            panelPendingOrders.ShadowDecoration.Shadow = new Padding(0, 0, 8, 8);
            panelPendingOrders.Size = new Size(350, 128);
            panelPendingOrders.TabIndex = 7;
            // 
            // lblPendingOrdersValue
            // 
            lblPendingOrdersValue.BackColor = Color.Transparent;
            lblPendingOrdersValue.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            lblPendingOrdersValue.ForeColor = Color.White;
            lblPendingOrdersValue.Location = new Point(20, 48);
            lblPendingOrdersValue.Name = "lblPendingOrdersValue";
            lblPendingOrdersValue.Size = new Size(310, 68);
            lblPendingOrdersValue.TabIndex = 1;
            lblPendingOrdersValue.Text = "0";
            lblPendingOrdersValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPendingOrdersTitle
            // 
            lblPendingOrdersTitle.BackColor = Color.Transparent;
            lblPendingOrdersTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPendingOrdersTitle.ForeColor = Color.White;
            lblPendingOrdersTitle.Location = new Point(20, 16);
            lblPendingOrdersTitle.Name = "lblPendingOrdersTitle";
            lblPendingOrdersTitle.Size = new Size(310, 32);
            lblPendingOrdersTitle.TabIndex = 0;
            lblPendingOrdersTitle.Text = "⏳ En Cours";
            lblPendingOrdersTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Transparent;
            btnRefresh.BorderRadius = 10;
            btnRefresh.CustomizableEdges = customizableEdges9;
            btnRefresh.FillColor = Color.FromArgb(99, 102, 241);
            btnRefresh.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.HoverState.FillColor = Color.FromArgb(79, 82, 221);
            btnRefresh.Location = new Point(387, 279);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.ShadowDecoration.BorderRadius = 10;
            btnRefresh.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnRefresh.ShadowDecoration.Depth = 8;
            btnRefresh.ShadowDecoration.Enabled = true;
            btnRefresh.Size = new Size(170, 45);
            btnRefresh.TabIndex = 10;
            btnRefresh.Text = "🔄 Actualiser";
            btnRefresh.Click += btnRefresh_Click;
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(245, 247, 250);
            guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(99, 102, 241);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(99, 102, 241);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            guna2DataGridView1.ColumnHeadersHeight = 45;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            guna2DataGridView1.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.Location = new Point(30, 330);
            guna2DataGridView1.Name = "guna2DataGridView1";
            guna2DataGridView1.ReadOnly = true;
            guna2DataGridView1.RowHeadersVisible = false;
            guna2DataGridView1.RowHeadersWidth = 51;
            guna2DataGridView1.RowTemplate.Height = 45;
            guna2DataGridView1.Size = new Size(1460, 480);
            guna2DataGridView1.TabIndex = 3;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(245, 247, 250);
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(99, 102, 241);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 45;
            guna2DataGridView1.ThemeStyle.ReadOnly = true;
            guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            guna2DataGridView1.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9.5F);
            guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridView1.ThemeStyle.RowsStyle.Height = 45;
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridView1.CellDoubleClick += guna2DataGridView1_CellDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(30, 39, 73);
            label1.Location = new Point(30, 279);
            label1.Name = "label1";
            label1.Size = new Size(336, 37);
            label1.TabIndex = 20;
            label1.Text = "📋 Commandes récentes";
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
            menuStrip1.Padding = new Padding(10, 6, 0, 6);
            menuStrip1.Size = new Size(1520, 41);
            menuStrip1.TabIndex = 21;
            // 
            // medicamentsToolStripMenuItem
            // 
            medicamentsToolStripMenuItem.ForeColor = Color.White;
            medicamentsToolStripMenuItem.Name = "medicamentsToolStripMenuItem";
            medicamentsToolStripMenuItem.Padding = new Padding(12, 0, 12, 0);
            medicamentsToolStripMenuItem.Size = new Size(185, 29);
            medicamentsToolStripMenuItem.Text = "💊 Médicaments";
            medicamentsToolStripMenuItem.Click += medicamentsToolStripMenuItem_Click_1;
            // 
            // clientsToolStripMenuItem
            // 
            clientsToolStripMenuItem.ForeColor = Color.White;
            clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            clientsToolStripMenuItem.Padding = new Padding(12, 0, 12, 0);
            clientsToolStripMenuItem.Size = new Size(126, 29);
            clientsToolStripMenuItem.Text = "👥 Clients";
            clientsToolStripMenuItem.Click += clientsToolStripMenuItem_Click_1;
            // 
            // commandesToolStripMenuItem
            // 
            commandesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ajouterCommandeToolStripMenuItem });
            commandesToolStripMenuItem.ForeColor = Color.White;
            commandesToolStripMenuItem.Name = "commandesToolStripMenuItem";
            commandesToolStripMenuItem.Padding = new Padding(12, 0, 12, 0);
            commandesToolStripMenuItem.Size = new Size(177, 29);
            commandesToolStripMenuItem.Text = "📦 Commandes";
            // 
            // ajouterCommandeToolStripMenuItem
            // 
            ajouterCommandeToolStripMenuItem.Name = "ajouterCommandeToolStripMenuItem";
            ajouterCommandeToolStripMenuItem.Size = new Size(269, 30);
            ajouterCommandeToolStripMenuItem.Text = "Ajouter commande";
            ajouterCommandeToolStripMenuItem.Click += ajouterCommandeToolStripMenuItem_Click;
            // 
            // AccueilCommande
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(1520, 850);
            Controls.Add(menuStrip1);
            Controls.Add(label1);
            Controls.Add(btnRefresh);
            Controls.Add(panelPendingOrders);
            Controls.Add(panelTodayOrders);
            Controls.Add(panelRevenue);
            Controls.Add(panelTotalOrders);
            Controls.Add(guna2DataGridView1);
            Name = "AccueilCommande";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "🏥 Gestion Commandes - Dashboard";
            panelTotalOrders.ResumeLayout(false);
            panelRevenue.ResumeLayout(false);
            panelTodayOrders.ResumeLayout(false);
            panelPendingOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Label label1;

        // Statistics Cards
        private Guna.UI2.WinForms.Guna2Panel panelTotalOrders;
        private Label lblTotalOrdersTitle;
        private Label lblTotalOrdersValue;
        private Guna.UI2.WinForms.Guna2Panel panelRevenue;
        private Label lblRevenueTitle;
        private Label lblRevenueValue;
        private Guna.UI2.WinForms.Guna2Panel panelTodayOrders;
        private Label lblTodayOrdersTitle;
        private Label lblTodayOrdersValue;
        private Guna.UI2.WinForms.Guna2Panel panelPendingOrders;
        private Label lblPendingOrdersTitle;
        private Label lblPendingOrdersValue;

        // Search and Filter
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2ComboBox comboStatusFilter;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem medicamentsToolStripMenuItem;
        private ToolStripMenuItem clientsToolStripMenuItem;
        private ToolStripMenuItem commandesToolStripMenuItem;
        private ToolStripMenuItem ajouterCommandeToolStripMenuItem;
    }
}