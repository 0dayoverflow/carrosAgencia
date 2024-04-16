using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarrosMVC.Controlador;

namespace CarrosMVC.Vista
{
    public partial class DuenioXCarro : Form
    {
        private ConexionController conexionController;

        public DuenioXCarro()
        {
            InitializeComponent();
            conexionController = ConexionController.GetInstance();
        }

        private void DuenioXCarro_Load(object sender, EventArgs e)
        {
            conexionController.ConnectToDatabase();
            
            string query = "SELECT c.Nombre AS Propietario, c.Apellido, ca.Marca, ca.Modelo, ca.Anio FROM Carro ca JOIN Cliente c ON ca.IdCliente = c.IdCliente;";

            try
            {
                // Execute the query using the ConexionController
                DataTable result = conexionController.ExecuteQuery(query);

                // Set the data source of the data grid view to the result
                dataGridView1.DataSource = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conexionController.DisconnectFromDatabase();
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyword = textBox1.Text;
            string query = "SELECT c.Nombre AS Propietario, c.Apellido, ca.Marca, ca.Modelo, ca.Anio FROM Carro ca JOIN Cliente c ON ca.IdCliente = c.IdCliente WHERE c.Nombre LIKE '%" + keyword + "%' OR c.Apellido LIKE '%" + keyword + "%' OR ca.Marca LIKE '%" + keyword + "%' OR ca.Modelo LIKE '%" + keyword + "%' OR ca.Anio LIKE '%" + keyword + "%';";

            try
            {
                DataTable result = conexionController.ExecuteQuery(query);
                dataGridView1.DataSource = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conexionController.DisconnectFromDatabase();
            }
        }
    }
}
