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

        public static DataTable ListerParCommande(int commandeId)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = Connexion.connecter();

            try
            {
                string sql = @"SELECT cd.id, cd.medicament_id, m.nom AS medicament_nom, 
                              cd.quantite, cd.prix_unitaire, 
                              (cd.quantite * cd.prix_unitaire) AS subtotal
                              FROM commande_details cd
                              INNER JOIN medicament m ON cd.medicament_id = m.id
                              WHERE cd.commande_id = @CommandeId";

                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@CommandeId", commandeId);
                    connection.Open();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur ListerParCommande: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

            return dt;
        }
    }
}
