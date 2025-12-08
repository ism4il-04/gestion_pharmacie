using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace GestionPharmacie
{
    public class Commande
    {
        public int Id { get; set; }
        public int? ClientId { get; set; }
        public int UtilisateurId { get; set; }
        public DateTime DateCommande { get; set; }
        public string Statut { get; set; } = "en_cours";
        public decimal Total { get; set; }

        public List<CommandeDetails> Details { get; set; } = new();

        private SqlConnection _connection;

        public Commande()
        {
            _connection = Connexion.connecter();
        }

        public int Ajouter()
        {
            try
            {
                string sql = @"INSERT INTO commande (client_id, utilisateur_id, date_commande, statut, total)
                               OUTPUT INSERTED.id
                               VALUES (@ClientId, @UtilisateurId, @DateCommande, @Statut, @Total);";

                using (SqlCommand cmd = new SqlCommand(sql, _connection))
                {
                    DateCommande = DateTime.Now;

                    if (ClientId == null)
                        cmd.Parameters.AddWithValue("@ClientId", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@ClientId", ClientId);
                    cmd.Parameters.AddWithValue("@UtilisateurId", UtilisateurId);
                    cmd.Parameters.AddWithValue("@DateCommande", DateCommande);
                    cmd.Parameters.AddWithValue("@Statut", Statut);
                    cmd.Parameters.AddWithValue("@Total", Total);

                    _connection.Open();
                    Id = (int)cmd.ExecuteScalar();
                }

                return Id;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur Ajouter Commande: " + ex.Message);
                return -1;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }
        }

        // Process details + stock
        public bool TraiterCommande()
        {
            int idCommande = Ajouter();
            if (idCommande <= 0)
                return false;

            foreach (var detail in Details)
            {
                detail.CommandeId = idCommande;

                // 1. Insert commande_details
                int idDetails = detail.Ajouter();
                if (idDetails <= 0)
                    return false;

                // 2. Deduct stock (FEFO)
                List<Lot> lots = RecupererLots(detail.MedicamentId);

                int reste = detail.Quantite;

                foreach (var lot in lots)
                {
                    if (reste <= 0) break;

                    int quantiteAUtiliser = Math.Min(lot.Quantite, reste);

                    // Insert usage
                    CommandeLotUsage usage = new CommandeLotUsage
                    {
                        CommandeDetailsId = idDetails,
                        LotId = lot.Id,
                        QuantiteUtilisee = quantiteAUtiliser
                    };
                    usage.Ajouter();

                    // Update stock
                    lot.MettreAJourStock(lot.Quantite - quantiteAUtiliser);

                    reste -= quantiteAUtiliser;
                }

                if (reste > 0)
                {
                    Console.WriteLine("Stock insuffisant pour un élément.");
                    return false;
                }
            }

            return true;
        }


        private List<Lot> RecupererLots(int medicamentId)
        {
            List<Lot> lots = new();

            try
            {
                string sql = @"SELECT * FROM lot
                               WHERE medicament_id = @MedId
                               AND quantite_stock > 0
                               AND date_peremption > GETDATE()
                               ORDER BY date_peremption ASC;";

                using (SqlCommand cmd = new SqlCommand(sql, _connection))
                {
                    cmd.Parameters.AddWithValue("@MedId", medicamentId);

                    _connection.Open();

                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            lots.Add(new Lot
                            {
                                Id = rd.GetInt32(rd.GetOrdinal("id")),
                                MedicamentId = rd.GetInt32(rd.GetOrdinal("medicament_id")),
                                NumeroLot = rd.GetString(rd.GetOrdinal("numero_lot")),
                                DateFabrication = rd.GetDateTime(rd.GetOrdinal("date_fabrication")),
                                DatePeremption = rd.GetDateTime(rd.GetOrdinal("date_peremption")),
                                Quantite = rd.GetInt32(rd.GetOrdinal("quantite_stock")),
                                SeuilAlerte = rd.GetInt32(rd.GetOrdinal("seuil_alerte"))
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur Récupération Lots: " + ex.Message);
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }

            return lots;
        }

        public bool ChargerParId(int id)
        {
            try
            {
                string sql = @"SELECT * FROM commande WHERE id = @Id";

                using (SqlCommand cmd = new SqlCommand(sql, _connection))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    _connection.Open();

                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        if (rd.Read())
                        {
                            Id = rd.GetInt32(rd.GetOrdinal("id"));
                            ClientId = rd.IsDBNull(rd.GetOrdinal("client_id")) ? null : rd.GetInt32(rd.GetOrdinal("client_id"));
                            UtilisateurId = rd.GetInt32(rd.GetOrdinal("utilisateur_id"));
                            DateCommande = rd.GetDateTime(rd.GetOrdinal("date_commande"));
                            Statut = rd.GetString(rd.GetOrdinal("statut"));
                            Total = rd.GetDecimal(rd.GetOrdinal("total"));
                            return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur ChargerParId: " + ex.Message);
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }

            return false;
        }

        public bool Modifier()
        {
            try
            {
                string sql = @"UPDATE commande 
                              SET client_id = @ClientId, 
                                  statut = @Statut, 
                                  total = @Total 
                              WHERE id = @Id";

                using (SqlCommand cmd = new SqlCommand(sql, _connection))
                {
                    if (ClientId == null)
                        cmd.Parameters.AddWithValue("@ClientId", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@ClientId", ClientId);
                    
                    cmd.Parameters.AddWithValue("@Statut", Statut);
                    cmd.Parameters.AddWithValue("@Total", Total);
                    cmd.Parameters.AddWithValue("@Id", Id);

                    _connection.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur Modifier Commande: " + ex.Message);
                return false;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }
        }

        public bool SupprimerDetails()
        {
            try
            {
                // First, restore stock for all items in this order
                string sqlGetDetails = @"SELECT cd.id, cd.medicament_id, cd.quantite 
                                        FROM commande_details cd 
                                        WHERE cd.commande_id = @CommandeId";

                _connection.Open();

                List<(int detailsId, int medicamentId, int quantite)> detailsList = new();

                using (SqlCommand cmd = new SqlCommand(sqlGetDetails, _connection))
                {
                    cmd.Parameters.AddWithValue("@CommandeId", Id);
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            detailsList.Add((
                                rd.GetInt32(0),
                                rd.GetInt32(1),
                                rd.GetInt32(2)
                            ));
                        }
                    }
                }

                // Restore stock for each detail
                foreach (var detail in detailsList)
                {
                    RestaurerStockPourDetail(detail.detailsId, detail.quantite);
                }

                // Delete usage records
                string sqlDeleteUsage = @"DELETE FROM commande_lot_usage 
                                         WHERE commande_details_id IN 
                                         (SELECT id FROM commande_details WHERE commande_id = @CommandeId)";

                using (SqlCommand cmd = new SqlCommand(sqlDeleteUsage, _connection))
                {
                    cmd.Parameters.AddWithValue("@CommandeId", Id);
                    cmd.ExecuteNonQuery();
                }

                // Delete details
                string sqlDeleteDetails = @"DELETE FROM commande_details WHERE commande_id = @CommandeId";

                using (SqlCommand cmd = new SqlCommand(sqlDeleteDetails, _connection))
                {
                    cmd.Parameters.AddWithValue("@CommandeId", Id);
                    cmd.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur SupprimerDetails: " + ex.Message);
                return false;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }
        }

        private void RestaurerStockPourDetail(int detailsId, int quantite)
        {
            try
            {
                string sql = @"SELECT lot_id, quantite_utilisee 
                              FROM commande_lot_usage 
                              WHERE commande_details_id = @DetailsId";

                List<(int lotId, int quantiteUtilisee)> usages = new();

                using (SqlCommand cmd = new SqlCommand(sql, _connection))
                {
                    cmd.Parameters.AddWithValue("@DetailsId", detailsId);
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            usages.Add((rd.GetInt32(0), rd.GetInt32(1)));
                        }
                    }
                }

                // Restore stock for each lot
                foreach (var usage in usages)
                {
                    string updateSql = @"UPDATE lot 
                                        SET quantite_stock = quantite_stock + @Quantite 
                                        WHERE id = @LotId";

                    using (SqlCommand cmd = new SqlCommand(updateSql, _connection))
                    {
                        cmd.Parameters.AddWithValue("@Quantite", usage.quantiteUtilisee);
                        cmd.Parameters.AddWithValue("@LotId", usage.lotId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur RestaurerStockPourDetail: " + ex.Message);
            }
        }

        public bool ModifierCommande()
        {
            try
            {
                // 1. Delete old details and restore stock
                if (!SupprimerDetails())
                    return false;

                // 2. Update commande header
                if (!Modifier())
                    return false;

                // 3. Add new details and deduct stock
                foreach (var detail in Details)
                {
                    detail.CommandeId = Id;

                    // Insert commande_details
                    int idDetails = detail.Ajouter();
                    if (idDetails <= 0)
                        return false;

                    // Deduct stock (FEFO)
                    List<Lot> lots = RecupererLots(detail.MedicamentId);

                    int reste = detail.Quantite;

                    foreach (var lot in lots)
                    {
                        if (reste <= 0) break;

                        int quantiteAUtiliser = Math.Min(lot.Quantite, reste);

                        // Insert usage
                        CommandeLotUsage usage = new CommandeLotUsage
                        {
                            CommandeDetailsId = idDetails,
                            LotId = lot.Id,
                            QuantiteUtilisee = quantiteAUtiliser
                        };
                        usage.Ajouter();

                        // Update stock
                        lot.MettreAJourStock(lot.Quantite - quantiteAUtiliser);

                        reste -= quantiteAUtiliser;
                    }

                    if (reste > 0)
                    {
                        Console.WriteLine("Stock insuffisant pour un élément.");
                        return false;
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur ModifierCommande: " + ex.Message);
                return false;
            }
        }
    }
}
