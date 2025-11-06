using DotNetEnv;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace GestionPharmacie
{

    internal class Medicament
    {
        private static readonly string server;
        private static readonly string database;

        static Medicament()
        {
            Env.Load(); // Loads .env file once

            server = Env.GetString("DB_SERVER");
            database = Env.GetString("DB_NAME");
        }

        private string nom;
        private string reference;
        private string description;
        private string dosage;
        private string forme;
        private float prix_unitaire;
        private int quantite_stock;
        private int seuil_alerte;
        private DateTime date_peremption;
        private int fournisseur_id;


        private Medicament() { }
        public Medicament(string nom, string reference, string description, string dosage, string forme, float prix_unitaire, int quantite_stock, int seuil_alerte, DateTime date_peremption, int fournisseur_id)
        {
            this.nom = nom;
            this.reference = reference;
            this.description = description;
            this.dosage = dosage;
            this.forme = forme;
            this.prix_unitaire = prix_unitaire;
            this.quantite_stock = quantite_stock;
            this.seuil_alerte = seuil_alerte;
            this.date_peremption = date_peremption;
            this.fournisseur_id = fournisseur_id;
        }
        public string Nom { get => nom; set => nom = value; }
        public string Reference { get => reference; set => reference = value; }
        public string Description { get => description; set => description = value; }
        public string Dosage { get => dosage; set => dosage = value; }
        public string Forme { get => forme; set => forme = value; }
        public float Prix_unitaire { get => prix_unitaire; set => prix_unitaire = value; }
        public int Quantite_stock { get => quantite_stock; set => quantite_stock = value; }
        public int Seuil_alerte { get => seuil_alerte; set => seuil_alerte = value; }
        public DateTime Date_peremption { get => date_peremption; set => date_peremption = value; }
        public int Fournisseur_id { get => fournisseur_id; set => fournisseur_id = value; }


        //RECHERCHE MEDICAMENT
        public Medicament GetMedicamentById(int id)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = $"Server={server};Database={database};Integrated Security=SSPI;TrustServerCertificate=True;";
            connection.Open();
            Console.WriteLine("Connection successful!");
            string query = "SELECT * FROM medicament WHERE id=" + id;
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            Medicament medicament = null;
            if (reader.Read())
            {
                medicament = new Medicament
                {
                    nom = reader["nom"].ToString(),
                    reference = reader["reference"].ToString(),
                    description = reader["description"].ToString(),
                    dosage = reader["dosage"].ToString(),
                    forme = reader["forme"].ToString(),
                    prix_unitaire = float.Parse(reader["prix_unitaire"].ToString()),
                    quantite_stock = int.Parse(reader["quantite_stock"].ToString()),
                    seuil_alerte = int.Parse(reader["seuil_alerte"].ToString()),
                    date_peremption = DateTime.Parse(reader["date_peremption"].ToString()),
                    fournisseur_id = int.Parse(reader["fournisseur_id"].ToString())
                };
            }
            reader.Close();
            connection.Close();
            return medicament;
        }
        public Medicament GetMedicamentByReference(string reference)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = $"Server={server};Database={database};Integrated Security=SSPI;TrustServerCertificate=True;";
            connection.Open();
            Console.WriteLine("Connection successful!");
            string query = "SELECT * FROM medicament WHERE reference='" + reference + "'";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            Medicament medicament = null;
            if (reader.Read())
            {
                medicament = new Medicament
                {
                    nom = reader["nom"].ToString(),
                    reference = reader["reference"].ToString(),
                    description = reader["description"].ToString(),
                    dosage = reader["dosage"].ToString(),
                    forme = reader["forme"].ToString(),
                    prix_unitaire = float.Parse(reader["prix_unitaire"].ToString()),
                    quantite_stock = int.Parse(reader["quantite_stock"].ToString()),
                    seuil_alerte = int.Parse(reader["seuil_alerte"].ToString()),
                    date_peremption = DateTime.Parse(reader["date_peremption"].ToString()),
                    fournisseur_id = int.Parse(reader["fournisseur_id"].ToString())
                };
            }
            reader.Close();
            connection.Close();
            return medicament;
        }
        public Medicament GetMedicamentByNom(string nom)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = $"Server={server};Database={database};Integrated Security=SSPI;TrustServerCertificate=True;";
            connection.Open();
            Console.WriteLine("Connection successful!");
            string query = "SELECT * FROM medicament WHERE nom='" + nom + "'";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            Medicament medicament = null;
            if (reader.Read())
            {
                medicament = new Medicament
                {
                    nom = reader["nom"].ToString(),
                    reference = reader["reference"].ToString(),
                    description = reader["description"].ToString(),
                    dosage = reader["dosage"].ToString(),
                    forme = reader["forme"].ToString(),
                    prix_unitaire = float.Parse(reader["prix_unitaire"].ToString()),
                    quantite_stock = int.Parse(reader["quantite_stock"].ToString()),
                    seuil_alerte = int.Parse(reader["seuil_alerte"].ToString()),
                    date_peremption = DateTime.Parse(reader["date_peremption"].ToString()),
                    fournisseur_id = int.Parse(reader["fournisseur_id"].ToString())
                };
            }
            reader.Close();
            connection.Close();
            return medicament;
        }

        public Medicament GetMedicamentByDatePeremption(DateTime date_peremption)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = $"Server={server};Database={database};Integrated Security=SSPI;TrustServerCertificate=True;";
            Console.WriteLine("Connection successful!");
            string query = "SELECT * FROM medicament WHERE date_peremption='" + date_peremption.ToString("yyyy-MM-dd") + "'";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            Medicament medicament = null;
            if (reader.Read())
            {
                medicament = new Medicament
                {
                    nom = reader["nom"].ToString(),
                    reference = reader["reference"].ToString(),
                    description = reader["description"].ToString(),
                    dosage = reader["dosage"].ToString(),
                    forme = reader["forme"].ToString(),
                    prix_unitaire = float.Parse(reader["prix_unitaire"].ToString()),
                    quantite_stock = int.Parse(reader["quantite_stock"].ToString()),
                    seuil_alerte = int.Parse(reader["seuil_alerte"].ToString()),
                    date_peremption = DateTime.Parse(reader["date_peremption"].ToString()),
                    fournisseur_id = int.Parse(reader["fournisseur_id"].ToString())
                };
            }
            reader.Close();
            connection.Close();
            return medicament;
        }
        public Medicament getMedicamentByFournisseurId(int fournisseur_id)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = $"Server={server};Database={database};Integrated Security=SSPI;TrustServerCertificate=True;";
            connection.Open();
            Console.WriteLine("Connection successful!");
            string query = "SELECT * FROM medicament WHERE fournisseur_id=" + fournisseur_id;
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            Medicament medicament = null;
            if (reader.Read())
            {
                medicament = new Medicament
                {
                    nom = reader["nom"].ToString(),
                    reference = reader["reference"].ToString(),
                    description = reader["description"].ToString(),
                    dosage = reader["dosage"].ToString(),
                    forme = reader["forme"].ToString(),
                    prix_unitaire = float.Parse(reader["prix_unitaire"].ToString()),
                    quantite_stock = int.Parse(reader["quantite_stock"].ToString()),
                    seuil_alerte = int.Parse(reader["seuil_alerte"].ToString()),
                    date_peremption = DateTime.Parse(reader["date_peremption"].ToString()),
                    fournisseur_id = int.Parse(reader["fournisseur_id"].ToString())
                };
            }
            reader.Close();
            connection.Close();
            return medicament;
        }

        public List<Medicament> GetAllMedicaments()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = $"Server={server};Database={database};Integrated Security=SSPI;TrustServerCertificate=True;";
            connection.Open();
            Console.WriteLine("Connection successful!");
            string query = "SELECT * FROM medicament";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            List<Medicament> medicaments = new List<Medicament>();
            while (reader.Read())
            {
                Medicament medicament = new Medicament
                {
                    nom = reader["nom"].ToString(),
                    reference = reader["reference"].ToString(),
                    description = reader["description"].ToString(),
                    dosage = reader["dosage"].ToString(),
                    forme = reader["forme"].ToString(),
                    prix_unitaire = float.Parse(reader["prix_unitaire"].ToString()),
                    quantite_stock = int.Parse(reader["quantite_stock"].ToString()),
                    seuil_alerte = int.Parse(reader["seuil_alerte"].ToString()),
                    date_peremption = DateTime.Parse(reader["date_peremption"].ToString()),
                    fournisseur_id = int.Parse(reader["fournisseur_id"].ToString())
                };
                medicaments.Add(medicament);
            }
            reader.Close();
            connection.Close();
            return medicaments;
        }

        //AFFICHAGE MEDICAMENT
        public void afficherMedicament()
        {
            Console.WriteLine("Nom: " + nom);
            Console.WriteLine("Reference: " + reference);
            Console.WriteLine("Description: " + description);
            Console.WriteLine("Dosage: " + dosage);
            Console.WriteLine("Forme: " + forme);
            Console.WriteLine("Prix unitaire: " + prix_unitaire);
            Console.WriteLine("Quantite en stock: " + quantite_stock);
            Console.WriteLine("Seuil d'alerte: " + seuil_alerte);
            Console.WriteLine("Date de peremption: " + date_peremption.ToString("yyyy-MM-dd"));
            Console.WriteLine("Fournisseur ID: " + fournisseur_id);
        }
        public static void afficherListeMedicaments(List<Medicament> medicaments)
        {
            foreach (Medicament medicament in medicaments)
            {
                medicament.afficherMedicament();
                Console.WriteLine("-----------------------");
            }
        }


        //AJOUTER, SUPPRIMER, MODIFIER MEDICAMENT
        public void ajouterMedicament(string nom, string reference, string description, string dosage, string forme, float prix_unitaire, int quantite_stock, int seuil_alerte, DateTime date_peremption, int fournisseur_id)
        {

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = $"Server={server};Database={database};Integrated Security=SSPI;TrustServerCertificate=True;";

            connection.Open();
            Console.WriteLine("Connection successful!");

            string query = "INSERT INTO medicament VALUES ('" + nom + "', '" + reference + "', '" + description + "', '" + dosage + "', '" + forme + "', " + prix_unitaire + ", " + quantite_stock + ", " + seuil_alerte + ", '" + date_peremption.ToString("yyyy-MM-dd") + "', "+ fournisseur_id +", '"+ DateTime.Now.ToString("yyyy-MM-dd") + "', '"+ DateTime.Now.ToString("yyyy-MM-dd") + "')";

            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();

        }

        public bool supprimerEmployer(int id)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = $"Server={server};Database={database};Integrated Security=SSPI;TrustServerCertificate=True;";

            connection.Open();
            Console.WriteLine("Connection successful!");

            string query1 = "SELECT * FROM medicament WHERE id=" + id;
            SqlCommand cmd = new SqlCommand(query1, connection);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                reader.Close();
                string query = "DELETE FROM medicament WHERE id=" + id;
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();
                return true;

            }
            return false;
        }
        public void modifierMedicament(int id, string nom, string reference, string description, string dosage, string forme, float prix_unitaire, int quantite_stock, int seuil_alerte, DateTime date_peremption)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = $"Server={server};Database={database};Integrated Security=SSPI;TrustServerCertificate=True;";

            connection.Open();
            Console.WriteLine("Connection successful!");

            string query = "Update medicament SET nom = '" + nom + "', reference = '" + reference + "', description = '" + description + "', dosage = '" + dosage + "', forme = '" + forme + "', prix_unitaire = " + prix_unitaire + ", quantite_stock = " + quantite_stock + ", seuil_alerte = " + seuil_alerte + ", date_peremption = '" + date_peremption.ToString("yyyy-MM-dd") + "', date_modification = '"+ DateTime.Now.ToString("yyyy-MM-dd") + "' WHERE id = " + id;
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();

        }
    }
    }
