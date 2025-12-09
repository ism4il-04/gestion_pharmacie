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
    public partial class AjouterMedicament : Form
    {
        public AjouterMedicament()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (txtNom.Text == "" || txtRef.Text == "" || txtAchat.Text == "" || txtVente.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs obligatoires.", "Champs manquants", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Medicament medicament = new Medicament
                {
                    Nom = txtNom.Text,
                    Reference = txtRef.Text,
                    Description = txtDescription.Text,
                    Dosage = txtDosage.Text,
                    Categorie = txtCategorie.Text,
                    PrixAchat = decimal.Parse(txtAchat.Text),
                    PrixVente = decimal.Parse(txtVente.Text)
                };
                bool isAdded = medicament.Ajouter();
                if (isAdded)
                {
                    MessageBox.Show("Médicament ajouté avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Optionally, clear the form fields after successful addition
                    txtNom.Clear();
                    txtRef.Clear();
                    txtDescription.Clear();
                    txtDosage.Clear();
                    txtCategorie.Clear();
                    txtAchat.Clear();
                    txtVente.Clear();
                    this.DialogResult = DialogResult.OK;
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Erreur lors de l'ajout du médicament.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void medicamentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Accueil f = new Accueil();
            f.Show();
            this.Hide();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnReinitialiser_Click(object sender, EventArgs e)
        {
            txtNom.Text = "";
            txtRef.Text = "";
            txtDescription.Text = "";
            txtDosage.Text = "";
            txtCategorie.Text = "";
            txtAchat.Text = "";
            txtVente.Text = "";

        }
    }
}
