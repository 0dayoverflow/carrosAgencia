using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Carros
{
    // Singleton pattern implementation
    internal class ConexionBD
    {
        private static ConexionBD instance; // Singleton instance
        private string connectionString = "Data Source=MONSTER\\SQLEXPRESS;Initial Catalog=CarMaintenance;Integrated Security=True;Encrypt=False;";
        private SqlConnection connection;

        // Private constructor to prevent instantiation from outside the class
        private ConexionBD()
        {
            connection = new SqlConnection(connectionString);
        }

        // Public method to get the singleton instance
        public static ConexionBD GetInstance()
        {
            if (instance == null)
            {
                instance = new ConexionBD();
            }
            return instance;
        }

        // Public method to connect to the database
        public SqlConnection ConectarBD()
        {
            try
            {
                connection.Open();
                return connection;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);
                return null;
            }
        }
    }
}
