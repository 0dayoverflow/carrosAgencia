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
    public partial class RefaccoinesA : Form
    {
        private ConexionController conexionController;

        public RefaccoinesA()
        {
            InitializeComponent();
            conexionController = ConexionController.GetInstance();
        }

        private void txtACtualziar_Click(object sender, EventArgs e)
        {
            try
            {
                conexionController.ConnectToDatabase();

                string query = "SELECT * FROM Refacciones";
                DataTable result = conexionController.ExecuteQuery(query);

                dataGridView1.DataSource = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar los datos: " + ex.Message);
            }
            finally
            {
                conexionController.DisconnectFromDatabase();
            }
        }

        private void txtBorrar_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int id = Convert.ToInt32(selectedRow.Cells["IdRefaccion"].Value);

                try
                {
                    conexionController.ConnectToDatabase();

                    string query = $"DELETE FROM Refacciones WHERE IdRefaccion = {id}";
                    conexionController.ExecuteQuery(query);

                    MessageBox.Show("Datos eliminados correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar los datos: " + ex.Message);
                }
                finally
                {
                    conexionController.DisconnectFromDatabase();
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila para eliminar.");
                return;
            }
            // Rest of the code to delete the data
        }

        private void txtActualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPrecio.Text) || string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Los campos no pueden estar vacíos.");
                return;
            }

            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int id = Convert.ToInt32(selectedRow.Cells["IdRefaccion"].Value);

                try
                {
                    conexionController.ConnectToDatabase();

                    string query = $"UPDATE Refacciones SET Precio = '{txtPrecio.Text}', Nombre = '{txtNombre.Text}' WHERE IdRefaccion = {id}";
                    conexionController.ExecuteQuery(query);

                    MessageBox.Show("Datos actualizados correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar los datos: " + ex.Message);
                }
                finally
                {
                    conexionController.DisconnectFromDatabase();
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila para actualizar.");
                return;
            }
        }

        private void txtLimpiar_Click(object sender, EventArgs e)
        {
            txtPrecio.Text = string.Empty;
            txtNombre.Text = string.Empty;
        }

        private void txtAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPrecio.Text) || string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Los campos no pueden estar vacíos.");
                return;
            }

            try
            {
                conexionController.ConnectToDatabase();

                string query = $"INSERT INTO Refacciones (Precio, Nombre) VALUES ('{txtPrecio.Text}', '{txtNombre.Text}')";
                conexionController.ExecuteQuery(query);

                MessageBox.Show("Datos agregados correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar los datos: " + ex.Message);
            }
            finally
            {
                conexionController.DisconnectFromDatabase();
            }
        }

        private void RefaccoinesA_Load(object sender, EventArgs e)
        {
            try
            {
                conexionController.ConnectToDatabase();

                string query = "SELECT * FROM Refacciones";
                DataTable result = conexionController.ExecuteQuery(query);

                dataGridView1.DataSource = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
            finally
            {
                conexionController.DisconnectFromDatabase();
            }
        }
    }
}
