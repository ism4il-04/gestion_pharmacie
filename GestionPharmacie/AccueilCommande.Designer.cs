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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            menuStrip1 = new MenuStrip();
            medicamentsToolStripMenuItem = new ToolStripMenuItem();
            clientsToolStripMenuItem = new ToolStripMenuItem();
            commandesToolStripMenuItem = new ToolStripMenuItem();
            ajouterUneCommandeToolStripMenuItem = new ToolStripMenuItem();
            modifierCommandeToolStripMenuItem = new ToolStripMenuItem();
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
            txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            comboStatusFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            panelTotalOrders.SuspendLayout();
            panelRevenue.SuspendLayout();
            panelTodayOrders.SuspendLayout();
            panelPendingOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(0, 122, 204);
            menuStrip1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            menuStrip1.ForeColor = Color.White;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { medicamentsToolStripMenuItem, clientsToolStripMenuItem, commandesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 2, 0, 2);
            menuStrip1.Size = new Size(2000, 38);
            menuStrip1.TabIndex = 2;
            // 
            // medicamentsToolStripMenuItem
            // 
            medicamentsToolStripMenuItem.Name = "medicamentsToolStripMenuItem";
            medicamentsToolStripMenuItem.Size = new Size(169, 34);
            medicamentsToolStripMenuItem.Text = "Medicaments";
            medicamentsToolStripMenuItem.Click += medicamentsToolStripMenuItem_Click;
            // 
            // clientsToolStripMenuItem
            // 
            clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            clientsToolStripMenuItem.Size = new Size(99, 34);
            clientsToolStripMenuItem.Text = "Clients";
            clientsToolStripMenuItem.Click += clientsToolStripMenuItem_Click;
            // 
            // commandesToolStripMenuItem
            // 
            commandesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ajouterUneCommandeToolStripMenuItem, modifierCommandeToolStripMenuItem });
            commandesToolStripMenuItem.Name = "commandesToolStripMenuItem";
            commandesToolStripMenuItem.Size = new Size(157, 34);
            commandesToolStripMenuItem.Text = "Commandes";
            // 
            // ajouterUneCommandeToolStripMenuItem
            // 
            ajouterUneCommandeToolStripMenuItem.Name = "ajouterUneCommandeToolStripMenuItem";
            ajouterUneCommandeToolStripMenuItem.Size = new Size(358, 38);
            ajouterUneCommandeToolStripMenuItem.Text = "Ajouter une commande";
            ajouterUneCommandeToolStripMenuItem.Click += ajouterUneCommandeToolStripMenuItem_Click;
            // 
            // modifierCommandeToolStripMenuItem
            // 
            modifierCommandeToolStripMenuItem.Name = "modifierCommandeToolStripMenuItem";
            modifierCommandeToolStripMenuItem.Size = new Size(358, 38);
            modifierCommandeToolStripMenuItem.Text = "Modifier commande";
            modifierCommandeToolStripMenuItem.Click += modifierCommandeToolStripMenuItem_Click;
            // 
            // panelTotalOrders
            // 
            panelTotalOrders.BackColor = Color.Transparent;
            panelTotalOrders.BorderRadius = 10;
            panelTotalOrders.Controls.Add(lblTotalOrdersValue);
            panelTotalOrders.Controls.Add(lblTotalOrdersTitle);
            panelTotalOrders.CustomizableEdges = customizableEdges1;
            panelTotalOrders.FillColor = Color.FromArgb(94, 148, 255);
            panelTotalOrders.Location = new Point(62, 75);
            panelTotalOrders.Margin = new Padding(4, 4, 4, 4);
            panelTotalOrders.Name = "panelTotalOrders";
            panelTotalOrders.ShadowDecoration.CustomizableEdges = customizableEdges2;
            panelTotalOrders.ShadowDecoration.Enabled = true;
            panelTotalOrders.Size = new Size(438, 150);
            panelTotalOrders.TabIndex = 4;
            // 
            // lblTotalOrdersValue
            // 
            lblTotalOrdersValue.AutoSize = true;
            lblTotalOrdersValue.BackColor = Color.Transparent;
            lblTotalOrdersValue.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblTotalOrdersValue.ForeColor = Color.White;
            lblTotalOrdersValue.Location = new Point(25, 69);
            lblTotalOrdersValue.Margin = new Padding(4, 0, 4, 0);
            lblTotalOrdersValue.Name = "lblTotalOrdersValue";
            lblTotalOrdersValue.Size = new Size(64, 74);
            lblTotalOrdersValue.TabIndex = 1;
            lblTotalOrdersValue.Text = "0";
            // 
            // lblTotalOrdersTitle
            // 
            lblTotalOrdersTitle.AutoSize = true;
            lblTotalOrdersTitle.BackColor = Color.Transparent;
            lblTotalOrdersTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotalOrdersTitle.ForeColor = Color.White;
            lblTotalOrdersTitle.Location = new Point(25, 25);
            lblTotalOrdersTitle.Margin = new Padding(4, 0, 4, 0);
            lblTotalOrdersTitle.Name = "lblTotalOrdersTitle";
            lblTotalOrdersTitle.Size = new Size(259, 32);
            lblTotalOrdersTitle.TabIndex = 0;
            lblTotalOrdersTitle.Text = "📦 Total Commandes";
            // 
            // panelRevenue
            // 
            panelRevenue.BackColor = Color.Transparent;
            panelRevenue.BorderRadius = 10;
            panelRevenue.Controls.Add(lblRevenueValue);
            panelRevenue.Controls.Add(lblRevenueTitle);
            panelRevenue.CustomizableEdges = customizableEdges3;
            panelRevenue.FillColor = Color.FromArgb(16, 185, 129);
            panelRevenue.Location = new Point(531, 75);
            panelRevenue.Margin = new Padding(4, 4, 4, 4);
            panelRevenue.Name = "panelRevenue";
            panelRevenue.ShadowDecoration.CustomizableEdges = customizableEdges4;
            panelRevenue.ShadowDecoration.Enabled = true;
            panelRevenue.Size = new Size(438, 150);
            panelRevenue.TabIndex = 5;
            //panelRevenue.Paint += panelRevenue_Paint;
            // 
            // lblRevenueValue
            // 
            lblRevenueValue.AutoSize = true;
            lblRevenueValue.BackColor = Color.Transparent;
            lblRevenueValue.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblRevenueValue.ForeColor = Color.White;
            lblRevenueValue.Location = new Point(25, 69);
            lblRevenueValue.Margin = new Padding(4, 0, 4, 0);
            lblRevenueValue.Name = "lblRevenueValue";
            lblRevenueValue.Size = new Size(141, 65);
            lblRevenueValue.TabIndex = 1;
            lblRevenueValue.Text = "0 DH";
            // 
            // lblRevenueTitle
            // 
            lblRevenueTitle.AutoSize = true;
            lblRevenueTitle.BackColor = Color.Transparent;
            lblRevenueTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblRevenueTitle.ForeColor = Color.White;
            lblRevenueTitle.Location = new Point(25, 25);
            lblRevenueTitle.Margin = new Padding(4, 0, 4, 0);
            lblRevenueTitle.Name = "lblRevenueTitle";
            lblRevenueTitle.Size = new Size(197, 32);
            lblRevenueTitle.TabIndex = 0;
            lblRevenueTitle.Text = "💰 Revenu Total";
            // 
            // panelTodayOrders
            // 
            panelTodayOrders.BackColor = Color.Transparent;
            panelTodayOrders.BorderRadius = 10;
            panelTodayOrders.Controls.Add(lblTodayOrdersValue);
            panelTodayOrders.Controls.Add(lblTodayOrdersTitle);
            panelTodayOrders.CustomizableEdges = customizableEdges5;
            panelTodayOrders.FillColor = Color.FromArgb(251, 146, 60);
            panelTodayOrders.Location = new Point(1000, 75);
            panelTodayOrders.Margin = new Padding(4, 4, 4, 4);
            panelTodayOrders.Name = "panelTodayOrders";
            panelTodayOrders.ShadowDecoration.CustomizableEdges = customizableEdges6;
            panelTodayOrders.ShadowDecoration.Enabled = true;
            panelTodayOrders.Size = new Size(438, 150);
            panelTodayOrders.TabIndex = 6;
            // 
            // lblTodayOrdersValue
            // 
            lblTodayOrdersValue.AutoSize = true;
            lblTodayOrdersValue.BackColor = Color.Transparent;
            lblTodayOrdersValue.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblTodayOrdersValue.ForeColor = Color.White;
            lblTodayOrdersValue.Location = new Point(25, 69);
            lblTodayOrdersValue.Margin = new Padding(4, 0, 4, 0);
            lblTodayOrdersValue.Name = "lblTodayOrdersValue";
            lblTodayOrdersValue.Size = new Size(64, 74);
            lblTodayOrdersValue.TabIndex = 1;
            lblTodayOrdersValue.Text = "0";
            // 
            // lblTodayOrdersTitle
            // 
            lblTodayOrdersTitle.AutoSize = true;
            lblTodayOrdersTitle.BackColor = Color.Transparent;
            lblTodayOrdersTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTodayOrdersTitle.ForeColor = Color.White;
            lblTodayOrdersTitle.Location = new Point(25, 25);
            lblTodayOrdersTitle.Margin = new Padding(4, 0, 4, 0);
            lblTodayOrdersTitle.Name = "lblTodayOrdersTitle";
            lblTodayOrdersTitle.Size = new Size(190, 32);
            lblTodayOrdersTitle.TabIndex = 0;
            lblTodayOrdersTitle.Text = "📅 Aujourd'hui";
            // 
            // panelPendingOrders
            // 
            panelPendingOrders.BackColor = Color.Transparent;
            panelPendingOrders.BorderRadius = 10;
            panelPendingOrders.Controls.Add(lblPendingOrdersValue);
            panelPendingOrders.Controls.Add(lblPendingOrdersTitle);
            panelPendingOrders.CustomizableEdges = customizableEdges7;
            panelPendingOrders.FillColor = Color.FromArgb(239, 68, 68);
            panelPendingOrders.Location = new Point(1469, 75);
            panelPendingOrders.Margin = new Padding(4, 4, 4, 4);
            panelPendingOrders.Name = "panelPendingOrders";
            panelPendingOrders.ShadowDecoration.CustomizableEdges = customizableEdges8;
            panelPendingOrders.ShadowDecoration.Enabled = true;
            panelPendingOrders.Size = new Size(438, 150);
            panelPendingOrders.TabIndex = 7;
            // 
            // lblPendingOrdersValue
            // 
            lblPendingOrdersValue.AutoSize = true;
            lblPendingOrdersValue.BackColor = Color.Transparent;
            lblPendingOrdersValue.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblPendingOrdersValue.ForeColor = Color.White;
            lblPendingOrdersValue.Location = new Point(25, 69);
            lblPendingOrdersValue.Margin = new Padding(4, 0, 4, 0);
            lblPendingOrdersValue.Name = "lblPendingOrdersValue";
            lblPendingOrdersValue.Size = new Size(64, 74);
            lblPendingOrdersValue.TabIndex = 1;
            lblPendingOrdersValue.Text = "0";
            // 
            // lblPendingOrdersTitle
            // 
            lblPendingOrdersTitle.AutoSize = true;
            lblPendingOrdersTitle.BackColor = Color.Transparent;
            lblPendingOrdersTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPendingOrdersTitle.ForeColor = Color.White;
            lblPendingOrdersTitle.Location = new Point(25, 25);
            lblPendingOrdersTitle.Margin = new Padding(4, 0, 4, 0);
            lblPendingOrdersTitle.Name = "lblPendingOrdersTitle";
            lblPendingOrdersTitle.Size = new Size(148, 32);
            lblPendingOrdersTitle.TabIndex = 0;
            lblPendingOrdersTitle.Text = "⏳ En Cours";
            // 
            // txtSearch
            // 
            txtSearch.BorderRadius = 8;
            txtSearch.CustomizableEdges = customizableEdges9;
            txtSearch.DefaultText = "";
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.Location = new Point(62, 262);
            txtSearch.Margin = new Padding(5, 6, 5, 6);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "🔍 Rechercher par client...";
            txtSearch.SelectedText = "";
            txtSearch.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtSearch.Size = new Size(500, 50);
            txtSearch.TabIndex = 8;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // comboStatusFilter
            // 
            comboStatusFilter.BackColor = Color.Transparent;
            comboStatusFilter.BorderRadius = 8;
            comboStatusFilter.CustomizableEdges = customizableEdges11;
            comboStatusFilter.DrawMode = DrawMode.OwnerDrawFixed;
            comboStatusFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            comboStatusFilter.FocusedColor = Color.Empty;
            comboStatusFilter.Font = new Font("Segoe UI", 10F);
            comboStatusFilter.ForeColor = Color.FromArgb(68, 88, 112);
            comboStatusFilter.ItemHeight = 30;
            comboStatusFilter.Items.AddRange(new object[] { "Tous les statuts", "en_cours", "livree", "annulee" });
            comboStatusFilter.Location = new Point(588, 262);
            comboStatusFilter.Margin = new Padding(4, 4, 4, 4);
            comboStatusFilter.Name = "comboStatusFilter";
            comboStatusFilter.ShadowDecoration.CustomizableEdges = customizableEdges12;
            comboStatusFilter.Size = new Size(312, 36);
            comboStatusFilter.StartIndex = 0;
            comboStatusFilter.TabIndex = 9;
            comboStatusFilter.SelectedIndexChanged += comboStatusFilter_SelectedIndexChanged;
            // 
            // btnRefresh
            // 
            btnRefresh.BorderRadius = 8;
            btnRefresh.CustomizableEdges = customizableEdges11;
            btnRefresh.FillColor = Color.FromArgb(0, 122, 204);
            btnRefresh.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(925, 262);
            btnRefresh.Margin = new Padding(4, 4, 4, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnRefresh.Size = new Size(188, 50);
            btnRefresh.TabIndex = 10;
            btnRefresh.Text = "🔄 Actualiser";
            btnRefresh.Click += btnRefresh_Click;
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 122, 204);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            guna2DataGridView1.ColumnHeadersHeight = 40;
            guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            guna2DataGridView1.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.Location = new Point(62, 388);
            guna2DataGridView1.Margin = new Padding(4, 4, 4, 4);
            guna2DataGridView1.Name = "guna2DataGridView1";
            guna2DataGridView1.RowHeadersVisible = false;
            guna2DataGridView1.RowHeadersWidth = 51;
            guna2DataGridView1.RowTemplate.Height = 35;
            guna2DataGridView1.Size = new Size(1844, 600);
            guna2DataGridView1.TabIndex = 3;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 40;
            guna2DataGridView1.ThemeStyle.ReadOnly = false;
            guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            guna2DataGridView1.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridView1.ThemeStyle.RowsStyle.Height = 35;
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridView1.CellDoubleClick += guna2DataGridView1_CellDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(62, 338);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(296, 38);
            label1.TabIndex = 20;
            label1.Text = "Commandes récentes";
            // 
            // AccueilCommande
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 244, 248);
            ClientSize = new Size(2000, 1038);
            Controls.Add(btnRefresh);
            Controls.Add(comboStatusFilter);
            Controls.Add(txtSearch);
            Controls.Add(panelPendingOrders);
            Controls.Add(panelTodayOrders);
            Controls.Add(panelRevenue);
            Controls.Add(panelTotalOrders);
            Controls.Add(label1);
            Controls.Add(guna2DataGridView1);
            Controls.Add(menuStrip1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "AccueilCommande";
            Text = "Dashboard Commandes";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panelTotalOrders.ResumeLayout(false);
            panelTotalOrders.PerformLayout();
            panelRevenue.ResumeLayout(false);
            panelRevenue.PerformLayout();
            panelTodayOrders.ResumeLayout(false);
            panelTodayOrders.PerformLayout();
            panelPendingOrders.ResumeLayout(false);
            panelPendingOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem medicamentsToolStripMenuItem;
        private ToolStripMenuItem clientsToolStripMenuItem;
        private ToolStripMenuItem commandesToolStripMenuItem;
        private ToolStripMenuItem ajouterUneCommandeToolStripMenuItem;
        private ToolStripMenuItem modifierCommandeToolStripMenuItem;
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
    }
}