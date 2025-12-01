using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace GestionPharmacie
{
    public class Lot
    {
        public int Id { get; set; }
        public string NumeroLot { get; set; }
        public int MedicamentId { get; set; }
        public DateTime DateFabrication { get; set; }
        public DateTime DatePeremption { get; set; }
        public int Quantite { get; set; }
        public int SeuilAlerte { get; set; }
        public int FournisseurId { get; set; }

        private readonly SqlConnection _connection;

        public Lot()
        {
            _connection = Connexion.connecter();
        }

        // ADD NEW LOT (for existing medicament)
        public bool Ajouter()
        {
            try
            {
                string sql = @"
                    INSERT INTO lot
                    (numero_lot, medicament_id, date_fabrication, date_peremption, quantite_stock, seuil_alerte, fournisseur_id)
                    VALUES
                    (@NumeroLot, @MedicamentId, @DateFabrication, @DatePeremption, @Quantite, @SeuilAlerte, @FournisseurId);";

                using (SqlCommand cmd = new SqlCommand(sql, _connection))
                {
                    cmd.Parameters.AddWithValue("@NumeroLot", NumeroLot);
                    cmd.Parameters.AddWithValue("@MedicamentId", MedicamentId);
                    cmd.Parameters.AddWithValue("@DateFabrication", DateFabrication);
                    cmd.Parameters.AddWithValue("@DatePeremption", DatePeremption);
                    cmd.Parameters.AddWithValue("@Quantite", Quantite);
                    cmd.Parameters.AddWithValue("@SeuilAlerte", SeuilAlerte);
                    cmd.Parameters.AddWithValue("@FournisseurId", FournisseurId);

                    _connection.Open();
                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur Ajouter Lot:\n" + ex.Message);
                return false;
            }

            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }
        }

        // UPDATE stock after a sale / commande
        public bool MettreAJourStock(int nouvelleQuantite)
        {
            try
            {
                string sql = @"UPDATE lot SET quantite_stock = @Quantite WHERE id = @Id";

                using (SqlCommand cmd = new SqlCommand(sql, _connection))
                {
                    cmd.Parameters.AddWithValue("@Quantite", nouvelleQuantite);
                    cmd.Parameters.AddWithValue("@Id", Id);

                    _connection.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur Mise à Jour Stock: " + ex.Message);
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
