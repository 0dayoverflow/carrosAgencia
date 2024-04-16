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

namespace CarrosMVC.Vista.UserViews
{
    public partial class ClienteU : Form
    {
        private ConexionController conexionController;

        public ClienteU()
        {
            InitializeComponent();
            conexionController = ConexionController.GetInstance();

        }

        private void ClienteU_Load(object sender, EventArgs e)
        {
            ConexionController conexionController = ConexionController.GetInstance();
            conexionController.ConnectToDatabase();

            string query = "SELECT * FROM Cliente";
            DataTable result = conexionController.ExecuteQuery(query);

            dataGridView1.DataSource = result;

            conexionController.DisconnectFromDatabase();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string keyword = textBox1.Text;
            string query = "SELECT IdCliente, Nombre, Apellido, Correo, Telefono FROM Cliente WHERE IdCliente LIKE '%" + keyword + "%' OR Nombre LIKE '%" + keyword + "%' OR Apellido LIKE '%" + keyword + "%' OR Correo LIKE '%" + keyword + "%' OR Telefono LIKE '%" + keyword + "%';";

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
    }
}
