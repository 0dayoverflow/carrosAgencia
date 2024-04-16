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

namespace CarrosMVC.Vista.AdminCRUDS
{
    public partial class ProximaCita : Form
    {
        private ConexionController conexionController;
        private DateTime FechaProximoServicio;
        private string Marca;
        private string Modelo;
        private int Anio;
        private string Nombre;
        private string Apellido;

        public ProximaCita()
        {
            InitializeComponent();
            conexionController = ConexionController.GetInstance();
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            try
            {
               
                DateTime fechaProximoServicio = DateTime.Parse(dateTimePicker1.Text);
                string marca = txtMarca.Text;
                string modelo = txtModelo.Text;
                int anio = int.Parse(txtAnio.Text);
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;

                
                if (string.IsNullOrEmpty(marca) || string.IsNullOrEmpty(modelo) || string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido))
                {
                    MessageBox.Show("Todos los campos deben estar completos");
                    return;
                }

               
                if (anio < 1960)
                {
                    MessageBox.Show("El auto debe de ser mayor a 1960");
                    return;
                }

                
                string query = $"INSERT INTO ProximoServicio (FechaProximoServicio, Marca, Modelo, Anio, Nombre, Apellido) " +
                               $"VALUES ('{fechaProximoServicio.ToString("yyyy-MM-dd")}', '{marca}', '{modelo}', {anio}, '{nombre}', '{apellido}')";

                conexionController.ExecuteQuery(query);

                MessageBox.Show("Data inserted successfully!");
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

        private void ProximaCita_Load(object sender, EventArgs e)
        {
            // No changes made to this method
            conexionController.ConnectToDatabase();

            string queryDetallesUsuarios = "SELECT * FROM ProximoServicio";
            DataTable result = conexionController.ExecuteQuery(queryDetallesUsuarios);
            dataGridView1.DataSource = result;
            conexionController.DisconnectFromDatabase();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // No changes made to this method
            conexionController.ConnectToDatabase();

            string queryDetallesUsuarios = "SELECT * FROM ProximoServicio";
            DataTable result = conexionController.ExecuteQuery(queryDetallesUsuarios);
            dataGridView1.DataSource = result;
            conexionController.DisconnectFromDatabase();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Clear all the input fields
            dateTimePicker1.Value = DateTime.Now;
            txtMarca.Text = string.Empty;
            txtModelo.Text = string.Empty;
            txtAnio.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
        }
    }
}
