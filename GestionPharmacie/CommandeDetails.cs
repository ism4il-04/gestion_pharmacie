using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace GestionPharmacie
{
    public class CommandeDetails
    {
        public int Id { get; set; }
        public int CommandeId { get; set; }
        public int MedicamentId { get; set; }
        public int Quantite { get; set; }
        public decimal PrixUnitaire { get; set; }

        private SqlConnection _connection;

        public CommandeDetails()
        {
            _connection = Connexion.connecter();
        }

        public int Ajouter()
        {
            try
            {
                string sql = @"INSERT INTO commande_details
                               (commande_id, medicament_id, quantite, prix_unitaire)
                               OUTPUT INSERTED.id
                               VALUES (@CommandeId, @MedicamentId, @Quantite, @PrixUnitaire);";

                using (SqlCommand cmd = new SqlCommand(sql, _connection))
                {
                    cmd.Parameters.AddWithValue("@CommandeId", CommandeId);
                    cmd.Parameters.AddWithValue("@MedicamentId", MedicamentId);
                    cmd.Parameters.AddWithValue("@Quantite", Quantite);
                    cmd.Parameters.AddWithValue("@PrixUnitaire", PrixUnitaire);

                    _connection.Open();

                    return (int)cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur Ajouter CommandeDetails: " + ex.Message);
                return -1;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }
        }
    }
}
