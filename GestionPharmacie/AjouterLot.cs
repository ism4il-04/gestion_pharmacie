using Microsoft.Data.SqlClient;
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
    public partial class AjouterLot : Form
    {
        public AjouterLot()
        {
            InitializeComponent();
        }


        private void btnReinitialiser_Click_1(object sender, EventArgs e)
        {
            txtQuantite.Clear();

        }
        private void LoadComboBoxes()
        {
            // Medicaments
            using (SqlConnection cn = Connexion.connecter())
            {
                cn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT id, nom FROM medicament", cn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                comboMedicament.DataSource = dt;
                comboMedicament.DisplayMember = "nom";
                comboMedicament.ValueMember = "id";
            }

            // Fournisseurs
            using (SqlConnection cn = Connexion.connecter())
            {
                cn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT id, nom FROM fournisseur", cn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                comboFournisseur.DataSource = dt;
                comboFournisseur.DisplayMember = "nom";
                comboFournisseur.ValueMember = "id";
            }
        }

        private void AjouterLot_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
        }

        private void btnAjouter_Click_1(object sender, EventArgs e)
        {
            // Validate UI fields
            if (string.IsNullOrWhiteSpace(txtLot.Text) ||
                comboMedicament.SelectedIndex == -1 ||
                comboFournisseur.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txtQuantite.Text) ||
                string.IsNullOrWhiteSpace(txtSeuil.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Lot lot = new Lot
            {
                NumeroLot = txtLot.Text,
                MedicamentId = Convert.ToInt32(comboMedicament.SelectedValue),
                FournisseurId = Convert.ToInt32(comboFournisseur.SelectedValue),
                DateFabrication = dateFabrication.Value,
                DatePeremption = datePeremption.Value,
                Quantite = int.Parse(txtQuantite.Text),
                SeuilAlerte = int.Parse(txtSeuil.Text)
            };

            if (lot.Ajouter())
            {
                MessageBox.Show("Lot ajouté avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erreur lors de l'ajout du lot.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            f.Show();
            this.Hide();
        }

        private void ajouterF_Click(object sender, EventArgs e)
        {
            AjouterFournisseur popup = new AjouterFournisseur();

            // Open as modal dialog → stops everything until the popup is closed
            var result = popup.ShowDialog();

            // If fournisseur successfully added → reload combo box
            if (result == DialogResult.OK)
            {
                LoadComboBoxes();
            }
        }
    }
}
