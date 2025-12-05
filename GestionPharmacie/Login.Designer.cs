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
            erreurMsg = new Label();
            connecter = new Button();
            title = new Label();
            SuspendLayout();
            // 
            // emailtxt
            // 
            emailtxt.AutoSize = true;
            emailtxt.Font = new Font("Segoe UI", 12F);
            emailtxt.ForeColor = Color.FromArgb(52, 73, 94);
            emailtxt.Location = new Point(186, 186);
            emailtxt.Name = "emailtxt";
            emailtxt.Size = new Size(71, 32);
            emailtxt.TabIndex = 1;
            emailtxt.Text = "Email";
            // 
            // passwordtxt
            // 
            passwordtxt.AutoSize = true;
            passwordtxt.Font = new Font("Segoe UI", 12F);
            passwordtxt.ForeColor = Color.FromArgb(52, 73, 94);
            passwordtxt.Location = new Point(186, 296);
            passwordtxt.Name = "passwordtxt";
            passwordtxt.Size = new Size(158, 32);
            passwordtxt.TabIndex = 3;
            passwordtxt.Text = "Mot de passe";
            // 
            // textEmail
            // 
            textEmail.BorderStyle = BorderStyle.FixedSingle;
            textEmail.Font = new Font("Segoe UI", 12F);
            textEmail.Location = new Point(186, 216);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(320, 39);
            textEmail.TabIndex = 2;
            // 
            // textPassword
            // 
            textPassword.BorderStyle = BorderStyle.FixedSingle;
            textPassword.Font = new Font("Segoe UI", 12F);
            textPassword.Location = new Point(186, 326);
            textPassword.Name = "textPassword";
            textPassword.PasswordChar = '•';
            textPassword.Size = new Size(320, 39);
            textPassword.TabIndex = 4;
            // 
            // erreurMsg
            // 
            erreurMsg.AutoSize = true;
            erreurMsg.Font = new Font("Segoe UI", 10F);
            erreurMsg.ForeColor = Color.Red;
            erreurMsg.Location = new Point(186, 376);
            erreurMsg.Name = "erreurMsg";
            erreurMsg.Size = new Size(0, 28);
            erreurMsg.TabIndex = 5;
            // 
            // connecter
            // 
            connecter.BackColor = Color.FromArgb(22, 160, 133);
            connecter.Cursor = Cursors.Hand;
            connecter.FlatAppearance.BorderSize = 0;
            connecter.FlatStyle = FlatStyle.Flat;
            connecter.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            connecter.ForeColor = Color.White;
            connecter.Location = new Point(186, 458);
            connecter.Name = "connecter";
            connecter.Size = new Size(320, 45);
            connecter.TabIndex = 6;
            connecter.Text = "Se connecter";
            connecter.UseVisualStyleBackColor = false;
            connecter.Click += connecter_Click;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            title.ForeColor = Color.FromArgb(22, 160, 133);
            title.Location = new Point(95, 62);
            title.Name = "title";
            title.Size = new Size(506, 54);
            title.TabIndex = 0;
            title.Text = "💊PhaSmart – Connexion";
            // 
            // Login
            // 
            BackColor = Color.White;
            ClientSize = new Size(750, 750);
            Controls.Add(title);
            Controls.Add(emailtxt);
            Controls.Add(textEmail);
            Controls.Add(passwordtxt);
            Controls.Add(textPassword);
            Controls.Add(erreurMsg);
            Controls.Add(connecter);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label emailtxt;
        private Label passwordtxt;
        private TextBox textEmail;
        private TextBox textPassword;
        private Label erreurMsg;
        private Button connecter;
        private Label title;
    }
}
