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
    public partial class ModifierClient : Form
    {
        public ModifierClient()
        {
            InitializeComponent();
        }

        private void btnReinitialiser_Click(object sender, EventArgs e)
        {
            txtNom.Clear();
            txtTele.Clear();
            txtAdresse.Clear();
            txtEmail.Clear();
            btnReinitialiser.Enabled = false;
            btnModifier.Enabled = false;
            txtNom.Enabled = true;

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (txtNom.Text != "")
            {
                Client client = new Client();
                client.NomComplet = txtNom.Text;
                client.Telephone = txtTele.Text;
                client.Adresse = txtAdresse.Text;
                client.Email = txtEmail.Text;
                if (client.Modifier())
                {
                    MessageBox.Show("Client modifié avec succès !");
                }
                else
                {
                    MessageBox.Show("Échec de la modification du client.");
                }
                btnReinitialiser_Click(sender, e);

            }

        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            AccueilClient f = new AccueilClient();
            this.Hide();
            f.Show();

        }

        private void btnNom_Click(object sender, EventArgs e)
        {
            if (txtNom.Text != "")
            {
                Client client = new Client();
                if (client.ChargerParNom(txtNom.Text))
                {
                    txtNom.Text = client.NomComplet;
                    txtTele.Text = client.Telephone;
                    txtAdresse.Text = client.Adresse;
                    txtEmail.Text = client.Email;
                    btnReinitialiser.Enabled = true;
                    btnModifier.Enabled = true;
                    txtNom.Enabled = false;
                }
            }

        }

        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AccueilClient f = new AccueilClient();
            f.Show();
        }
    }
}
