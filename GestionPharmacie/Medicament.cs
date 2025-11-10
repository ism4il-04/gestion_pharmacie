using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace GestionPharmacie
{
    public class Medicament
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Reference { get; set; }
        public string Description { get; set; }
        public string Dosage { get; set; }
        public string Categorie { get; set; }
        public decimal PrixAchat { get; set; }
        public decimal PrixVente { get; set; }
        public DateTime DateCreation { get; set; }
        public DateTime DateModification { get; set; }

        private SqlConnection _connection;

        public Medicament()
        {
            _connection = Connexion.connecter(); // Use your Connexion class
        }

        // Add new Medicament
        public bool Ajouter()
        {
            try
            {
                string sql = @"INSERT INTO medicament
                               (nom, reference, description, dosage, categorie, prix_achat, prix_vente)
                               VALUES (@Nom, @Reference, @Description, @Dosage, @Categorie, @PrixAchat, @PrixVente);";

                using (SqlCommand cmd = new SqlCommand(sql, _connection))
                {
                    cmd.Parameters.AddWithValue("@Nom", Nom);
                    cmd.Parameters.AddWithValue("@Reference", Reference);
                    cmd.Parameters.AddWithValue("@Description", Description ?? "");
                    cmd.Parameters.AddWithValue("@Dosage", Dosage ?? "");
                    cmd.Parameters.AddWithValue("@Categorie", Categorie ?? "");
                    cmd.Parameters.AddWithValue("@PrixAchat", PrixAchat);
                    cmd.Parameters.AddWithValue("@PrixVente", PrixVente);

                    _connection.Open();
                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur Ajouter: " + ex.Message);
                return false;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }
        }

        // Update existing Medicament
        public bool Modifier()
        {
            try
            {
                string sql = @"UPDATE medicament
                               SET nom=@Nom, reference=@Reference, description=@Description, dosage=@Dosage,
                                   categorie=@Categorie, prix_achat=@PrixAchat, prix_vente=@PrixVente,
                                   date_modification=GETDATE()
                               WHERE id=@Id";

                using (SqlCommand cmd = new SqlCommand(sql, _connection))
                {
                    cmd.Parameters.AddWithValue("@Id", Id);
                    cmd.Parameters.AddWithValue("@Nom", Nom);
                    cmd.Parameters.AddWithValue("@Reference", Reference);
                    cmd.Parameters.AddWithValue("@Description", Description ?? "");
                    cmd.Parameters.AddWithValue("@Dosage", Dosage ?? "");
                    cmd.Parameters.AddWithValue("@Categorie", Categorie ?? "");
                    cmd.Parameters.AddWithValue("@PrixAchat", PrixAchat);
                    cmd.Parameters.AddWithValue("@PrixVente", PrixVente);

                    _connection.Open();
                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur Modifier: " + ex.Message);
                return false;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }
        }

        // Delete Medicament by ID
        public bool Supprimer()
        {
            try
            {
                string sql = "DELETE FROM medicament WHERE id=@Id";
                using (SqlCommand cmd = new SqlCommand(sql, _connection))
                {
                    cmd.Parameters.AddWithValue("@Id", Id);
                    _connection.Open();
                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur Supprimer: " + ex.Message);
                return false;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }
        }

        // Get Medicament by ID
        public bool ChargerParId(int id)
        {
            try
            {
                string sql = "SELECT * FROM medicament WHERE id=@Id";
                using (SqlCommand cmd = new SqlCommand(sql, _connection))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    _connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Id = Convert.ToInt32(reader["id"]);
                            Nom = reader["nom"].ToString();
                            Reference = reader["reference"].ToString();
                            Description = reader["description"].ToString();
                            Dosage = reader["dosage"].ToString();
                            Categorie = reader["categorie"].ToString();
                            PrixAchat = Convert.ToDecimal(reader["prix_achat"]);
                            PrixVente = Convert.ToDecimal(reader["prix_vente"]);
                            DateCreation = Convert.ToDateTime(reader["date_creation"]);
                            DateModification = Convert.ToDateTime(reader["date_modification"]);
                            return true;
                        }
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur ChargerParId: " + ex.Message);
                return false;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }
        }

        // List all Medicaments with quantity (optional join with lot)
        public DataTable ListerAvecQuantite()
        {
            DataTable table = new DataTable();
            try
            {
                string sql = @"
                    SELECT m.id, m.nom AS Nom, m.reference AS Référence, m.categorie AS Catégorie,
                           m.prix_vente AS PrixVente, ISNULL(SUM(l.quantite_stock),0) AS QuantitéTotale
                    FROM medicament m
                    LEFT JOIN lot l ON m.id = l.medicament_id
                    GROUP BY m.id, m.nom, m.reference, m.categorie, m.prix_vente
                    ORDER BY m.nom;
                ";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, _connection);
                adapter.Fill(table);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur ListerAvecQuantite: " + ex.Message);
            }
            return table;
        }
    }
}
