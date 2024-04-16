using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarrosMVC.Modelo;

namespace CarrosMVC.Controlador
{
    internal class ConexionController
    {
        private static ConexionController instance;
        private ConexionModel conexionModel;
        private SqlConnection connection;

        private ConexionController()
        {
            conexionModel = new ConexionModel();
            conexionModel.ServerName = "MONSTER\\SQLEXPRESS";
            conexionModel.DatabaseName = "CarrosMVC1";
            string connectionString = conexionModel.GetConnectionString();
            connection = new SqlConnection(connectionString);
        }

        public static ConexionController GetInstance()
        {
            if (instance == null)
            {
                instance = new ConexionController();
            }
            return instance;
        }

        public bool ConnectToDatabase()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error conectando a la base de datos: " + ex.Message);
                return false;
            }
        }

        public void DisconnectFromDatabase()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public DataTable ExecuteQuery(string query)
        {
            DataTable dataTable = new DataTable();

            try
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ejecutando la consulta: " + ex.Message);
            }

            return dataTable;
        }

    }


    /*
     
     ConexionController conexionController = ConexionController.GetInstance();
conexionController.ConnectToDatabase();

string query = "SELECT * FROM TableName";
DataTable result = conexionController.ExecuteQuery(query);

// Process the result DataTable as needed

conexionController.DisconnectFromDatabase();

     */

}
