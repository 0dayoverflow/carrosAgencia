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
    public partial class RefaccionesU : Form
    {
        private ConexionController conexionController;

        public RefaccionesU()
        {
            InitializeComponent();
            conexionController = ConexionController.GetInstance();

        }

        private void RefaccionesU_Load(object sender, EventArgs e)
        {
            ConexionController conexionController = ConexionController.GetInstance();
            conexionController.ConnectToDatabase();

            string query = "SELECT * FROM Refacciones";
            DataTable result = conexionController.ExecuteQuery(query);

            dataGridView1.DataSource = result;

            conexionController.DisconnectFromDatabase();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string keyword = textBox1.Text;
            string query = "SELECT IdRefaccion, Nombre, Precio FROM Refacciones WHERE IdRefaccion LIKE '%" + keyword + "%' OR Nombre LIKE '%" + keyword + "%' OR Precio LIKE '%" + keyword + "%';";

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
