using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace GestionPharmacie
{
    public class CommandeLotUsage
    {
        public int Id { get; set; }
        public int CommandeDetailsId { get; set; }
        public int LotId { get; set; }
        public int QuantiteUtilisee { get; set; }

        private SqlConnection _connection;

        public CommandeLotUsage()
        {
            _connection = Connexion.connecter();
        }

        public bool Ajouter()
        {
            try
            {
                string sql = @"INSERT INTO commande_lot_usage
                               (commande_details_id, lot_id, quantite_utilisee)
                               VALUES (@DetailsId, @LotId, @QuantiteUtilisee);";

                using (SqlCommand cmd = new SqlCommand(sql, _connection))
                {
                    cmd.Parameters.AddWithValue("@DetailsId", CommandeDetailsId);
                    cmd.Parameters.AddWithValue("@LotId", LotId);
                    cmd.Parameters.AddWithValue("@QuantiteUtilisee", QuantiteUtilisee);

                    _connection.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur Ajouter CommandeLotUsage: " + ex.Message);
                return false;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }
        }
    }
}
