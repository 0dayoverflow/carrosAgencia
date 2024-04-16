using CarrosMVC.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarrosMVC.Vista
{
    public partial class EstatusServicio : Form
    {
        private ConexionController conexionController;

        public EstatusServicio()
        {
            InitializeComponent();
            conexionController = ConexionController.GetInstance();

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

            string query = $"SELECT c.IdCarro, c.Marca, c.Modelo, c.Anio, cl.Nombre AS Propietario, cl.Apellido AS Apellido_Propietario, s.Estatus\r\nFROM Carro c\r\nJOIN Cliente cl ON c.IdCliente = cl.IdCliente\r\nJOIN Servicio s ON c.IdServicio = s.IdServicio\r\nWHERE s.Estatus = '{keyword}'";

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

        private void EstatusServicio_Load(object sender, EventArgs e)
        {
            conexionController.ConnectToDatabase();

            string query = "SELECT c.IdCarro, c.Marca, c.Modelo, c.Anio, cl.Nombre AS Propietario, cl.Apellido AS Apellido_Propietario, s.Estatus\r\nFROM Carro c\r\nJOIN Cliente cl ON c.IdCliente = cl.IdCliente\r\nJOIN Servicio s ON c.IdServicio = s.IdServicio;";

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
    }
}
