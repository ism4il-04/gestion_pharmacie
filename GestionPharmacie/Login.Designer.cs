namespace GestionPharmacie
{
    partial class Login
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
            emailtxt = new Label();
            passwordtxt = new Label();
            textEmail = new TextBox();
            textPassword = new TextBox();
            connecter = new Button();
            title = new Label();
            subtitle = new Label();
            loginPanel = new Panel();
            decorativePanel = new Panel();
            iconPanel = new Panel();
            iconLabel = new Label();
            emailIcon = new Label();
            passwordIcon = new Label();
            loginPanel.SuspendLayout();
            SuspendLayout();
            // 
            // emailtxt
            // 
            emailtxt.AutoSize = true;
            emailtxt.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            emailtxt.ForeColor = Color.FromArgb(50, 70, 90);
            emailtxt.Location = new Point(60, 32);
            emailtxt.Name = "emailtxt";
            emailtxt.Size = new Size(151, 30);
            emailtxt.TabIndex = 1;
            emailtxt.Text = "Adresse email";
            // 
            // passwordtxt
            // 
            passwordtxt.AutoSize = true;
            passwordtxt.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            passwordtxt.ForeColor = Color.FromArgb(50, 70, 90);
            passwordtxt.Location = new Point(205, 495);
            passwordtxt.Name = "passwordtxt";
            passwordtxt.Size = new Size(145, 30);
            passwordtxt.TabIndex = 3;
            passwordtxt.Text = "Mot de passe";
            // 
            // textEmail
            // 
            textEmail.BackColor = Color.FromArgb(248, 250, 252);
            textEmail.BorderStyle = BorderStyle.FixedSingle;
            textEmail.Font = new Font("Segoe UI", 13F);
            textEmail.ForeColor = Color.FromArgb(40, 60, 80);
            textEmail.Location = new Point(210, 425);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(370, 42);
            textEmail.TabIndex = 2;
            // 
            // textPassword
            // 
            textPassword.BackColor = Color.FromArgb(248, 250, 252);
            textPassword.BorderStyle = BorderStyle.FixedSingle;
            textPassword.Font = new Font("Segoe UI", 13F);
            textPassword.ForeColor = Color.FromArgb(40, 60, 80);
            textPassword.Location = new Point(210, 530);
            textPassword.Name = "textPassword";
            textPassword.PasswordChar = '●';
            textPassword.Size = new Size(370, 42);
            textPassword.TabIndex = 4;
            // 
            // connecter
            // 
            connecter.BackColor = Color.FromArgb(30, 90, 130);
            connecter.Cursor = Cursors.Hand;
            connecter.FlatAppearance.BorderSize = 0;
            connecter.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 70, 100);
            connecter.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 110, 160);
            connecter.FlatStyle = FlatStyle.Flat;
            connecter.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            connecter.ForeColor = Color.White;
            connecter.Location = new Point(205, 620);
            connecter.Name = "connecter";
            connecter.Size = new Size(380, 55);
            connecter.TabIndex = 6;
            connecter.Text = "🔐 Se connecter";
            connecter.UseVisualStyleBackColor = false;
            connecter.Click += connecter_Click;
            // 
            // title
            // 
            title.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            title.ForeColor = Color.FromArgb(30, 90, 130);
            title.Location = new Point(100, 250);
            title.Name = "title";
            title.Size = new Size(550, 60);
            title.TabIndex = 0;
            title.Text = "Connexion à PhaSmart";
            title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // subtitle
            // 
            subtitle.Font = new Font("Segoe UI", 10F);
            subtitle.ForeColor = Color.FromArgb(120, 140, 160);
            subtitle.Location = new Point(100, 310);
            subtitle.Name = "subtitle";
            subtitle.Size = new Size(550, 30);
            subtitle.TabIndex = 13;
            subtitle.Text = "Accédez à votre espace de gestion";
            subtitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // loginPanel
            // 
            loginPanel.BackColor = Color.White;
            loginPanel.Controls.Add(emailtxt);
            loginPanel.Location = new Point(150, 360);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(450, 320);
            loginPanel.TabIndex = 14;
            // 
            // decorativePanel
            // 
            decorativePanel.BackColor = Color.FromArgb(30, 90, 130);
            decorativePanel.Dock = DockStyle.Top;
            decorativePanel.Location = new Point(0, 0);
            decorativePanel.Name = "decorativePanel";
            decorativePanel.Size = new Size(750, 6);
            decorativePanel.TabIndex = 10;
            // 
            // iconPanel
            // 
            iconPanel.BackColor = Color.FromArgb(240, 245, 250);
            iconPanel.Location = new Point(280, 40);
            iconPanel.Name = "iconPanel";
            iconPanel.Size = new Size(190, 190);
            iconPanel.TabIndex = 11;
            // 
            // iconLabel
            // 
            iconLabel.BackColor = Color.FromArgb(240, 245, 250);
            iconLabel.Font = new Font("Segoe UI", 72F);
            iconLabel.ForeColor = Color.FromArgb(30, 90, 130);
            iconLabel.Location = new Point(280, 40);
            iconLabel.Name = "iconLabel";
            iconLabel.Size = new Size(190, 190);
            iconLabel.TabIndex = 12;
            iconLabel.Text = "⚕ ";
            iconLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // emailIcon
            // 
            emailIcon.AutoSize = true;
            emailIcon.Font = new Font("Segoe UI", 14F);
            emailIcon.ForeColor = Color.FromArgb(30, 90, 130);
            emailIcon.Location = new Point(160, 385);
            emailIcon.Name = "emailIcon";
            emailIcon.Size = new Size(55, 38);
            emailIcon.TabIndex = 15;
            emailIcon.Text = "📧";
            // 
            // passwordIcon
            // 
            passwordIcon.AutoSize = true;
            passwordIcon.Font = new Font("Segoe UI", 14F);
            passwordIcon.ForeColor = Color.FromArgb(30, 90, 130);
            passwordIcon.Location = new Point(160, 490);
            passwordIcon.Name = "passwordIcon";
            passwordIcon.Size = new Size(50, 38);
            passwordIcon.TabIndex = 17;
            passwordIcon.Text = "🔒";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 248, 252);
            ClientSize = new Size(750, 750);
            Controls.Add(passwordIcon);
            Controls.Add(emailIcon);
            Controls.Add(subtitle);
            Controls.Add(iconLabel);
            Controls.Add(iconPanel);
            Controls.Add(title);
            Controls.Add(textEmail);
            Controls.Add(passwordtxt);
            Controls.Add(textPassword);
            Controls.Add(connecter);
            Controls.Add(loginPanel);
            Controls.Add(decorativePanel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PhaSmart - Connexion";
            loginPanel.ResumeLayout(false);
            loginPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label emailtxt;
        private Label passwordtxt;
        private TextBox textEmail;
        private TextBox textPassword;
        private Button connecter;
        private Label title;
        private Label subtitle;
        private Panel loginPanel;
        private Panel decorativePanel;
        private Panel iconPanel;
        private Label iconLabel;
        private Label emailIcon;
        private Label passwordIcon;
    }
}