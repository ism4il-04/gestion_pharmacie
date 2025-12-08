namespace GestionPharmacie
{
    partial class Landing
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            bienvenue = new Label();
            bienvenue2 = new Label();
            login = new Button();
            decorativePanel = new Panel();
            iconLabel = new Label();
            subtitleLabel = new Label();
            SuspendLayout();
            // 
            // bienvenue
            // 
            bienvenue.AutoSize = true;
            bienvenue.BackColor = Color.Transparent;
            bienvenue.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            bienvenue.ForeColor = Color.FromArgb(20, 70, 100);
            bienvenue.Location = new Point(230, 240);
            bienvenue.Name = "bienvenue";
            bienvenue.Size = new Size(868, 96);
            bienvenue.TabIndex = 2;
            bienvenue.Text = "Bienvenue sur PhaSmart";
            bienvenue.TextAlign = ContentAlignment.MiddleCenter;
            bienvenue.Click += bienvenue_Click;
            // 
            // bienvenue2
            // 
            bienvenue2.BackColor = Color.Transparent;
            bienvenue2.Font = new Font("Segoe UI", 14F);
            bienvenue2.ForeColor = Color.FromArgb(80, 100, 120);
            bienvenue2.Location = new Point(248, 375);
            bienvenue2.Name = "bienvenue2";
            bienvenue2.Size = new Size(850, 80);
            bienvenue2.TabIndex = 1;
            bienvenue2.Text = "Optimisez la gestion de vos médicaments, stocks et prescriptions\navec une interface intuitive et performante";
            bienvenue2.TextAlign = ContentAlignment.MiddleCenter;
            bienvenue2.Click += bienvenue2_Click;
            // 
            // login
            // 
            login.BackColor = Color.FromArgb(30, 90, 130);
            login.Cursor = Cursors.Hand;
            login.FlatAppearance.BorderSize = 0;
            login.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 70, 100);
            login.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 110, 160);
            login.FlatStyle = FlatStyle.Flat;
            login.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            login.ForeColor = Color.White;
            login.Location = new Point(432, 499);
            login.Name = "login";
            login.Size = new Size(483, 59);
            login.TabIndex = 0;
            login.Text = "🔐 Accéder à votre espace";
            login.UseVisualStyleBackColor = false;
            login.Click += login_Click;
            // 
            // decorativePanel
            // 
            decorativePanel.BackColor = Color.FromArgb(30, 90, 130);
            decorativePanel.Location = new Point(0, 0);
            decorativePanel.Name = "decorativePanel";
            decorativePanel.Size = new Size(1050, 8);
            decorativePanel.TabIndex = 5;
            // 
            // iconLabel
            // 
            iconLabel.AutoSize = true;
            iconLabel.BackColor = Color.Transparent;
            iconLabel.Font = new Font("Segoe UI", 72F);
            iconLabel.ForeColor = Color.FromArgb(80, 160, 200);
            iconLabel.Location = new Point(504, 72);
            iconLabel.Name = "iconLabel";
            iconLabel.Size = new Size(278, 191);
            iconLabel.TabIndex = 6;
            iconLabel.Text = "💊";
            iconLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // subtitleLabel
            // 
            subtitleLabel.BackColor = Color.Transparent;
            subtitleLabel.Font = new Font("Segoe UI", 11F);
            subtitleLabel.ForeColor = Color.FromArgb(100, 120, 140);
            subtitleLabel.Location = new Point(266, 336);
            subtitleLabel.Name = "subtitleLabel";
            subtitleLabel.Size = new Size(750, 30);
            subtitleLabel.TabIndex = 7;
            subtitleLabel.Text = "Gestion intelligente et moderne de votre pharmacie";
            subtitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Landing
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 248, 252);
            ClientSize = new Size(1254, 850);
            Controls.Add(login);
            Controls.Add(subtitleLabel);
            Controls.Add(iconLabel);
            Controls.Add(bienvenue2);
            Controls.Add(bienvenue);
            Controls.Add(decorativePanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Landing";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PhaSmart - Gestion de Pharmacie";
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private Label bienvenue;
        private Label bienvenue2;
        private Button login;
        private Panel decorativePanel;
        private Label iconLabel;
        private Label subtitleLabel;
    }
}