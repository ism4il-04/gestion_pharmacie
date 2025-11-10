using Guna.UI2.WinForms;

namespace GestionPharmacie
{
    partial class Accueil
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            menuStrip1 = new MenuStrip();
            medicamentsToolStripMenuItem = new ToolStripMenuItem();
            clientsToolStripMenuItem = new ToolStripMenuItem();
            commandesToolStripMenuItem = new ToolStripMenuItem();
            gridview = new Guna2DataGridView();
            label1 = new Label();
            btnAjouter = new Guna2Button();
            btnModifier = new Guna2Button();
            btnSupprimer = new Guna2Button();
            ajouterMedicamentToolStripMenuItem = new ToolStripMenuItem();
            modifierMedicamentToolStripMenuItem = new ToolStripMenuItem();
            ajouterUnLotToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridview).BeginInit();
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
            menuStrip1.Size = new Size(1200, 33);
            menuStrip1.TabIndex = 5;
            // 
            // medicamentsToolStripMenuItem
            // 
            medicamentsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ajouterMedicamentToolStripMenuItem, modifierMedicamentToolStripMenuItem, ajouterUnLotToolStripMenuItem });
            medicamentsToolStripMenuItem.Name = "medicamentsToolStripMenuItem";
            medicamentsToolStripMenuItem.Size = new Size(144, 29);
            medicamentsToolStripMenuItem.Text = "Medicaments";
            // 
            // clientsToolStripMenuItem
            // 
            clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            clientsToolStripMenuItem.Size = new Size(85, 29);
            clientsToolStripMenuItem.Text = "Clients";
            // 
            // commandesToolStripMenuItem
            // 
            commandesToolStripMenuItem.Name = "commandesToolStripMenuItem";
            commandesToolStripMenuItem.Size = new Size(136, 29);
            commandesToolStripMenuItem.Text = "Commandes";
            // 
            // gridview
            // 
            dataGridViewCellStyle4.BackColor = Color.FromArgb(240, 248, 255);
            gridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(0, 122, 204);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            gridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            gridview.ColumnHeadersHeight = 40;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(0, 122, 204);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            gridview.DefaultCellStyle = dataGridViewCellStyle6;
            gridview.GridColor = Color.FromArgb(231, 229, 255);
            gridview.Location = new Point(50, 100);
            gridview.Name = "gridview";
            gridview.RowHeadersVisible = false;
            gridview.RowHeadersWidth = 51;
            gridview.Size = new Size(1100, 400);
            gridview.TabIndex = 0;
            gridview.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(240, 248, 255);
            gridview.ThemeStyle.AlternatingRowsStyle.Font = null;
            gridview.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            gridview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            gridview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            gridview.ThemeStyle.BackColor = Color.White;
            gridview.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            gridview.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(0, 122, 204);
            gridview.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            gridview.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            gridview.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            gridview.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            gridview.ThemeStyle.HeaderStyle.Height = 40;
            gridview.ThemeStyle.ReadOnly = false;
            gridview.ThemeStyle.RowsStyle.BackColor = Color.White;
            gridview.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridview.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            gridview.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            gridview.ThemeStyle.RowsStyle.Height = 29;
            gridview.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(0, 122, 204);
            gridview.ThemeStyle.RowsStyle.SelectionForeColor = Color.White;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(0, 122, 204);
            label1.Location = new Point(450, 50);
            label1.Name = "label1";
            label1.Size = new Size(352, 41);
            label1.TabIndex = 1;
            label1.Text = "Liste des Médicaments";
            // 
            // btnAjouter
            // 
            btnAjouter.CustomizableEdges = customizableEdges7;
            btnAjouter.FillColor = Color.SeaGreen;
            btnAjouter.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAjouter.ForeColor = Color.White;
            btnAjouter.Location = new Point(300, 530);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnAjouter.Size = new Size(120, 40);
            btnAjouter.TabIndex = 2;
            btnAjouter.Text = "Ajouter";
            btnAjouter.Click += btnAjouter_Click;
            // 
            // btnModifier
            // 
            btnModifier.CustomizableEdges = customizableEdges9;
            btnModifier.FillColor = Color.Goldenrod;
            btnModifier.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnModifier.ForeColor = Color.White;
            btnModifier.Location = new Point(500, 530);
            btnModifier.Name = "btnModifier";
            btnModifier.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnModifier.Size = new Size(120, 40);
            btnModifier.TabIndex = 3;
            btnModifier.Text = "Modifier";
            btnModifier.Click += btnModifier_Click;
            // 
            // btnSupprimer
            // 
            btnSupprimer.CustomizableEdges = customizableEdges11;
            btnSupprimer.FillColor = Color.Firebrick;
            btnSupprimer.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSupprimer.ForeColor = Color.White;
            btnSupprimer.Location = new Point(700, 530);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnSupprimer.Size = new Size(120, 40);
            btnSupprimer.TabIndex = 4;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // ajouterMedicamentToolStripMenuItem
            // 
            ajouterMedicamentToolStripMenuItem.Name = "ajouterMedicamentToolStripMenuItem";
            ajouterMedicamentToolStripMenuItem.Size = new Size(280, 30);
            ajouterMedicamentToolStripMenuItem.Text = "Ajouter Medicament";
            // 
            // modifierMedicamentToolStripMenuItem
            // 
            modifierMedicamentToolStripMenuItem.Name = "modifierMedicamentToolStripMenuItem";
            modifierMedicamentToolStripMenuItem.Size = new Size(290, 30);
            modifierMedicamentToolStripMenuItem.Text = "Modifier Medicament";
            // 
            // ajouterUnLotToolStripMenuItem
            // 
            ajouterUnLotToolStripMenuItem.Name = "ajouterUnLotToolStripMenuItem";
            ajouterUnLotToolStripMenuItem.Size = new Size(290, 30);
            ajouterUnLotToolStripMenuItem.Text = "Ajouter un lot";
            // 
            // Accueil
            // 
            BackColor = Color.White;
            ClientSize = new Size(1200, 620);
            Controls.Add(gridview);
            Controls.Add(label1);
            Controls.Add(btnAjouter);
            Controls.Add(btnModifier);
            Controls.Add(btnSupprimer);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Accueil";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Accueil - Gestion de la Pharmacie";
            Load += Accueil_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip1;
        private Button button1;
        private Guna2Button btnSupprimer;
        private Guna2Button btnModifier;
        private Guna2Button btnAjouter;
        private Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView gridview;
        private ToolStripMenuItem medicamentsToolStripMenuItem;
        private ToolStripMenuItem clientsToolStripMenuItem;
        private ToolStripMenuItem commandesToolStripMenuItem;
        private ToolStripMenuItem ajouterMedicamentToolStripMenuItem;
        private ToolStripMenuItem modifierMedicamentToolStripMenuItem;
        private ToolStripMenuItem ajouterUnLotToolStripMenuItem;
    }
}