using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GestionPharmacie
{
    public partial class Signup : Form
    {
        private SqlConnection sqlConnection;

        public Signup()
        {
            InitializeComponent();
            sqlConnection = Connexion.connecter();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            // Validation des champs
            if (string.IsNullOrWhiteSpace(txtNom.Text) ||
                string.IsNullOrWhiteSpace(txtPrenom.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs obligatoires.", 
                    "Champs manquants", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validation de l'email
            if (!IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Veuillez entrer une adresse email valide.", 
                    "Email invalide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validation de la correspondance des mots de passe
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Les mots de passe ne correspondent pas.", 
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validation de la force du mot de passe
            if (txtPassword.Text.Length < 6)
            {
                MessageBox.Show("Le mot de passe doit contenir au moins 6 caractères.", 
                    "Mot de passe faible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Vérifier si l'email existe déjà
            if (EmailExists(txtEmail.Text))
            {
                MessageBox.Show("Cet email est déjà utilisé. Veuillez en choisir un autre.", 
                    "Email existant", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Créer le nouvel utilisateur
            if (CreateUser())
            {
                MessageBox.Show("Compte créé avec succès ! Vous pouvez maintenant vous connecter.", 
                    "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                // Retourner à la page de connexion
                Login loginForm = new Login();
                loginForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Erreur lors de la création du compte. Veuillez réessayer.", 
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var regex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
                return regex.IsMatch(email);
            }
            catch
            {
                return false;
            }
        }

        private bool EmailExists(string email)
        {
            try
            {
                sqlConnection.Open();
                string query = "SELECT COUNT(*) FROM utilisateur WHERE email = @email";
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                cmd.Parameters.AddWithValue("@email", email);
                
                int count = (int)cmd.ExecuteScalar();
                sqlConnection.Close();
                
                return count > 0;
            }
            catch (Exception ex)
            {
                if (sqlConnection.State == ConnectionState.Open)
                    sqlConnection.Close();
                
                MessageBox.Show("Erreur lors de la vérification: " + ex.Message);
                return true; // Par sécurité, on empêche la création
            }
        }

        private bool CreateUser()
        {
            try
            {
                sqlConnection.Open();
                string query = @"INSERT INTO utilisateur (nom, prenom, email, mot_de_passe, telephone, adresse, date_creation) 
                                VALUES (@nom, @prenom, @email, @password, @telephone, @adresse, @dateCreation)";
                
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                cmd.Parameters.AddWithValue("@nom", txtNom.Text.Trim());
                cmd.Parameters.AddWithValue("@prenom", txtPrenom.Text.Trim());
                cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim().ToLower());
                cmd.Parameters.AddWithValue("@password", txtPassword.Text); // TODO: Hash password in production
                cmd.Parameters.AddWithValue("@telephone", string.IsNullOrWhiteSpace(txtTelephone.Text) ? (object)DBNull.Value : txtTelephone.Text.Trim());
                cmd.Parameters.AddWithValue("@adresse", string.IsNullOrWhiteSpace(txtAdresse.Text) ? (object)DBNull.Value : txtAdresse.Text.Trim());
                cmd.Parameters.AddWithValue("@dateCreation", DateTime.Now);
                
                int result = cmd.ExecuteNonQuery();
                sqlConnection.Close();
                
                return result > 0;
            }
            catch (Exception ex)
            {
                if (sqlConnection.State == ConnectionState.Open)
                    sqlConnection.Close();
                
                MessageBox.Show("Erreur lors de la création: " + ex.Message);
                return false;
            }
        }

        private void btnRetourLogin_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Close();
        }

        private void btnReinitialiser_Click(object sender, EventArgs e)
        {
            txtNom.Clear();
            txtPrenom.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            txtTelephone.Clear();
            txtAdresse.Clear();
        }
    }
}
