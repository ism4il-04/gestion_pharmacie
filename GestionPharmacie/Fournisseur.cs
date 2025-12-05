using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPharmacie
{
    internal class Fournisseur
    {
        public int Id { get; set; }
        public string NomComplet { get; set; }
        public string Telephone { get; set; }
        public string Adresse { get; set; }
        public string Email { get; set; }
        public DateTime DateCreation { get; set; }
        public DateTime DateModification { get; set; }

        private SqlConnection _connection;

        public Fournisseur()
        {
            _connection = Connexion.connecter();
        }

        public bool Ajouter()
        {
            try
            {
                string sql = @"INSERT INTO fournisseur
                               (nom, telephone, adresse, email)
                               VALUES (@NomComplet, @Telephone, @Adresse, @Email);";

                using (SqlCommand cmd = new SqlCommand(sql, _connection))
                {
                    cmd.Parameters.AddWithValue("@NomComplet", NomComplet);
                    cmd.Parameters.AddWithValue("@Telephone", Telephone ?? "");
                    cmd.Parameters.AddWithValue("@Adresse", Adresse ?? "");
                    cmd.Parameters.AddWithValue("@Email", Email ?? "");

                    _connection.Open();
                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur Ajouter(Fournisseur): " + ex.Message);
                return false;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }
        }

        public bool Modifier()
        {
            try
            {
                string sql = @"UPDATE fournisseur
                               SET telephone=@Telephone, adresse=@Adresse,
                                   email=@Email, date_modification=GETDATE()
                               WHERE nom=@NomComplet";

                using (SqlCommand cmd = new SqlCommand(sql, _connection))
                {
                    cmd.Parameters.AddWithValue("@NomComplet", NomComplet);
                    cmd.Parameters.AddWithValue("@Telephone", Telephone ?? "");
                    cmd.Parameters.AddWithValue("@Adresse", Adresse ?? "");
                    cmd.Parameters.AddWithValue("@Email", Email ?? "");

                    _connection.Open();
                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur Modifier(Client): " + ex.Message);
                return false;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }
        }

        public bool Supprimer()
        {
            try
            {
                string sql = "DELETE FROM fournisseur WHERE id=@Id";
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
                Console.WriteLine("Erreur Supprimer(Fournisseur): " + ex.Message);
                return false;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }
        }

        
        public bool ChargerParId(int id)
        {
            try
            {
                string sql = "SELECT * FROM fournisseur WHERE id=@Id";

                using (SqlCommand cmd = new SqlCommand(sql, _connection))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    _connection.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Id = Convert.ToInt32(reader["id"]);
                            NomComplet = reader["nom"].ToString();
                            Telephone = reader["telephone"].ToString();
                            Adresse = reader["adresse"].ToString();
                            Email = reader["email"].ToString();
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
                Console.WriteLine("Erreur ChargerParId(Fournisseur): " + ex.Message);
                return false;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }
        }

        // Charger un client par nom
        public bool ChargerParNom(string nom)
        {
            try
            {
                string sql = "SELECT * FROM fournisseur WHERE nom=@Nom";

                using (SqlCommand cmd = new SqlCommand(sql, _connection))
                {
                    cmd.Parameters.AddWithValue("@Nom", nom);
                    _connection.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Id = Convert.ToInt32(reader["id"]);
                            NomComplet = reader["nom"].ToString();
                            Telephone = reader["telephone"].ToString();
                            Adresse = reader["adresse"].ToString();
                            Email = reader["email"].ToString();
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
                Console.WriteLine("Erreur ChargerParNom(Fournisseur): " + ex.Message);
                return false;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }
        }

   
        public DataTable Lister()
        {
            DataTable table = new DataTable();
            try
            {
                string sql = @"SELECT id, nom AS Nom, telephone AS Téléphone,
                                      adresse AS Adresse, email AS Email
                               FROM fournisseur
                               ORDER BY nom;";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, _connection);
                adapter.Fill(table);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur Lister(Fournisseur): " + ex.Message);
            }

            return table;
        }
    }
}