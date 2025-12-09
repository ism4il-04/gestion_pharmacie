using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionPharmacie
{

    public partial class Login : Form
    {
        SqlConnection sqlConnection;

        public Login()
        {
            sqlConnection = Connexion.connecter();
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void connecter_Click(object sender, EventArgs e)
        {

            if (textEmail.Text == "" || textPassword.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs obligatoires.", "Champs manquants", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                sqlConnection.Open();
                Console.WriteLine("Connection successful!");

                string query = "SELECT id, nom, prenom, email FROM utilisateur WHERE email ='" + textEmail.Text + "' AND mot_de_passe='" + textPassword.Text + "'";
                SqlCommand command = new SqlCommand(query, sqlConnection);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // Récupérer les informations de l'utilisateur
                    int userId = reader.GetInt32(0);
                    string nom = reader.GetString(1);
                    string prenom = reader.IsDBNull(2) ? "" : reader.GetString(2);
                    string email = reader.GetString(3);
                    
                    // Initialiser la session utilisateur
                    UserSession.Login(userId, email, $"{nom} {prenom}".Trim());
                    
                    reader.Close();
                    sqlConnection.Close();
                    
                    Accueil acceuil = new Accueil();
                    acceuil.Show();
                    this.Hide();
                }
                else
                {
                    reader.Close();
                    sqlConnection.Close();
                    MessageBox.Show("Email ou mot de passe incorrect.", "Erreur de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void linkSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Signup signupForm = new Signup();
            signupForm.Show();
            this.Hide();
        }
    }
}
