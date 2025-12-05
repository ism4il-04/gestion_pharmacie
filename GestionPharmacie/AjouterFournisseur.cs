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
    public partial class AjouterFournisseur : Form
    {
        public AjouterFournisseur()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {

            if (txtNom.Text == "" || txtTele.Text == "" || txtEmail.Text == "" || txtAdresse.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs obligatoires.", "Champs manquants", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Fournisseur fournisseur = new Fournisseur
                {
                    NomComplet = txtNom.Text,
                    Telephone = txtTele.Text,
                    Email = txtEmail.Text,
                    Adresse = txtAdresse.Text
                };
                bool isAdded = fournisseur.Ajouter();
                if (isAdded)
                {
                    MessageBox.Show("Fournisseur ajouté avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Optionally, clear the form fields after successful addition
                    txtNom.Clear();
                    txtTele.Clear();
                    txtAdresse.Clear();
                    txtEmail.Clear();

                }
                else
                {
                    MessageBox.Show("Erreur lors de l'ajout du fournisseur.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        }
    }
