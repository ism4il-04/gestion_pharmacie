using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace GestionPharmacie
{
    public class Client
    {
        public int Id { get; set; }
        public string NomComplet { get; set; }
        public string Telephone { get; set; }
        public string Adresse { get; set; }
        public string Email { get; set; }
        public DateTime DateCreation { get; set; }
        public DateTime DateModification { get; set; }

        private SqlConnection _connection;

        public Client()
        {
            _connection = Connexion.connecter();
        }

        // Ajouter un client
        public bool Ajouter()
        {
            try
            {
                string sql = @"INSERT INTO client
                               (nom_complet, telephone, adresse, email)
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
                Console.WriteLine("Erreur Ajouter(Client): " + ex.Message);
                return false;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }
        }

        // Modifier un client
        public bool Modifier()
        {
            try
            {
                string sql = @"UPDATE client
                               SET telephone=@Telephone, adresse=@Adresse,
                                   email=@Email, date_modification=GETDATE()
                               WHERE nom_complet=@NomComplet";

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

        // Supprimer un client
        public bool Supprimer()
        {
            try
            {
                string sql = "DELETE FROM client WHERE id=@Id";
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
                Console.WriteLine("Erreur Supprimer(Client): " + ex.Message);
                return false;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }
        }

        // Charger un client par ID
        public bool ChargerParId(int id)
        {
            try
            {
                string sql = "SELECT * FROM client WHERE id=@Id";

                using (SqlCommand cmd = new SqlCommand(sql, _connection))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    _connection.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Id = Convert.ToInt32(reader["id"]);
                            NomComplet = reader["nom_complet"].ToString();
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
                Console.WriteLine("Erreur ChargerParId(Client): " + ex.Message);
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
                string sql = "SELECT * FROM client WHERE nom_complet=@Nom";

                using (SqlCommand cmd = new SqlCommand(sql, _connection))
                {
                    cmd.Parameters.AddWithValue("@Nom", nom);
                    _connection.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Id = Convert.ToInt32(reader["id"]);
                            NomComplet = reader["nom_complet"].ToString();
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
                Console.WriteLine("Erreur ChargerParNom(Client): " + ex.Message);
                return false;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }
        }

        // Lister tous les clients
        public DataTable Lister()
        {
            DataTable table = new DataTable();
            try
            {
                string sql = @"SELECT id, nom_complet AS Nom, telephone AS Téléphone,
                                      adresse AS Adresse, email AS Email
                               FROM client
                               ORDER BY nom_complet;";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, _connection);
                adapter.Fill(table);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur Lister(Client): " + ex.Message);
            }

            return table;
        }
    }
}
