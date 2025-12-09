namespace GestionPharmacie
{
    partial class ArchiverMedicament
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new Label();
            comboStatut = new Guna.UI2.WinForms.Guna2ComboBox();
            label2 = new Label();
            btnArchiver = new Guna.UI2.WinForms.Guna2Button();
            btnDesarchiver = new Guna.UI2.WinForms.Guna2Button();
            btnFermer = new Guna.UI2.WinForms.Guna2Button();
            guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(30, 39, 73);
            label1.Location = new Point(30, 30);
            label1.Name = "label1";
            label1.Size = new Size(440, 41);
            label1.TabIndex = 0;
            label1.Text = "💊 Archiver les Médicaments";
            // 
            // comboStatut
            // 
            comboStatut.BackColor = Color.Transparent;
            comboStatut.BorderRadius = 10;
            comboStatut.CustomizableEdges = customizableEdges1;
            comboStatut.DrawMode = DrawMode.OwnerDrawFixed;
            comboStatut.DropDownStyle = ComboBoxStyle.DropDownList;
            comboStatut.FocusedColor = Color.FromArgb(99, 102, 241);
            comboStatut.FocusedState.BorderColor = Color.FromArgb(99, 102, 241);
            comboStatut.Font = new Font("Segoe UI", 10F);
            comboStatut.ForeColor = Color.FromArgb(68, 88, 112);
            comboStatut.ItemHeight = 30;
            comboStatut.Items.AddRange(new object[] { "Tous", "Actifs", "Archivés" });
            comboStatut.Location = new Point(200, 100);
            comboStatut.Name = "comboStatut";
            comboStatut.ShadowDecoration.CustomizableEdges = customizableEdges2;
            comboStatut.Size = new Size(250, 36);
            comboStatut.StartIndex = 0;
            comboStatut.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(30, 39, 73);
            label2.Location = new Point(30, 108);
            label2.Name = "label2";
            label2.Size = new Size(150, 25);
            label2.TabIndex = 2;
            label2.Text = "Filtrer par statut:";
            // 
            // btnArchiver
            // 
            btnArchiver.BorderRadius = 10;
            btnArchiver.CustomizableEdges = customizableEdges3;
            btnArchiver.FillColor = Color.FromArgb(239, 68, 68);
            btnArchiver.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnArchiver.ForeColor = Color.White;
            btnArchiver.Location = new Point(30, 560);
            btnArchiver.Name = "btnArchiver";
            btnArchiver.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnArchiver.Size = new Size(250, 50);
            btnArchiver.TabIndex = 3;
            btnArchiver.Text = "📥 Archiver";
            // 
            // btnDesarchiver
            // 
            btnDesarchiver.BorderRadius = 10;
            btnDesarchiver.CustomizableEdges = customizableEdges5;
            btnDesarchiver.FillColor = Color.FromArgb(16, 185, 129);
            btnDesarchiver.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnDesarchiver.ForeColor = Color.White;
            btnDesarchiver.Location = new Point(300, 560);
            btnDesarchiver.Name = "btnDesarchiver";
            btnDesarchiver.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnDesarchiver.Size = new Size(250, 50);
            btnDesarchiver.TabIndex = 4;
            btnDesarchiver.Text = "📤 Désarchiver";
            // 
            // btnFermer
            // 
            btnFermer.BorderRadius = 10;
            btnFermer.CustomizableEdges = customizableEdges7;
            btnFermer.FillColor = Color.FromArgb(107, 114, 128);
            btnFermer.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnFermer.ForeColor = Color.White;
            btnFermer.Location = new Point(850, 560);
            btnFermer.Name = "btnFermer";
            btnFermer.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnFermer.Size = new Size(200, 50);
            btnFermer.TabIndex = 5;
            btnFermer.Text = "✖ Fermer";
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
            guna2DataGridView1.Location = new Point(30, 160);
            guna2DataGridView1.Name = "guna2DataGridView1";
            guna2DataGridView1.ReadOnly = true;
            guna2DataGridView1.RowHeadersVisible = false;
            guna2DataGridView1.RowHeadersWidth = 51;
            guna2DataGridView1.RowTemplate.Height = 40;
            guna2DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            guna2DataGridView1.Size = new Size(1020, 380);
            guna2DataGridView1.TabIndex = 6;
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
            // 
            // ArchiverMedicament
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(1080, 640);
            Controls.Add(guna2DataGridView1);
            Controls.Add(btnFermer);
            Controls.Add(btnDesarchiver);
            Controls.Add(btnArchiver);
            Controls.Add(label2);
            Controls.Add(comboStatut);
            Controls.Add(label1);
            Name = "ArchiverMedicament";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Archiver Médicaments";
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox comboStatut;
        private Label label2;
        private Guna.UI2.WinForms.Guna2Button btnArchiver;
        private Guna.UI2.WinForms.Guna2Button btnDesarchiver;
        private Guna.UI2.WinForms.Guna2Button btnFermer;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
    }
}
