using Guna.UI2.WinForms;
using static Guna.UI2.WinForms.Suite.Descriptions;

namespace GestionPharmacie
{
    partial class Accueil
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            menuStrip1 = new MenuStrip();
            medicamentsToolStripMenuItem = new ToolStripMenuItem();
            ajouterMedicamentToolStripMenuItem = new ToolStripMenuItem();
            modifierMedicamentToolStripMenuItem = new ToolStripMenuItem();
            ajouterUnLotToolStripMenuItem = new ToolStripMenuItem();
            archiverMedicamentToolStripMenuItem = new ToolStripMenuItem();
            clientsToolStripMenuItem = new ToolStripMenuItem();
            commandesToolStripMenuItem = new ToolStripMenuItem();
            panelStats = new Panel();
            cardTotalMedicaments = new Guna2Panel();
            lblTotalMedicaments = new Label();
            lblTotalMedicamentsTitle = new Label();
            cardValeurStock = new Guna2Panel();
            lblValeurStock = new Label();
            lblValeurStockTitle = new Label();
            cardAlertes = new Guna2Panel();
            lblAlertes = new Label();
            lblAlertesTitle = new Label();
            cardPeremption = new Guna2Panel();
            lblPeremption = new Label();
            lblPeremptionTitle = new Label();
            panelRecherche = new Panel();
            txtRecherche = new Guna2TextBox();
            cmbFiltre = new Guna2ComboBox();
            btnRefresh = new Guna2Button();
            gridview = new Guna2DataGridView();
            panelPagination = new Panel();
            btnPrevious = new Guna2Button();
            lblPagination = new Label();
            btnNext = new Guna2Button();
            panelAlertes = new Panel();
            lblAlertesPeremptionTitle = new Label();
            listBoxAlertes = new ListBox();
            panelGraphique = new Panel();
            lblGraphiqueTitle = new Label();
            listBoxCategories = new ListBox();
            menuStrip1.SuspendLayout();
            panelStats.SuspendLayout();
            cardTotalMedicaments.SuspendLayout();
            cardValeurStock.SuspendLayout();
            cardAlertes.SuspendLayout();
            cardPeremption.SuspendLayout();
            panelRecherche.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridview).BeginInit();
            panelPagination.SuspendLayout();
            panelAlertes.SuspendLayout();
            panelGraphique.SuspendLayout();
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
            menuStrip1.Padding = new Padding(10, 6, 0, 6);
            menuStrip1.Size = new Size(1539, 41);
            menuStrip1.TabIndex = 0;
            // 
            // medicamentsToolStripMenuItem
            // 
            medicamentsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ajouterMedicamentToolStripMenuItem, modifierMedicamentToolStripMenuItem, ajouterUnLotToolStripMenuItem, archiverMedicamentToolStripMenuItem });
            medicamentsToolStripMenuItem.ForeColor = Color.White;
            medicamentsToolStripMenuItem.Name = "medicamentsToolStripMenuItem";
            medicamentsToolStripMenuItem.Padding = new Padding(12, 0, 12, 0);
            medicamentsToolStripMenuItem.Size = new Size(185, 29);
            medicamentsToolStripMenuItem.Text = "💊 Médicaments";
            // 
            // ajouterMedicamentToolStripMenuItem
            // 
            ajouterMedicamentToolStripMenuItem.BackColor = Color.White;
            ajouterMedicamentToolStripMenuItem.ForeColor = Color.FromArgb(30, 39, 73);
            ajouterMedicamentToolStripMenuItem.Name = "ajouterMedicamentToolStripMenuItem";
            ajouterMedicamentToolStripMenuItem.Size = new Size(290, 30);
            ajouterMedicamentToolStripMenuItem.Text = "Ajouter Médicament";
            ajouterMedicamentToolStripMenuItem.Click += ajouterMedicamentToolStripMenuItem_Click;
            // 
            // modifierMedicamentToolStripMenuItem
            // 
            modifierMedicamentToolStripMenuItem.BackColor = Color.White;
            modifierMedicamentToolStripMenuItem.ForeColor = Color.FromArgb(30, 39, 73);
            modifierMedicamentToolStripMenuItem.Name = "modifierMedicamentToolStripMenuItem";
            modifierMedicamentToolStripMenuItem.Size = new Size(290, 30);
            modifierMedicamentToolStripMenuItem.Text = "Modifier Médicament";
            modifierMedicamentToolStripMenuItem.Click += modifierMedicamentToolStripMenuItem_Click;
            // 
            // ajouterUnLotToolStripMenuItem
            // 
            ajouterUnLotToolStripMenuItem.BackColor = Color.White;
            ajouterUnLotToolStripMenuItem.ForeColor = Color.FromArgb(30, 39, 73);
            ajouterUnLotToolStripMenuItem.Name = "ajouterUnLotToolStripMenuItem";
            ajouterUnLotToolStripMenuItem.Size = new Size(290, 30);
            ajouterUnLotToolStripMenuItem.Text = "Ajouter un lot";
            ajouterUnLotToolStripMenuItem.Click += ajouterUnLotToolStripMenuItem_Click;
            // 
            // archiverMedicamentToolStripMenuItem
            // 
            archiverMedicamentToolStripMenuItem.Name = "archiverMedicamentToolStripMenuItem";
            archiverMedicamentToolStripMenuItem.Size = new Size(290, 30);
            archiverMedicamentToolStripMenuItem.Text = "Archiver Medicament";
            archiverMedicamentToolStripMenuItem.Click += archiverMedicamentToolStripMenuItem_Click;
            // 
            // clientsToolStripMenuItem
            // 
            clientsToolStripMenuItem.ForeColor = Color.White;
            clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            clientsToolStripMenuItem.Padding = new Padding(12, 0, 12, 0);
            clientsToolStripMenuItem.Size = new Size(126, 29);
            clientsToolStripMenuItem.Text = "👥 Clients";
            clientsToolStripMenuItem.Click += clientsToolStripMenuItem_Click;
            // 
            // commandesToolStripMenuItem
            // 
            commandesToolStripMenuItem.ForeColor = Color.White;
            commandesToolStripMenuItem.Name = "commandesToolStripMenuItem";
            commandesToolStripMenuItem.Padding = new Padding(12, 0, 12, 0);
            commandesToolStripMenuItem.Size = new Size(177, 29);
            commandesToolStripMenuItem.Text = "📦 Commandes";
            commandesToolStripMenuItem.Click += commandesToolStripMenuItem_Click;
            // 
            // panelStats
            // 
            panelStats.Controls.Add(cardTotalMedicaments);
            panelStats.Controls.Add(cardValeurStock);
            panelStats.Controls.Add(cardAlertes);
            panelStats.Controls.Add(cardPeremption);
            panelStats.Location = new Point(20, 56);
            panelStats.Name = "panelStats";
            panelStats.Size = new Size(1040, 128);
            panelStats.TabIndex = 1;
            // 
            // cardTotalMedicaments
            // 
            cardTotalMedicaments.BackColor = Color.Transparent;
            cardTotalMedicaments.BorderRadius = 15;
            cardTotalMedicaments.Controls.Add(lblTotalMedicaments);
            cardTotalMedicaments.Controls.Add(lblTotalMedicamentsTitle);
            cardTotalMedicaments.CustomizableEdges = customizableEdges1;
            cardTotalMedicaments.FillColor = Color.FromArgb(99, 102, 241);
            cardTotalMedicaments.Location = new Point(10, 10);
            cardTotalMedicaments.Name = "cardTotalMedicaments";
            cardTotalMedicaments.ShadowDecoration.BorderRadius = 15;
            cardTotalMedicaments.ShadowDecoration.Color = Color.FromArgb(99, 102, 241);
            cardTotalMedicaments.ShadowDecoration.CustomizableEdges = customizableEdges2;
            cardTotalMedicaments.ShadowDecoration.Depth = 20;
            cardTotalMedicaments.ShadowDecoration.Enabled = true;
            cardTotalMedicaments.ShadowDecoration.Shadow = new Padding(0, 0, 8, 8);
            cardTotalMedicaments.Size = new Size(244, 108);
            cardTotalMedicaments.TabIndex = 0;
            // 
            // lblTotalMedicaments
            // 
            lblTotalMedicaments.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            lblTotalMedicaments.ForeColor = Color.White;
            lblTotalMedicaments.Location = new Point(10, 37);
            lblTotalMedicaments.Name = "lblTotalMedicaments";
            lblTotalMedicaments.Size = new Size(224, 71);
            lblTotalMedicaments.TabIndex = 1;
            lblTotalMedicaments.Text = "0";
            lblTotalMedicaments.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalMedicamentsTitle
            // 
            lblTotalMedicamentsTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTotalMedicamentsTitle.ForeColor = Color.White;
            lblTotalMedicamentsTitle.Location = new Point(10, 12);
            lblTotalMedicamentsTitle.Name = "lblTotalMedicamentsTitle";
            lblTotalMedicamentsTitle.Size = new Size(224, 25);
            lblTotalMedicamentsTitle.TabIndex = 0;
            lblTotalMedicamentsTitle.Text = "💊 Total Médicaments";
            lblTotalMedicamentsTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cardValeurStock
            // 
            cardValeurStock.BackColor = Color.Transparent;
            cardValeurStock.BorderRadius = 15;
            cardValeurStock.Controls.Add(lblValeurStock);
            cardValeurStock.Controls.Add(lblValeurStockTitle);
            cardValeurStock.CustomizableEdges = customizableEdges3;
            cardValeurStock.FillColor = Color.FromArgb(16, 185, 129);
            cardValeurStock.Location = new Point(270, 10);
            cardValeurStock.Name = "cardValeurStock";
            cardValeurStock.ShadowDecoration.BorderRadius = 15;
            cardValeurStock.ShadowDecoration.Color = Color.FromArgb(16, 185, 129);
            cardValeurStock.ShadowDecoration.CustomizableEdges = customizableEdges4;
            cardValeurStock.ShadowDecoration.Depth = 20;
            cardValeurStock.ShadowDecoration.Enabled = true;
            cardValeurStock.ShadowDecoration.Shadow = new Padding(0, 0, 8, 8);
            cardValeurStock.Size = new Size(244, 108);
            cardValeurStock.TabIndex = 1;
            // 
            // lblValeurStock
            // 
            lblValeurStock.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            lblValeurStock.ForeColor = Color.White;
            lblValeurStock.Location = new Point(10, 40);
            lblValeurStock.Name = "lblValeurStock";
            lblValeurStock.Size = new Size(224, 56);
            lblValeurStock.TabIndex = 1;
            lblValeurStock.Text = "0 DH";
            lblValeurStock.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblValeurStockTitle
            // 
            lblValeurStockTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblValeurStockTitle.ForeColor = Color.White;
            lblValeurStockTitle.Location = new Point(10, 12);
            lblValeurStockTitle.Name = "lblValeurStockTitle";
            lblValeurStockTitle.Size = new Size(224, 25);
            lblValeurStockTitle.TabIndex = 0;
            lblValeurStockTitle.Text = "💰 Valeur du Stock";
            lblValeurStockTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblValeurStockTitle.Click += lblValeurStockTitle_Click;
            // 
            // cardAlertes
            // 
            cardAlertes.BackColor = Color.Transparent;
            cardAlertes.BorderRadius = 15;
            cardAlertes.Controls.Add(lblAlertes);
            cardAlertes.Controls.Add(lblAlertesTitle);
            cardAlertes.CustomizableEdges = customizableEdges5;
            cardAlertes.FillColor = Color.FromArgb(251, 146, 60);
            cardAlertes.Location = new Point(530, 10);
            cardAlertes.Name = "cardAlertes";
            cardAlertes.ShadowDecoration.BorderRadius = 15;
            cardAlertes.ShadowDecoration.Color = Color.FromArgb(251, 146, 60);
            cardAlertes.ShadowDecoration.CustomizableEdges = customizableEdges6;
            cardAlertes.ShadowDecoration.Depth = 20;
            cardAlertes.ShadowDecoration.Enabled = true;
            cardAlertes.ShadowDecoration.Shadow = new Padding(0, 0, 8, 8);
            cardAlertes.Size = new Size(244, 108);
            cardAlertes.TabIndex = 2;
            // 
            // lblAlertes
            // 
            lblAlertes.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            lblAlertes.ForeColor = Color.White;
            lblAlertes.Location = new Point(10, 38);
            lblAlertes.Name = "lblAlertes";
            lblAlertes.Size = new Size(224, 70);
            lblAlertes.TabIndex = 1;
            lblAlertes.Text = "0";
            lblAlertes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAlertesTitle
            // 
            lblAlertesTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblAlertesTitle.ForeColor = Color.White;
            lblAlertesTitle.Location = new Point(10, 12);
            lblAlertesTitle.Name = "lblAlertesTitle";
            lblAlertesTitle.Size = new Size(224, 25);
            lblAlertesTitle.TabIndex = 0;
            lblAlertesTitle.Text = "⚠️ Alertes Stock Faible";
            lblAlertesTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cardPeremption
            // 
            cardPeremption.BackColor = Color.Transparent;
            cardPeremption.BorderRadius = 15;
            cardPeremption.Controls.Add(lblPeremption);
            cardPeremption.Controls.Add(lblPeremptionTitle);
            cardPeremption.CustomizableEdges = customizableEdges7;
            cardPeremption.FillColor = Color.FromArgb(239, 68, 68);
            cardPeremption.Location = new Point(790, 10);
            cardPeremption.Name = "cardPeremption";
            cardPeremption.ShadowDecoration.BorderRadius = 15;
            cardPeremption.ShadowDecoration.Color = Color.FromArgb(239, 68, 68);
            cardPeremption.ShadowDecoration.CustomizableEdges = customizableEdges8;
            cardPeremption.ShadowDecoration.Depth = 20;
            cardPeremption.ShadowDecoration.Enabled = true;
            cardPeremption.ShadowDecoration.Shadow = new Padding(0, 0, 8, 8);
            cardPeremption.Size = new Size(244, 108);
            cardPeremption.TabIndex = 3;
            // 
            // lblPeremption
            // 
            lblPeremption.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            lblPeremption.ForeColor = Color.White;
            lblPeremption.Location = new Point(10, 40);
            lblPeremption.Name = "lblPeremption";
            lblPeremption.Size = new Size(224, 68);
            lblPeremption.TabIndex = 1;
            lblPeremption.Text = "0";
            lblPeremption.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPeremptionTitle
            // 
            lblPeremptionTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblPeremptionTitle.ForeColor = Color.White;
            lblPeremptionTitle.Location = new Point(10, 12);
            lblPeremptionTitle.Name = "lblPeremptionTitle";
            lblPeremptionTitle.Size = new Size(224, 25);
            lblPeremptionTitle.TabIndex = 0;
            lblPeremptionTitle.Text = "🕐 Lots à Expirer (30j)";
            lblPeremptionTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelRecherche
            // 
            panelRecherche.Controls.Add(txtRecherche);
            panelRecherche.Controls.Add(cmbFiltre);
            panelRecherche.Controls.Add(btnRefresh);
            panelRecherche.Location = new Point(20, 200);
            panelRecherche.Name = "panelRecherche";
            panelRecherche.Size = new Size(1040, 56);
            panelRecherche.TabIndex = 2;
            // 
            // txtRecherche
            // 
            txtRecherche.BackColor = Color.Transparent;
            txtRecherche.BorderRadius = 10;
            txtRecherche.CustomizableEdges = customizableEdges9;
            txtRecherche.DefaultText = "";
            txtRecherche.Font = new Font("Segoe UI", 10F);
            txtRecherche.Location = new Point(10, 8);
            txtRecherche.Margin = new Padding(3, 4, 3, 4);
            txtRecherche.Name = "txtRecherche";
            txtRecherche.PlaceholderText = "🔍 Rechercher un médicament...";
            txtRecherche.SelectedText = "";
            txtRecherche.ShadowDecoration.BorderRadius = 10;
            txtRecherche.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtRecherche.ShadowDecoration.Depth = 5;
            txtRecherche.ShadowDecoration.Enabled = true;
            txtRecherche.Size = new Size(440, 40);
            txtRecherche.TabIndex = 0;
            txtRecherche.TextChanged += txtRecherche_TextChanged;
            // 
            // cmbFiltre
            // 
            cmbFiltre.BackColor = Color.Transparent;
            cmbFiltre.BorderRadius = 10;
            cmbFiltre.CustomizableEdges = customizableEdges11;
            cmbFiltre.DrawMode = DrawMode.OwnerDrawFixed;
            cmbFiltre.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFiltre.FocusedColor = Color.FromArgb(99, 102, 241);
            cmbFiltre.FocusedState.BorderColor = Color.FromArgb(99, 102, 241);
            cmbFiltre.Font = new Font("Segoe UI", 10F);
            cmbFiltre.ForeColor = Color.FromArgb(68, 88, 112);
            cmbFiltre.ItemHeight = 30;
            cmbFiltre.Items.AddRange(new object[] { "Tous", "Stock faible (< 10)", "Stock épuisé", "Stock normal (≥ 10)" });
            cmbFiltre.Location = new Point(470, 8);
            cmbFiltre.Name = "cmbFiltre";
            cmbFiltre.ShadowDecoration.BorderRadius = 10;
            cmbFiltre.ShadowDecoration.CustomizableEdges = customizableEdges12;
            cmbFiltre.ShadowDecoration.Depth = 5;
            cmbFiltre.ShadowDecoration.Enabled = true;
            cmbFiltre.Size = new Size(273, 36);
            cmbFiltre.TabIndex = 1;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Transparent;
            btnRefresh.BorderRadius = 10;
            btnRefresh.CustomizableEdges = customizableEdges13;
            btnRefresh.FillColor = Color.FromArgb(99, 102, 241);
            btnRefresh.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(764, 8);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.ShadowDecoration.BorderRadius = 10;
            btnRefresh.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnRefresh.ShadowDecoration.Depth = 8;
            btnRefresh.ShadowDecoration.Enabled = true;
            btnRefresh.Size = new Size(160, 40);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "🔄 Actualiser";
            btnRefresh.Click += btnRefresh_Click;
            // 
            // gridview
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(245, 247, 250);
            gridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(99, 102, 241);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(99, 102, 241);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            gridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            gridview.ColumnHeadersHeight = 45;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            gridview.DefaultCellStyle = dataGridViewCellStyle3;
            gridview.GridColor = Color.FromArgb(231, 229, 255);
            gridview.Location = new Point(20, 268);
            gridview.Name = "gridview";
            gridview.ReadOnly = true;
            gridview.RowHeadersVisible = false;
            gridview.RowHeadersWidth = 51;
            gridview.RowTemplate.Height = 35;
            gridview.Size = new Size(1040, 412);
            gridview.TabIndex = 3;
            gridview.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            gridview.ThemeStyle.AlternatingRowsStyle.Font = null;
            gridview.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            gridview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            gridview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            gridview.ThemeStyle.BackColor = Color.White;
            gridview.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            gridview.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(99, 102, 241);
            gridview.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            gridview.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gridview.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            gridview.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            gridview.ThemeStyle.HeaderStyle.Height = 45;
            gridview.ThemeStyle.ReadOnly = true;
            gridview.ThemeStyle.RowsStyle.BackColor = Color.White;
            gridview.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridview.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9.5F);
            gridview.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            gridview.ThemeStyle.RowsStyle.Height = 35;
            gridview.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            gridview.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            gridview.CellContentClick += gridview_CellContentClick;
            // 
            // panelPagination
            // 
            panelPagination.Controls.Add(btnPrevious);
            panelPagination.Controls.Add(lblPagination);
            panelPagination.Controls.Add(btnNext);
            panelPagination.Location = new Point(20, 692);
            panelPagination.Name = "panelPagination";
            panelPagination.Size = new Size(1040, 56);
            panelPagination.TabIndex = 4;
            // 
            // btnPrevious
            // 
            btnPrevious.BackColor = Color.Transparent;
            btnPrevious.BorderRadius = 10;
            btnPrevious.CustomizableEdges = customizableEdges15;
            btnPrevious.FillColor = Color.FromArgb(99, 102, 241);
            btnPrevious.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnPrevious.ForeColor = Color.White;
            btnPrevious.Location = new Point(320, 8);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.ShadowDecoration.BorderRadius = 10;
            btnPrevious.ShadowDecoration.CustomizableEdges = customizableEdges16;
            btnPrevious.ShadowDecoration.Depth = 8;
            btnPrevious.ShadowDecoration.Enabled = true;
            btnPrevious.Size = new Size(144, 40);
            btnPrevious.TabIndex = 0;
            btnPrevious.Text = "◄ Précédent";
            btnPrevious.Click += btnPrevious_Click;
            // 
            // lblPagination
            // 
            lblPagination.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblPagination.ForeColor = Color.FromArgb(30, 39, 73);
            lblPagination.Location = new Point(450, 8);
            lblPagination.Name = "lblPagination";
            lblPagination.Size = new Size(263, 40);
            lblPagination.TabIndex = 1;
            lblPagination.Text = "Page 1 sur 1";
            lblPagination.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.Transparent;
            btnNext.BorderRadius = 10;
            btnNext.CustomizableEdges = customizableEdges17;
            btnNext.FillColor = Color.FromArgb(99, 102, 241);
            btnNext.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNext.ForeColor = Color.White;
            btnNext.Location = new Point(696, 8);
            btnNext.Name = "btnNext";
            btnNext.ShadowDecoration.BorderRadius = 10;
            btnNext.ShadowDecoration.CustomizableEdges = customizableEdges18;
            btnNext.ShadowDecoration.Depth = 8;
            btnNext.ShadowDecoration.Enabled = true;
            btnNext.Size = new Size(144, 40);
            btnNext.TabIndex = 2;
            btnNext.Text = "Suivant ►";
            btnNext.Click += btnNext_Click;
            // 
            // panelAlertes
            // 
            panelAlertes.BackColor = Color.White;
            panelAlertes.Controls.Add(lblAlertesPeremptionTitle);
            panelAlertes.Controls.Add(listBoxAlertes);
            panelAlertes.Location = new Point(1080, 56);
            panelAlertes.Name = "panelAlertes";
            panelAlertes.Size = new Size(499, 384);
            panelAlertes.TabIndex = 6;
            // 
            // lblAlertesPeremptionTitle
            // 
            lblAlertesPeremptionTitle.BackColor = Color.FromArgb(239, 68, 68);
            lblAlertesPeremptionTitle.Dock = DockStyle.Top;
            lblAlertesPeremptionTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblAlertesPeremptionTitle.ForeColor = Color.White;
            lblAlertesPeremptionTitle.Location = new Point(0, 0);
            lblAlertesPeremptionTitle.Name = "lblAlertesPeremptionTitle";
            lblAlertesPeremptionTitle.Padding = new Padding(12);
            lblAlertesPeremptionTitle.Size = new Size(499, 57);
            lblAlertesPeremptionTitle.TabIndex = 0;
            lblAlertesPeremptionTitle.Text = "⚠️ Alertes de Péremption (30 jours)";
            lblAlertesPeremptionTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // listBoxAlertes
            // 
            listBoxAlertes.BackColor = Color.FromArgb(254, 242, 242);
            listBoxAlertes.BorderStyle = BorderStyle.None;
            listBoxAlertes.Font = new Font("Segoe UI", 9.5F);
            listBoxAlertes.ForeColor = Color.FromArgb(239, 68, 68);
            listBoxAlertes.ItemHeight = 21;
            listBoxAlertes.Location = new Point(12, 60);
            listBoxAlertes.Name = "listBoxAlertes";
            listBoxAlertes.Size = new Size(475, 294);
            listBoxAlertes.TabIndex = 1;
          //  listBoxAlertes.MouseClick += ListBoxAlertes_MouseClick;
            // 
            // panelGraphique
            // 
            panelGraphique.BackColor = Color.White;
            panelGraphique.Controls.Add(lblGraphiqueTitle);
            panelGraphique.Controls.Add(listBoxCategories);
            panelGraphique.Location = new Point(1080, 456);
            panelGraphique.Name = "panelGraphique";
            panelGraphique.Size = new Size(499, 368);
            panelGraphique.TabIndex = 7;
            // 
            // lblGraphiqueTitle
            // 
            lblGraphiqueTitle.BackColor = Color.FromArgb(99, 102, 241);
            lblGraphiqueTitle.Dock = DockStyle.Top;
            lblGraphiqueTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblGraphiqueTitle.ForeColor = Color.White;
            lblGraphiqueTitle.Location = new Point(0, 0);
            lblGraphiqueTitle.Name = "lblGraphiqueTitle";
            lblGraphiqueTitle.Padding = new Padding(12);
            lblGraphiqueTitle.Size = new Size(499, 57);
            lblGraphiqueTitle.TabIndex = 0;
            lblGraphiqueTitle.Text = "📊 Stock Alertes ";
            lblGraphiqueTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // listBoxCategories
            // 
            listBoxCategories.BackColor = Color.FromArgb(248, 249, 250);
            listBoxCategories.BorderStyle = BorderStyle.None;
            listBoxCategories.Font = new Font("Consolas", 10F);
            listBoxCategories.ForeColor = Color.FromArgb(99, 102, 241);
            listBoxCategories.Location = new Point(12, 60);
            listBoxCategories.Name = "listBoxCategories";
            listBoxCategories.Size = new Size(475, 280);
            listBoxCategories.TabIndex = 1;
            // 
            // Accueil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(1539, 840);
            Controls.Add(panelGraphique);
            Controls.Add(panelAlertes);
            Controls.Add(panelPagination);
            Controls.Add(gridview);
            Controls.Add(panelRecherche);
            Controls.Add(panelStats);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Accueil";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "🏥 Gestion de la Pharmacie - Accueil";
            Load += Accueil_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panelStats.ResumeLayout(false);
            cardTotalMedicaments.ResumeLayout(false);
            cardValeurStock.ResumeLayout(false);
            cardAlertes.ResumeLayout(false);
            cardPeremption.ResumeLayout(false);
            panelRecherche.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridview).EndInit();
            panelPagination.ResumeLayout(false);
            panelAlertes.ResumeLayout(false);
            panelGraphique.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem medicamentsToolStripMenuItem;
        private ToolStripMenuItem ajouterMedicamentToolStripMenuItem;
        private ToolStripMenuItem modifierMedicamentToolStripMenuItem;
        private ToolStripMenuItem ajouterUnLotToolStripMenuItem;
        private ToolStripMenuItem clientsToolStripMenuItem;
        private ToolStripMenuItem commandesToolStripMenuItem;

        private Panel panelStats;
        private Guna2Panel cardTotalMedicaments;
        private Label lblTotalMedicaments;
        private Label lblTotalMedicamentsTitle;
        private Guna2Panel cardValeurStock;
        private Label lblValeurStock;
        private Label lblValeurStockTitle;
        private Guna2Panel cardAlertes;
        private Label lblAlertes;
        private Label lblAlertesTitle;
        private Guna2Panel cardPeremption;
        private Label lblPeremption;
        private Label lblPeremptionTitle;

        private Panel panelRecherche;
        private Guna2TextBox txtRecherche;
        private Guna2ComboBox cmbFiltre;
        private Guna2Button btnRefresh;

        private Guna2DataGridView gridview;

        private Panel panelPagination;
        private Guna2Button btnPrevious;
        private Label lblPagination;
        private Guna2Button btnNext;

        private Panel panelAlertes;
        private Label lblAlertesPeremptionTitle;
        private ListBox listBoxAlertes;

        private Panel panelGraphique;
        private Label lblGraphiqueTitle;
        private ListBox listBoxCategories;
        private ToolStripMenuItem archiverMedicamentToolStripMenuItem;
    }
}