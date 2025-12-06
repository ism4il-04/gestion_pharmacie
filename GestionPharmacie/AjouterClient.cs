using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionPharmacie
{
    public partial class AjouterClient : Form
    {
        public AjouterClient()
        {
            InitializeComponent();
        }

        private void lblTotalMedicamentsTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private void btnReinitialiser_Click(object sender, EventArgs e)
        {
            txtNom.Clear();
            txtTele.Clear();
            txtAdresse.Clear();
            txtEmail.Clear();
        }
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (txtNom.Text == "" || txtTele.Text == "" || txtEmail.Text == "" || txtAdresse.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs obligatoires.", "Champs manquants", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Client client = new Client
                {
                    NomComplet = txtNom.Text,
                    Telephone = txtTele.Text,
                    Email = txtEmail.Text,
                    Adresse = txtAdresse.Text
                };
                bool isAdded = client.Ajouter();
                if (isAdded)
                {
                    MessageBox.Show("Client ajouté avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Optionally, clear the form fields after successful addition
                    txtNom.Clear();
                    txtTele.Clear();
                    txtAdresse.Clear();
                    txtEmail.Clear();
                    this.DialogResult = DialogResult.OK;
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Erreur lors de l'ajout du client.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void medicamentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Accueil f = new Accueil();
            this.Hide();
            f.Show();
        }

        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccueilClient f = new AccueilClient();
            f.Show();
            this.Hide();
        }
    }
}
