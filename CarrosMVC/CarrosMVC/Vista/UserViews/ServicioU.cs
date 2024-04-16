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
    public partial class ServicioU : Form
    {
        private ConexionController conexionController;

        public ServicioU()
        {
            InitializeComponent();
            conexionController = ConexionController.GetInstance();

        }

        private void ServicioU_Load(object sender, EventArgs e)
        {
            ConexionController conexionController = ConexionController.GetInstance();
            conexionController.ConnectToDatabase();

            string query = "SELECT * FROM Servicio";
            DataTable result = conexionController.ExecuteQuery(query);

            dataGridView1.DataSource = result;

            conexionController.DisconnectFromDatabase();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string keyword = textBox1.Text;
            string query = "SELECT IdServicio, FechaServicio, Descripcion, Estatus, Precio FROM Servicio WHERE IdServicio LIKE '%" + keyword + "%' OR FechaServicio LIKE '%" + keyword + "%' OR Descripcion LIKE '%" + keyword + "%' OR Estatus LIKE '%" + keyword + "%' OR Precio LIKE '%" + keyword + "%';";

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
