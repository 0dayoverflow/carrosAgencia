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
    public partial class ServicioA : Form
    {
        private ConexionController conexionController;

        public ServicioA()
        {
            InitializeComponent();
            conexionController = ConexionController.GetInstance();

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {

                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Get the value of the desired column in the selected row
                string idServicio = selectedRow.Cells["IdServicio"].Value.ToString();

                string query = $"DELETE FROM Servicio WHERE idServicio={idServicio}";
                conexionController.ConnectToDatabase();
                conexionController.ExecuteQuery(query);
                conexionController.DisconnectFromDatabase();
                MessageBox.Show("Datos borrados correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al borrar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void actualizarDgv_Click(object sender, EventArgs e)
        {
            ConexionController conexionController = ConexionController.GetInstance();
            conexionController.ConnectToDatabase();

            string queryCarro = "SELECT * FROM Servicio";
            DataTable resultCarro = conexionController.ExecuteQuery(queryCarro);
            dataGridView1.DataSource = resultCarro;
            conexionController.DisconnectFromDatabase();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txdDescripcion.Text) || string.IsNullOrEmpty(txtPrecio.Text) || string.IsNullOrEmpty(dateTimePicker1.Text) || string.IsNullOrEmpty(boxEstatus.Text))
                {
                    MessageBox.Show("Los campos no pueden estar vacíos.");
                    return;
                }

                // Get the selected row from the DataGridView

                DateTime fechaServicio = DateTime.Parse(dateTimePicker1.Text);

                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Get the value of the desired column in the selected row
                string idServicio = selectedRow.Cells["IdServicio"].Value.ToString();

                string query = "UPDATE Servicio SET Precio = '" + txtPrecio.Text + "', FechaServicio = '" + fechaServicio.ToString("yyyy-MM-dd") + "', Estatus = '" + boxEstatus.Text + "' WHERE IdServicio = '" + idServicio + "'";
                conexionController.ConnectToDatabase();
                conexionController.ExecuteQuery(query);
                conexionController.DisconnectFromDatabase();
                MessageBox.Show("Datos actualizados correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexionController.DisconnectFromDatabase();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txdDescripcion.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            dateTimePicker1.Value = DateTime.Now;
            boxEstatus.Text = string.Empty;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txdDescripcion.Text) || string.IsNullOrEmpty(txtPrecio.Text) || string.IsNullOrEmpty(dateTimePicker1.Text) || string.IsNullOrEmpty(boxEstatus.Text))
                {
                    MessageBox.Show("Los campos no pueden estar vacíos.");
                    return;
                }
                DateTime fechaServicio = DateTime.Parse(dateTimePicker1.Text);


                string query = "INSERT INTO Servicio (Descripcion, Precio, FechaServicio, Estatus) VALUES ('" + txdDescripcion.Text + "', '" + txtPrecio.Text + "', '" + fechaServicio.ToString("yyyy-MM-dd") + "', '" + boxEstatus.Text + "')";
                conexionController.ConnectToDatabase();
                conexionController.ExecuteQuery(query);
                conexionController.DisconnectFromDatabase();
                MessageBox.Show("Datos ingresados correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexionController.DisconnectFromDatabase();
            }

        }

        private void ServicioA_Load(object sender, EventArgs e)
        {
            ConexionController conexionController = ConexionController.GetInstance();
            conexionController.ConnectToDatabase();

            string queryCarro = "SELECT * FROM Servicio";
            DataTable resultCarro = conexionController.ExecuteQuery(queryCarro);
            dataGridView1.DataSource = resultCarro;
            conexionController.DisconnectFromDatabase();
        }
    }
}
