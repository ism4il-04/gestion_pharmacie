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
    public partial class AccueilClient : Form
    {

        SqlConnection sqlConnection;
        private DataTable dataTable;

        public AccueilClient()
        {
            InitializeComponent();
            sqlConnection = Connexion.connecter();
            ChargerClients();

        }

        public void ChargerClients()
        {
            try
            {
                Client client = new Client();   // Pass the connection
                dataTable = client.Lister();                 // Get the list
                gunaDataGridViewClients.DataSource = dataTable;  // Bind to DataGridView

                gunaDataGridViewClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                gunaDataGridViewClients.ReadOnly = true;         // optional
                gunaDataGridViewClients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des clients : " + ex.Message);
            }
        }

        private void medicamentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Accueil f = new Accueil();
            this.Hide();
            f.Show();
        }

        private void dataGridViewClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ajouterClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AjouterClient ajouterClientForm = new AjouterClient();
            ajouterClientForm.Show();
        }

        private void modifierClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModifierClient modifierClientForm = new ModifierClient();
            modifierClientForm.Show();
        }

        private void gunaDataGridViewClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
