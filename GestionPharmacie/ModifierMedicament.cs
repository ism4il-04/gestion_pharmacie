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
    public partial class ModifierMedicament : Form
    {
        public ModifierMedicament()
        {
            InitializeComponent();
        }

        private void btnNom_Click(object sender, EventArgs e)
        {
            if (txtNom.Text != "")
            {
                Medicament medicament = new Medicament();
                if (medicament.ChargerParNom(txtNom.Text))
                {
                    txtNom.Text = medicament.Nom;
                    txtRef.Text = medicament.Reference;
                    txtDescription.Text = medicament.Description;
                    txtDosage.Text = medicament.Dosage;
                    txtCategorie.Text = medicament.Categorie;
                    txtAchat.Text = medicament.PrixAchat.ToString();
                    txtVente.Text = medicament.PrixVente.ToString();
                    btnReinitialiser.Enabled = true;
                    btnModifier.Enabled = true;
                }
            }

        }

        private void btnReference_Click(object sender, EventArgs e)
        {
            if (txtRef.Text != "")
            {
                Medicament medicament = new Medicament();
                if (medicament.ChargerParReference(txtRef.Text))
                {
                    txtNom.Text = medicament.Nom;
                    txtRef.Text = medicament.Reference;
                    txtDescription.Text = medicament.Description;
                    txtDosage.Text = medicament.Dosage;
                    txtCategorie.Text = medicament.Categorie;
                    txtAchat.Text = medicament.PrixAchat.ToString();
                    txtVente.Text = medicament.PrixVente.ToString();
                    btnReinitialiser.Enabled = true;
                    btnModifier.Enabled = true;
                }
            }
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
            btnReinitialiser.Enabled = false;
            btnModifier.Enabled = false;
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            Accueil f = new Accueil();
            this.Hide();
            f.Show();
        }

        private void medicamentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Accueil f = new Accueil();
            this.Hide();
            f.Show();
        }

        private void btnModifier_Click(object sender, EventArgs e)
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
            medicament.Id = medicament.GetIdByRef();
            medicament.Modifier();
            txtNom.Text = "";
            txtRef.Text = "";
            txtDescription.Text = "";
            txtDosage.Text = "";
            txtCategorie.Text = "";
            txtAchat.Text = "";
            txtVente.Text = "";
            btnReinitialiser.Enabled = false;
            btnModifier.Enabled = false;
            MessageBox.Show("Médicament modifié avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
