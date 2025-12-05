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

                string query = "SELECT * FROM utilisateur where email ='" + textEmail.Text + "' and mot_de_passe='" + textPassword.Text + "'";
                SqlCommand command = new SqlCommand(query, sqlConnection);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Accueil acceuil = new Accueil();
                    acceuil.Show();
                    this.Hide();
                }
            }
        }
    }
}
