//using DotNetEnv;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPharmacie
{
    internal class Connexion
    {
        // Remove static readonly fields, use local variables instead
        public static SqlConnection connecter()
        {
            //Env.Load(); // Loads .env file once

            //string server = Env.GetString("DB_SERVER");
            //string database = Env.GetString("DB_NAME");

            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = $"Data Source=ISMAIL_LENOVO;Initial Catalog=pharmacie;Integrated Security=SSPI;TrustServerCertificate=True;";
            return sqlConnection;
        }

        public static void deconnecter(SqlConnection sqlConnection)
        {
            sqlConnection.Close();
        }
    }
}
