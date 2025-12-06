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
            SuspendLayout();
            // 
            // bienvenue
            // 
            bienvenue.AutoSize = true;
            bienvenue.BackColor = Color.Transparent;
            bienvenue.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            bienvenue.ForeColor = Color.White;
            bienvenue.Location = new Point(135, 142);
            bienvenue.Name = "bienvenue";
            bienvenue.Size = new Size(803, 81);
            bienvenue.TabIndex = 2;
            bienvenue.Text = "Bienvenue sur PhaSmart💊";
            bienvenue.Click += bienvenue_Click;
            // 
            // bienvenue2
            // 
            bienvenue2.AutoSize = true;
            bienvenue2.BackColor = Color.Transparent;
            bienvenue2.Font = new Font("Segoe UI", 15F);
            bienvenue2.ForeColor = Color.WhiteSmoke;
            bienvenue2.Location = new Point(93, 223);
            bienvenue2.Name = "bienvenue2";
            bienvenue2.Size = new Size(877, 41);
            bienvenue2.TabIndex = 1;
            bienvenue2.Text = "Le meilleur moyen de gérer vos médicaments et votre pharmacie";
            bienvenue2.Click += bienvenue2_Click;
            // 
            // login
            // 
            login.BackColor = Color.White;
            login.Cursor = Cursors.Hand;
            login.FlatAppearance.BorderSize = 0;
            login.FlatStyle = FlatStyle.Flat;
            login.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            login.ForeColor = Color.FromArgb(20, 70, 100);
            login.Location = new Point(357, 358);
            login.Name = "login";
            login.Size = new Size(320, 55);
            login.TabIndex = 0;
            login.Text = "Accéder à votre espace";
            login.UseVisualStyleBackColor = false;
            login.Click += login_Click;
            // 
            // Landing
            // 
            ClientSize = new Size(1050, 850);
            Controls.Add(login);
            Controls.Add(bienvenue2);
            Controls.Add(bienvenue);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Landing";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ParmaSmart";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label bienvenue;
        private Label bienvenue2;
        private Button login;
    }
}
