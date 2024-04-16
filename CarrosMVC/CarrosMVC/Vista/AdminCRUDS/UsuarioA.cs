using CarrosMVC.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarrosMVC.Vista.AdminCRUDS
{
    public partial class UsuarioA : Form
    {
        private ConexionController conexionController;

        public UsuarioA()
        {
            InitializeComponent();
            conexionController = ConexionController.GetInstance();
        }

        private void UsuarioA_Load(object sender, EventArgs e)
        {
            conexionController.ConnectToDatabase();

            string query = "SELECT * FROM Cliente";

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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string correo = txtCorreo.Text;
            string telefono = txtTelefono.Text;

            // Check if any of the fields are empty
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) || string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(telefono))
            {
                MessageBox.Show("Todos los campos deben ser completados.");
                return;
            }

            string emailPattern = @"@(gmail|hotmail|yahoo|outlook)\.(com|es|net)";

            // Check if the correo matches the email pattern
            if (Regex.IsMatch(correo, emailPattern))
            {
                string query = $"INSERT INTO Cliente (Nombre, Apellido, Correo, Telefono) VALUES ('{nombre}', '{apellido}', '{correo}', '{telefono}')";

                try
                {
                    conexionController.ConnectToDatabase();
                    conexionController.ExecuteQuery(query);
                    MessageBox.Show("Cliente agregado correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar el cliente: " + ex.Message);
                }
                finally
                {
                    conexionController.DisconnectFromDatabase();
                }
            }
            else
            {
                MessageBox.Show("El correo proporcionado no es válido. Por favor, ingrese un correo de algun provedor (gmail, hotmail, yahoo, outlook).");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Get the values from the text boxes
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string correo = txtCorreo.Text;
            string telefono = txtTelefono.Text;
            string emailPattern = @"@(gmail|hotmail|yahoo|outlook)\.(com|es|net)";

            // Check if any of the fields are empty
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) || string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(telefono))
            {
                MessageBox.Show("Todos los campos deben ser completados.");
                return;
            }

            // Check if the correo matches the email pattern
            if (Regex.IsMatch(correo, emailPattern))
            {
                int id;

                //first get the id that were selected in the datagridview  in the cell [idCliente]
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    id = Convert.ToInt32(selectedRow.Cells["IdCliente"].Value);
                }
                else
                {
                    MessageBox.Show("Seleccione una fila para actualizar.");
                    return;
                }

                // Construct the update query
                string query = $"UPDATE Cliente SET Nombre = '{nombre}', Apellido = '{apellido}', Correo = '{correo}', Telefono = '{telefono}' WHERE idCliente = {id}";

                try
                {
                    // Connect to the database
                    conexionController.ConnectToDatabase();

                    // Execute the update query using the ConexionController
                    conexionController.ExecuteQuery(query);

                    MessageBox.Show("Cliente actualizado correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar el cliente: " + ex.Message);
                }
                finally
                {
                    // Disconnect from the database
                    conexionController.DisconnectFromDatabase();
                }
            }
            else
            {
                MessageBox.Show("El correo proporcionado no es válido. Por favor, ingrese un correo de algun provedor (gmail, hotmail, yahoo, outlook).");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtApellido.Clear();
            txtNombre.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            // Check if a row is selected in the data grid view
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Get the ID value from the selected row
                int id = Convert.ToInt32(selectedRow.Cells["IdCliente"].Value);

                // Construct the delete query
                string query = $"DELETE FROM Cliente WHERE IdCliente = {id}";

                try
                {
                    // Connect to the database
                    conexionController.ConnectToDatabase();

                    // Execute the delete query using the ConexionController
                    conexionController.ExecuteQuery(query);

                    MessageBox.Show("Cliente eliminado correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el cliente: " + ex.Message);
                }
                finally
                {
                    // Disconnect from the database
                    conexionController.DisconnectFromDatabase();
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila para eliminar.");
            }
        }

        private void btnActualizarDtgtview_Click(object sender, EventArgs e)
        {
            conexionController.ConnectToDatabase();

            string query = "SELECT * From Cliente;";

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
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if a valid row index and column index is clicked
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Get the values from the selected row
                string nombre = selectedRow.Cells["Nombre"].Value.ToString();
                string apellido = selectedRow.Cells["Apellido"].Value.ToString();
                string correo = selectedRow.Cells["Correo"].Value.ToString();
                string telefono = selectedRow.Cells["Telefono"].Value.ToString();

                // Set the values to the text boxes
                txtNombre.Text = nombre;
                txtApellido.Text = apellido;
                txtCorreo.Text = correo;
                txtTelefono.Text = telefono;
            }
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Check if a valid row index and column index is clicked
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Get the values from the selected row
                string nombre = selectedRow.Cells["Nombre"].Value.ToString();
                string apellido = selectedRow.Cells["Apellido"].Value.ToString();
                string correo = selectedRow.Cells["Correo"].Value.ToString();
                string telefono = selectedRow.Cells["Telefono"].Value.ToString();

                // Set the values to the text boxes
                txtNombre.Text = nombre;
                txtApellido.Text = apellido;
                txtCorreo.Text = correo;
                txtTelefono.Text = telefono;
            }
        }
    }
}