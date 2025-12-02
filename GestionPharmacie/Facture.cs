using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace GestionPharmacie
{
    public class Facture
    {
        private SqlConnection _connection;

        public int Id { get; set; }
        public int CommandeId { get; set; }
        public DateTime DateFacture { get; set; }
        public decimal MontantTotal { get; set; }
        public string StatutPaiement { get; set; }

        public Facture()
        {
            _connection = Connexion.connecter();
            DateFacture = DateTime.Now;
            StatutPaiement = "en_attente";
        }

        // Add new invoice
        public int Ajouter()
        {
            try
            {
                string sql = @"INSERT INTO facture (commande_id, date_facture, montant_total, statut_paiement)
                              OUTPUT INSERTED.id
                              VALUES (@CommandeId, @DateFacture, @MontantTotal, @StatutPaiement)";

                using (SqlCommand cmd = new SqlCommand(sql, _connection))
                {
                    cmd.Parameters.AddWithValue("@CommandeId", CommandeId);
                    cmd.Parameters.AddWithValue("@DateFacture", DateFacture);
                    cmd.Parameters.AddWithValue("@MontantTotal", MontantTotal);
                    cmd.Parameters.AddWithValue("@StatutPaiement", StatutPaiement);

                    _connection.Open();
                    Id = (int)cmd.ExecuteScalar();
                }

                return Id;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erreur lors de l'ajout de la facture: {ex.Message}");
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }
        }

        // Update invoice
        public bool Modifier()
        {
            try
            {
                string sql = @"UPDATE facture 
                              SET statut_paiement = @StatutPaiement,
                                  montant_total = @MontantTotal
                              WHERE id = @Id";

                using (SqlCommand cmd = new SqlCommand(sql, _connection))
                {
                    cmd.Parameters.AddWithValue("@Id", Id);
                    cmd.Parameters.AddWithValue("@StatutPaiement", StatutPaiement);
                    cmd.Parameters.AddWithValue("@MontantTotal", MontantTotal);

                    _connection.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur Modifier Facture: " + ex.Message);
                return false;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }
        }

        // Delete invoice
        public bool Supprimer()
        {
            try
            {
                string sql = "DELETE FROM facture WHERE id = @Id";

                using (SqlCommand cmd = new SqlCommand(sql, _connection))
                {
                    cmd.Parameters.AddWithValue("@Id", Id);

                    _connection.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur Supprimer Facture: " + ex.Message);
                return false;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }
        }

        // Get all invoices
        public DataTable Lister()
        {
            try
            {
                string sql = @"SELECT 
                                f.id AS 'ID',
                                f.commande_id AS 'Commande ID',
                                c.client_id AS 'Client ID',
                                cl.nom_complet AS 'Client',
                                f.date_facture AS 'Date Facture',
                                f.montant_total AS 'Montant Total',
                                f.statut_paiement AS 'Statut Paiement'
                              FROM facture f
                              INNER JOIN commande c ON f.commande_id = c.id
                              INNER JOIN client cl ON c.client_id = cl.id
                              ORDER BY f.date_facture DESC";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, _connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur Lister Factures: " + ex.Message);
                return new DataTable();
            }
        }

        // Get invoice by order ID
        public static Facture GetByCommandeId(int commandeId)
        {
            try
            {
                SqlConnection connection = Connexion.connecter();
                string sql = @"SELECT id, commande_id, date_facture, montant_total, statut_paiement
                              FROM facture
                              WHERE commande_id = @CommandeId";

                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@CommandeId", commandeId);

                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Facture facture = new Facture
                            {
                                Id = reader.GetInt32(0),
                                CommandeId = reader.GetInt32(1),
                                DateFacture = reader.GetDateTime(2),
                                MontantTotal = reader.GetDecimal(3),
                                StatutPaiement = reader.GetString(4)
                            };
                            return facture;
                        }
                    }
                    connection.Close();
                }

                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur GetByCommandeId: " + ex.Message);
                return null;
            }
        }

        // Get invoice by ID
        public static Facture GetById(int id)
        {
            try
            {
                SqlConnection connection = Connexion.connecter();
                string sql = @"SELECT id, commande_id, date_facture, montant_total, statut_paiement
                              FROM facture
                              WHERE id = @Id";

                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@Id", id);

                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Facture facture = new Facture
                            {
                                Id = reader.GetInt32(0),
                                CommandeId = reader.GetInt32(1),
                                DateFacture = reader.GetDateTime(2),
                                MontantTotal = reader.GetDecimal(3),
                                StatutPaiement = reader.GetString(4)
                            };
                            return facture;
                        }
                    }
                    connection.Close();
                }

                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur GetById: " + ex.Message);
                return null;
            }
        }

        // Check if invoice exists for order
        public static bool ExistsForCommande(int commandeId)
        {
            try
            {
                SqlConnection connection = Connexion.connecter();
                string sql = "SELECT COUNT(*) FROM facture WHERE commande_id = @CommandeId";

                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@CommandeId", commandeId);

                    connection.Open();
                    int count = (int)cmd.ExecuteScalar();
                    connection.Close();

                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur ExistsForCommande: " + ex.Message);
                return false;
            }
        }
    }
}
