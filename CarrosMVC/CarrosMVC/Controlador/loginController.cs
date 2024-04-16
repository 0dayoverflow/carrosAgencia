using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarrosMVC.Controlador;
using CarrosMVC.Modelo;

namespace CarrosMVC.Controlador
{
    internal class loginController
    {
        public bool loginAdmin(string user, string pass)
        {
            ConexionController conexionController = ConexionController.GetInstance();
            try
            {
                conexionController.ConnectToDatabase();

                string query = $"SELECT Usuario, Clave, Nivel FROM Login WHERE  Usuario='{user}' AND Clave='{pass}' AND Nivel=1;";
                DataTable result = conexionController.ExecuteQuery(query);

                // Check if there are any rows in the DataTable
                if (result.Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
            finally
            {
                conexionController.DisconnectFromDatabase();
            }
        }//fin de LoginAdmin

        public bool loginUser(string user, string pass)
        {
            ConexionController conexionController = ConexionController.GetInstance();
            try
            {
                conexionController.ConnectToDatabase();

                string query = $"SELECT Usuario, Clave, Nivel FROM Login WHERE  Usuario='{user}' AND Clave='{pass}' AND Nivel=2;";
                DataTable result = conexionController.ExecuteQuery(query);

                // Check if there are any rows in the DataTable
                if (result.Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
            finally
            {
                conexionController.DisconnectFromDatabase();
            }
        }//fin de ConsultaAdmin



    }
}
