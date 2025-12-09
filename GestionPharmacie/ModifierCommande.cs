using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace GestionPharmacie
{
    public partial class ModifierCommande : Form
    {
        private DataTable commandeDetailsTable;
        private int commandeId;
        private int currentUserId = 1; // TODO: Replace with actual logged-in user ID

        public ModifierCommande(int id)
        {
            commandeId = id;
            InitializeComponent();
            InitializeGrid();
            LoadClients();
            LoadMedicaments();
            LoadCommande();

            // Wire up event handlers
            guna2Button1.Click += btnAjouterMedicament_Click;
            btnAjouter.Click += btnValider_Click;
            btnReinitialiser.Click += btnReinitialiser_Click;
            btnRetour.Click += btnRetour_Click;
            btnNom.Click += btnNouveauClient_Click;
            btnSupprimerMedicament.Click += btnSupprimerMedicament_Click;
        }

        private void InitializeGrid()
        {
            // Create DataTable for the grid
            commandeDetailsTable = new DataTable();
            commandeDetailsTable.Columns.Add("MedicamentId", typeof(int));
            commandeDetailsTable.Columns.Add("Nom", typeof(string));
            commandeDetailsTable.Columns.Add("Quantité", typeof(int));
            commandeDetailsTable.Columns.Add("Prix Unitaire", typeof(decimal));
            commandeDetailsTable.Columns.Add("Subtotal", typeof(decimal));

            // Bind to grid
            commandeDetailsGrid.DataSource = commandeDetailsTable;

            // Hide the ID column
            if (commandeDetailsGrid.Columns.Count > 0)
            {
                commandeDetailsGrid.Columns["MedicamentId"].Visible = false;
            }

            // Auto-resize columns
            commandeDetailsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadCommande()
        {
            try
            {
                Commande commande = new Commande();
                if (commande.ChargerParId(commandeId))
                {
                    // Set client
                    if (commande.ClientId == null)
                    {
                        comboClient.SelectedValue = 0; // Anonymous client
                    }
                    else
                    {
                        comboClient.SelectedValue = commande.ClientId;
                    }

                    // Load details
                    DataTable details = CommandeDetails.ListerParCommande(commandeId);
                    foreach (DataRow row in details.Rows)
                    {
                        commandeDetailsTable.Rows.Add(
                            row["medicament_id"],
                            row["medicament_nom"],
                            row["quantite"],
                            row["prix_unitaire"],
                            row["subtotal"]
                        );
                    }
                }
                else
                {
                    MessageBox.Show("Erreur lors du chargement de la commande.",
                        "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement de la commande: " + ex.Message,
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void LoadClients()
        {
            try
            {
                Client client = new Client();
                DataTable clientsTable = client.Lister();

                DataRow anonymousRow = clientsTable.NewRow();
                anonymousRow["id"] = 0;
                anonymousRow["Nom"] = "Client anonyme";
                clientsTable.Rows.InsertAt(anonymousRow, 0);

                comboClient.DataSource = clientsTable;
                comboClient.DisplayMember = "Nom";
                comboClient.ValueMember = "id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des clients: " + ex.Message,
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadMedicaments()
        {
            try
            {
                Medicament medicament = new Medicament();
                DataTable medicamentsTable = medicament.ListerAvecQuantite();

                comboMedicament.DataSource = medicamentsTable;
                comboMedicament.DisplayMember = "Nom";
                comboMedicament.ValueMember = "id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des médicaments: " + ex.Message,
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAjouterMedicament_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate inputs
                if (comboMedicament.SelectedValue == null)
                {
                    MessageBox.Show("Veuillez sélectionner un médicament.",
                        "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtQte.Text) || !int.TryParse(txtQte.Text, out int quantite) || quantite <= 0)
                {
                    MessageBox.Show("Veuillez entrer une quantité valide.",
                        "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int medicamentId = Convert.ToInt32(comboMedicament.SelectedValue);

                // Get medicament details
                Medicament medicament = new Medicament();
                if (!medicament.ChargerParId(medicamentId))
                {
                    MessageBox.Show("Erreur lors du chargement du médicament.",
                        "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if medicament already exists in the grid
                foreach (DataRow row in commandeDetailsTable.Rows)
                {
                    if (Convert.ToInt32(row["MedicamentId"]) == medicamentId)
                    {
                        MessageBox.Show("Ce médicament est déjà dans la commande. Modifiez la quantité directement dans le tableau.",
                            "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }

                // Check stock availability
                int stockDisponible = GetStockDisponible(medicamentId);
                if (stockDisponible < quantite)
                {
                    MessageBox.Show($"Stock insuffisant! Disponible: {stockDisponible}",
                        "Stock insuffisant", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Calculate subtotal
                decimal subtotal = quantite * medicament.PrixVente;

                // Add to grid
                commandeDetailsTable.Rows.Add(
                    medicamentId,
                    medicament.Nom,
                    quantite,
                    medicament.PrixVente,
                    subtotal
                );

                // Clear inputs
                txtQte.Clear();
                comboMedicament.SelectedIndex = -1;

                MessageBox.Show("Médicament ajouté à la commande!",
                    "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ajout du médicament: " + ex.Message,
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetStockDisponible(int medicamentId)
        {
            int stock = 0;
            try
            {
                SqlConnection connection = Connexion.connecter();
                string sql = @"SELECT ISNULL(SUM(quantite_stock), 0) 
                              FROM lot 
                              WHERE medicament_id = @MedicamentId 
                              AND quantite_stock > 0 
                              AND date_peremption > GETDATE()";

                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@MedicamentId", medicamentId);
                    connection.Open();
                    stock = Convert.ToInt32(cmd.ExecuteScalar());
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur GetStockDisponible: " + ex.Message);
            }

            return stock;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            try
            {
                int clientId = Convert.ToInt32(comboClient.SelectedValue);

                // 0 = client anonyme
                if (clientId == 0)
                {
                    clientId = -1; // marqueur temporaire
                }

                // Validate that there are items in the order
                if (commandeDetailsTable.Rows.Count == 0)
                {
                    MessageBox.Show("Veuillez ajouter au moins un médicament à la commande.",
                        "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Calculate total
                decimal total = 0;
                foreach (DataRow row in commandeDetailsTable.Rows)
                {
                    total += Convert.ToDecimal(row["Subtotal"]);
                }

                // Create the commande object
                Commande commande = new Commande();
                commande.ChargerParId(commandeId); // Load existing data

                commande.ClientId = (clientId == -1 ? (int?)null : clientId);
                commande.Total = total;

                // Clear existing details
                commande.Details.Clear();

                // Add new details
                foreach (DataRow row in commandeDetailsTable.Rows)
                {
                    CommandeDetails detail = new CommandeDetails
                    {
                        MedicamentId = Convert.ToInt32(row["MedicamentId"]),
                        Quantite = Convert.ToInt32(row["Quantité"]),
                        PrixUnitaire = Convert.ToDecimal(row["Prix Unitaire"])
                    };
                    commande.Details.Add(detail);
                }

                // Modify the commande (this will handle stock restoration and deduction)
                bool success = commande.ModifierCommande();

                if (success)
                {
                    DialogResult result = MessageBox.Show($"Commande modifiée avec succès!\nTotal: {total:C2}",
                        "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (result == DialogResult.OK)
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Erreur lors de la modification de la commande. Vérifiez le stock disponible.",
                        "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la validation de la commande: " + ex.Message,
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReinitialiser_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Êtes-vous sûr de vouloir réinitialiser les modifications?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                commandeDetailsTable.Clear();
                LoadCommande(); // Reload original data
            }
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSupprimerMedicament_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if a row is selected
                if (commandeDetailsGrid.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Veuillez sélectionner un médicament à supprimer.",
                        "Sélection requise", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Get the selected row
                DataGridViewRow selectedRow = commandeDetailsGrid.SelectedRows[0];
                string medicamentNom = selectedRow.Cells["Nom"].Value.ToString();

                // Confirm deletion
                DialogResult result = MessageBox.Show(
                    $"Êtes-vous sûr de vouloir supprimer '{medicamentNom}' de la commande?",
                    "Confirmation de suppression",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Remove the row from the DataTable
                    int rowIndex = selectedRow.Index;
                    commandeDetailsTable.Rows.RemoveAt(rowIndex);

                    MessageBox.Show("Médicament supprimé de la commande!",
                        "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la suppression du médicament: " + ex.Message,
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNouveauClient_Click(object sender, EventArgs e)
        {
            AjouterClient f = new AjouterClient();
            f.ShowDialog();

            // Reload clients after adding a new one
            LoadClients();
        }
    }
}
