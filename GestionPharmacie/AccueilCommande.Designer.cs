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
            menuStrip1 = new MenuStrip();
            medicamentsToolStripMenuItem = new ToolStripMenuItem();
            ajouterMedicamentToolStripMenuItem = new ToolStripMenuItem();
            modifierMedicamentToolStripMenuItem = new ToolStripMenuItem();
            ajouterUnLotToolStripMenuItem = new ToolStripMenuItem();
            clientsToolStripMenuItem = new ToolStripMenuItem();
            ajouterClientToolStripMenuItem = new ToolStripMenuItem();
            modifierClientToolStripMenuItem = new ToolStripMenuItem();
            archiverClientToolStripMenuItem = new ToolStripMenuItem();
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
            panelTotalOrders.Location = new Point(62, 75);
            panelTotalOrders.Margin = new Padding(4);
            panelTotalOrders.Name = "panelTotalOrders";
            panelTotalOrders.ShadowDecoration.BorderRadius = 15;
            panelTotalOrders.ShadowDecoration.Color = Color.FromArgb(99, 102, 241);
            panelTotalOrders.ShadowDecoration.CustomizableEdges = customizableEdges2;
            panelTotalOrders.ShadowDecoration.Depth = 20;
            panelTotalOrders.ShadowDecoration.Enabled = true;
            panelTotalOrders.ShadowDecoration.Shadow = new Padding(0, 0, 8, 8);
            panelTotalOrders.Size = new Size(438, 160);
            panelTotalOrders.TabIndex = 4;
            // 
            // lblTotalOrdersValue
            // 
            lblTotalOrdersValue.BackColor = Color.Transparent;
            lblTotalOrdersValue.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            lblTotalOrdersValue.ForeColor = Color.White;
            lblTotalOrdersValue.Location = new Point(25, 60);
            lblTotalOrdersValue.Margin = new Padding(4, 0, 4, 0);
            lblTotalOrdersValue.Name = "lblTotalOrdersValue";
            lblTotalOrdersValue.Size = new Size(388, 85);
            lblTotalOrdersValue.TabIndex = 1;
            lblTotalOrdersValue.Text = "0";
            lblTotalOrdersValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTotalOrdersTitle
            // 
            lblTotalOrdersTitle.BackColor = Color.Transparent;
            lblTotalOrdersTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotalOrdersTitle.ForeColor = Color.White;
            lblTotalOrdersTitle.Location = new Point(25, 20);
            lblTotalOrdersTitle.Margin = new Padding(4, 0, 4, 0);
            lblTotalOrdersTitle.Name = "lblTotalOrdersTitle";
            lblTotalOrdersTitle.Size = new Size(388, 40);
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
            panelRevenue.Location = new Point(531, 75);
            panelRevenue.Margin = new Padding(4);
            panelRevenue.Name = "panelRevenue";
            panelRevenue.ShadowDecoration.BorderRadius = 15;
            panelRevenue.ShadowDecoration.Color = Color.FromArgb(16, 185, 129);
            panelRevenue.ShadowDecoration.CustomizableEdges = customizableEdges4;
            panelRevenue.ShadowDecoration.Depth = 20;
            panelRevenue.ShadowDecoration.Enabled = true;
            panelRevenue.ShadowDecoration.Shadow = new Padding(0, 0, 8, 8);
            panelRevenue.Size = new Size(438, 160);
            panelRevenue.TabIndex = 5;
            // 
            // lblRevenueValue
            // 
            lblRevenueValue.BackColor = Color.Transparent;
            lblRevenueValue.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            lblRevenueValue.ForeColor = Color.White;
            lblRevenueValue.Location = new Point(25, 60);
            lblRevenueValue.Margin = new Padding(4, 0, 4, 0);
            lblRevenueValue.Name = "lblRevenueValue";
            lblRevenueValue.Size = new Size(388, 85);
            lblRevenueValue.TabIndex = 1;
            lblRevenueValue.Text = "0 DH";
            lblRevenueValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblRevenueTitle
            // 
            lblRevenueTitle.BackColor = Color.Transparent;
            lblRevenueTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblRevenueTitle.ForeColor = Color.White;
            lblRevenueTitle.Location = new Point(25, 20);
            lblRevenueTitle.Margin = new Padding(4, 0, 4, 0);
            lblRevenueTitle.Name = "lblRevenueTitle";
            lblRevenueTitle.Size = new Size(388, 40);
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
            panelTodayOrders.Location = new Point(1000, 75);
            panelTodayOrders.Margin = new Padding(4);
            panelTodayOrders.Name = "panelTodayOrders";
            panelTodayOrders.ShadowDecoration.BorderRadius = 15;
            panelTodayOrders.ShadowDecoration.Color = Color.FromArgb(251, 146, 60);
            panelTodayOrders.ShadowDecoration.CustomizableEdges = customizableEdges6;
            panelTodayOrders.ShadowDecoration.Depth = 20;
            panelTodayOrders.ShadowDecoration.Enabled = true;
            panelTodayOrders.ShadowDecoration.Shadow = new Padding(0, 0, 8, 8);
            panelTodayOrders.Size = new Size(438, 160);
            panelTodayOrders.TabIndex = 6;
            // 
            // lblTodayOrdersValue
            // 
            lblTodayOrdersValue.BackColor = Color.Transparent;
            lblTodayOrdersValue.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            lblTodayOrdersValue.ForeColor = Color.White;
            lblTodayOrdersValue.Location = new Point(25, 60);
            lblTodayOrdersValue.Margin = new Padding(4, 0, 4, 0);
            lblTodayOrdersValue.Name = "lblTodayOrdersValue";
            lblTodayOrdersValue.Size = new Size(388, 85);
            lblTodayOrdersValue.TabIndex = 1;
            lblTodayOrdersValue.Text = "0";
            lblTodayOrdersValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTodayOrdersTitle
            // 
            lblTodayOrdersTitle.BackColor = Color.Transparent;
            lblTodayOrdersTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTodayOrdersTitle.ForeColor = Color.White;
            lblTodayOrdersTitle.Location = new Point(25, 20);
            lblTodayOrdersTitle.Margin = new Padding(4, 0, 4, 0);
            lblTodayOrdersTitle.Name = "lblTodayOrdersTitle";
            lblTodayOrdersTitle.Size = new Size(388, 40);
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
            panelPendingOrders.Location = new Point(1469, 75);
            panelPendingOrders.Margin = new Padding(4);
            panelPendingOrders.Name = "panelPendingOrders";
            panelPendingOrders.ShadowDecoration.BorderRadius = 15;
            panelPendingOrders.ShadowDecoration.Color = Color.FromArgb(239, 68, 68);
            panelPendingOrders.ShadowDecoration.CustomizableEdges = customizableEdges8;
            panelPendingOrders.ShadowDecoration.Depth = 20;
            panelPendingOrders.ShadowDecoration.Enabled = true;
            panelPendingOrders.ShadowDecoration.Shadow = new Padding(0, 0, 8, 8);
            panelPendingOrders.Size = new Size(438, 160);
            panelPendingOrders.TabIndex = 7;
            // 
            // lblPendingOrdersValue
            // 
            lblPendingOrdersValue.BackColor = Color.Transparent;
            lblPendingOrdersValue.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            lblPendingOrdersValue.ForeColor = Color.White;
            lblPendingOrdersValue.Location = new Point(25, 60);
            lblPendingOrdersValue.Margin = new Padding(4, 0, 4, 0);
            lblPendingOrdersValue.Name = "lblPendingOrdersValue";
            lblPendingOrdersValue.Size = new Size(388, 85);
            lblPendingOrdersValue.TabIndex = 1;
            lblPendingOrdersValue.Text = "0";
            lblPendingOrdersValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPendingOrdersTitle
            // 
            lblPendingOrdersTitle.BackColor = Color.Transparent;
            lblPendingOrdersTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPendingOrdersTitle.ForeColor = Color.White;
            lblPendingOrdersTitle.Location = new Point(25, 20);
            lblPendingOrdersTitle.Margin = new Padding(4, 0, 4, 0);
            lblPendingOrdersTitle.Name = "lblPendingOrdersTitle";
            lblPendingOrdersTitle.Size = new Size(388, 40);
            lblPendingOrdersTitle.TabIndex = 0;
            lblPendingOrdersTitle.Text = "⏳ En Cours";
            lblPendingOrdersTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.Transparent;
            txtSearch.BorderRadius = 10;
            txtSearch.CustomizableEdges = customizableEdges9;
            txtSearch.DefaultText = "";
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.Location = new Point(62, 265);
            txtSearch.Margin = new Padding(5, 6, 5, 6);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "🔍 Rechercher par client...";
            txtSearch.SelectedText = "";
            txtSearch.ShadowDecoration.BorderRadius = 10;
            txtSearch.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtSearch.ShadowDecoration.Depth = 5;
            txtSearch.ShadowDecoration.Enabled = true;
            txtSearch.Size = new Size(550, 50);
            txtSearch.TabIndex = 8;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // comboStatusFilter
            // 
            comboStatusFilter.BackColor = Color.Transparent;
            comboStatusFilter.BorderRadius = 10;
            comboStatusFilter.CustomizableEdges = customizableEdges11;
            comboStatusFilter.DrawMode = DrawMode.OwnerDrawFixed;
            comboStatusFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            comboStatusFilter.FocusedColor = Color.FromArgb(99, 102, 241);
            comboStatusFilter.FocusedState.BorderColor = Color.FromArgb(99, 102, 241);
            comboStatusFilter.Font = new Font("Segoe UI", 10F);
            comboStatusFilter.ForeColor = Color.FromArgb(68, 88, 112);
            comboStatusFilter.ItemHeight = 30;
            comboStatusFilter.Items.AddRange(new object[] { "Tous les statuts", "En cours", "Livrée", "Annulée" });
            comboStatusFilter.Location = new Point(638, 265);
            comboStatusFilter.Margin = new Padding(4);
            comboStatusFilter.Name = "comboStatusFilter";
            comboStatusFilter.ShadowDecoration.BorderRadius = 10;
            comboStatusFilter.ShadowDecoration.CustomizableEdges = customizableEdges12;
            comboStatusFilter.ShadowDecoration.Depth = 5;
            comboStatusFilter.ShadowDecoration.Enabled = true;
            comboStatusFilter.Size = new Size(340, 36);
            comboStatusFilter.StartIndex = 0;
            comboStatusFilter.TabIndex = 9;
            comboStatusFilter.SelectedIndexChanged += comboStatusFilter_SelectedIndexChanged;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Transparent;
            btnRefresh.BorderRadius = 10;
            btnRefresh.CustomizableEdges = customizableEdges11;
            btnRefresh.FillColor = Color.FromArgb(99, 102, 241);
            btnRefresh.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(1005, 265);
            btnRefresh.Margin = new Padding(4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.ShadowDecoration.BorderRadius = 10;
            btnRefresh.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnRefresh.ShadowDecoration.Depth = 8;
            btnRefresh.ShadowDecoration.Enabled = true;
            btnRefresh.Size = new Size(200, 50);
            btnRefresh.TabIndex = 10;
            btnRefresh.Text = "🔄 Actualiser";
            btnRefresh.Click += btnRefresh_Click;
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(245, 247, 250);
            guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(99, 102, 241);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(99, 102, 241);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            guna2DataGridView1.ColumnHeadersHeight = 45;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            guna2DataGridView1.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.Location = new Point(62, 400);
            guna2DataGridView1.Margin = new Padding(4);
            guna2DataGridView1.Name = "guna2DataGridView1";
            guna2DataGridView1.ReadOnly = true;
            guna2DataGridView1.RowHeadersVisible = false;
            guna2DataGridView1.RowHeadersWidth = 51;
            guna2DataGridView1.RowTemplate.Height = 40;
            guna2DataGridView1.Size = new Size(1844, 588);
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
            guna2DataGridView1.ThemeStyle.RowsStyle.Height = 40;
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridView1.CellDoubleClick += guna2DataGridView1_CellDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(30, 39, 73);
            label1.Location = new Point(62, 345);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(385, 45);
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
            menuStrip1.Padding = new Padding(12, 8, 0, 8);
            menuStrip1.Size = new Size(2000, 50);
            menuStrip1.TabIndex = 21;
            // 
            // medicamentsToolStripMenuItem
            // 
            medicamentsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ajouterMedicamentToolStripMenuItem, modifierMedicamentToolStripMenuItem, ajouterUnLotToolStripMenuItem });
            medicamentsToolStripMenuItem.ForeColor = Color.White;
            medicamentsToolStripMenuItem.Name = "medicamentsToolStripMenuItem";
            medicamentsToolStripMenuItem.Padding = new Padding(12, 0, 12, 0);
            medicamentsToolStripMenuItem.Size = new Size(218, 34);
            medicamentsToolStripMenuItem.Text = "💊 Médicaments";
            medicamentsToolStripMenuItem.Click += medicamentsToolStripMenuItem_Click_1;
            // 
            // ajouterMedicamentToolStripMenuItem
            // 
            ajouterMedicamentToolStripMenuItem.BackColor = Color.White;
            ajouterMedicamentToolStripMenuItem.ForeColor = Color.FromArgb(30, 39, 73);
            ajouterMedicamentToolStripMenuItem.Name = "ajouterMedicamentToolStripMenuItem";
            ajouterMedicamentToolStripMenuItem.Size = new Size(341, 38);
            ajouterMedicamentToolStripMenuItem.Text = "Ajouter Médicament";
            // 
            // modifierMedicamentToolStripMenuItem
            // 
            modifierMedicamentToolStripMenuItem.BackColor = Color.White;
            modifierMedicamentToolStripMenuItem.ForeColor = Color.FromArgb(30, 39, 73);
            modifierMedicamentToolStripMenuItem.Name = "modifierMedicamentToolStripMenuItem";
            modifierMedicamentToolStripMenuItem.Size = new Size(341, 38);
            modifierMedicamentToolStripMenuItem.Text = "Modifier Médicament";
            // 
            // ajouterUnLotToolStripMenuItem
            // 
            ajouterUnLotToolStripMenuItem.BackColor = Color.White;
            ajouterUnLotToolStripMenuItem.ForeColor = Color.FromArgb(30, 39, 73);
            ajouterUnLotToolStripMenuItem.Name = "ajouterUnLotToolStripMenuItem";
            ajouterUnLotToolStripMenuItem.Size = new Size(341, 38);
            ajouterUnLotToolStripMenuItem.Text = "Ajouter un lot";
            // 
            // clientsToolStripMenuItem
            // 
            clientsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ajouterClientToolStripMenuItem, modifierClientToolStripMenuItem, archiverClientToolStripMenuItem });
            clientsToolStripMenuItem.ForeColor = Color.White;
            clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            clientsToolStripMenuItem.Padding = new Padding(12, 0, 12, 0);
            clientsToolStripMenuItem.Size = new Size(148, 34);
            clientsToolStripMenuItem.Text = "👥 Clients";
            clientsToolStripMenuItem.Click += clientsToolStripMenuItem_Click_1;
            // 
            // ajouterClientToolStripMenuItem
            // 
            ajouterClientToolStripMenuItem.BackColor = Color.White;
            ajouterClientToolStripMenuItem.ForeColor = Color.FromArgb(30, 39, 73);
            ajouterClientToolStripMenuItem.Name = "ajouterClientToolStripMenuItem";
            ajouterClientToolStripMenuItem.Size = new Size(271, 38);
            ajouterClientToolStripMenuItem.Text = "Ajouter Client";
            // 
            // modifierClientToolStripMenuItem
            // 
            modifierClientToolStripMenuItem.BackColor = Color.White;
            modifierClientToolStripMenuItem.ForeColor = Color.FromArgb(30, 39, 73);
            modifierClientToolStripMenuItem.Name = "modifierClientToolStripMenuItem";
            modifierClientToolStripMenuItem.Size = new Size(271, 38);
            modifierClientToolStripMenuItem.Text = "Modifier Client";
            // 
            // archiverClientToolStripMenuItem
            // 
            archiverClientToolStripMenuItem.BackColor = Color.White;
            archiverClientToolStripMenuItem.ForeColor = Color.FromArgb(30, 39, 73);
            archiverClientToolStripMenuItem.Name = "archiverClientToolStripMenuItem";
            archiverClientToolStripMenuItem.Size = new Size(271, 38);
            archiverClientToolStripMenuItem.Text = "Archiver Client";
            // 
            // commandesToolStripMenuItem
            // 
            commandesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ajouterCommandeToolStripMenuItem });
            commandesToolStripMenuItem.ForeColor = Color.White;
            commandesToolStripMenuItem.Name = "commandesToolStripMenuItem";
            commandesToolStripMenuItem.Padding = new Padding(12, 0, 12, 0);
            commandesToolStripMenuItem.Size = new Size(206, 34);
            commandesToolStripMenuItem.Text = "📦 Commandes";
            // 
            // ajouterCommandeToolStripMenuItem
            // 
            ajouterCommandeToolStripMenuItem.Name = "ajouterCommandeToolStripMenuItem";
            ajouterCommandeToolStripMenuItem.Size = new Size(314, 38);
            ajouterCommandeToolStripMenuItem.Text = "Ajouter commande";
            ajouterCommandeToolStripMenuItem.Click += ajouterCommandeToolStripMenuItem_Click;
            // 
            // AccueilCommande
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(2000, 1050);
            Controls.Add(menuStrip1);
            Controls.Add(btnRefresh);
            Controls.Add(comboStatusFilter);
            Controls.Add(txtSearch);
            Controls.Add(panelPendingOrders);
            Controls.Add(panelTodayOrders);
            Controls.Add(panelRevenue);
            Controls.Add(panelTotalOrders);
            Controls.Add(label1);
            Controls.Add(guna2DataGridView1);
            Margin = new Padding(4);
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
        private ToolStripMenuItem ajouterMedicamentToolStripMenuItem;
        private ToolStripMenuItem modifierMedicamentToolStripMenuItem;
        private ToolStripMenuItem ajouterUnLotToolStripMenuItem;
        private ToolStripMenuItem clientsToolStripMenuItem;
        private ToolStripMenuItem ajouterClientToolStripMenuItem;
        private ToolStripMenuItem modifierClientToolStripMenuItem;
        private ToolStripMenuItem archiverClientToolStripMenuItem;
        private ToolStripMenuItem commandesToolStripMenuItem;
        private ToolStripMenuItem ajouterCommandeToolStripMenuItem;
    }
}