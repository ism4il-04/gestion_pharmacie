using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace GestionPharmacie
{
    public class Commande
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int UtilisateurId { get; set; }
        public DateTime DateCommande { get; set; }
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
                string sql = @"INSERT INTO commande (client_id, utilisateur_id, date_commande, total)
                               OUTPUT INSERTED.id
                               VALUES (@ClientId, @UtilisateurId, @DateCommande, @Total);";

                using (SqlCommand cmd = new SqlCommand(sql, _connection))
                {
                    DateCommande = DateTime.Now;

                    cmd.Parameters.AddWithValue("@ClientId", ClientId);
                    cmd.Parameters.AddWithValue("@UtilisateurId", UtilisateurId);
                    cmd.Parameters.AddWithValue("@DateCommande", DateCommande);
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
    }
}
