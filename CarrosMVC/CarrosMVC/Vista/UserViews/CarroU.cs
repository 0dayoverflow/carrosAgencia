using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarrosMVC.Controlador;

namespace CarrosMVC.Vista.UserViews
{
    public partial class CarroU : Form
    {
        private ConexionController conexionController;

        public CarroU()
        {
            InitializeComponent();
            conexionController = ConexionController.GetInstance();

        }

        private void CarroU_Load(object sender, EventArgs e)
        {
            ConexionController conexionController = ConexionController.GetInstance();
            conexionController.ConnectToDatabase();

            string query = "SELECT * FROM Carro";
            DataTable result = conexionController.ExecuteQuery(query);

            dataGridView1.DataSource = result;
            
            conexionController.DisconnectFromDatabase();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string keyword = textBox1.Text;

            string query = "SELECT c.Nombre AS Propietario, c.Apellido, ca.Marca, ca.Modelo, ca.Anio FROM Carro ca JOIN Cliente c ON ca.IdCliente = c.IdCliente WHERE ca.IdCarro LIKE '%" + keyword + "%' OR ca.Marca LIKE '%" + keyword + "%' OR ca.Modelo LIKE '%" + keyword + "%' OR ca.Anio LIKE '%" + keyword + "%';";

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

        private void button1_Click(object sender, EventArgs e)
        {
            UserPanel userPanel = new UserPanel();
            userPanel.Show();
            this.Hide();

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
