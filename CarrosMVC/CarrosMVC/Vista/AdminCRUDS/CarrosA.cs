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
    public partial class CarrosA : Form
    {
        private ConexionController conexionController;

        public CarrosA()
        {
            InitializeComponent();
            conexionController = ConexionController.GetInstance();
        }

        private void CarrosA_Load(object sender, EventArgs e)
        {
            try
            {
                conexionController.ConnectToDatabase();

                string queryCarro = "SELECT * FROM Carro";
                DataTable resultCarro = conexionController.ExecuteQuery(queryCarro);
                dataGridView1.DataSource = resultCarro;

                string queryRefaccion = "SELECT * FROM Refacciones";
                DataTable resultRefaccion = conexionController.ExecuteQuery(queryRefaccion);
                dataGridView2.DataSource = resultRefaccion;

                string queryServicio = "SELECT * FROM Servicio";
                DataTable resultServicio = conexionController.ExecuteQuery(queryServicio);
                dataGridView3.DataSource = resultServicio;

                string queryCliente = "SELECT * FROM Cliente";
                DataTable resultCliente = conexionController.ExecuteQuery(queryCliente);
                dataGridView4.DataSource = resultCliente;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexionController.DisconnectFromDatabase();
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtAnio.Text == "" || txtIdRefaccion.Text == "" || txtMarca.Text == "" || txtModelo.Text == "" || txtIdCliente.Text == "" || txtIdServicio.Text == "")
            {
                MessageBox.Show("Todos los campos deben tener un valor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                conexionController.ConnectToDatabase();

                string marca = txtMarca.Text;
                string modelo = txtModelo.Text;
                int anio = int.Parse(txtAnio.Text);
                int idCliente = int.Parse(txtIdCliente.Text);
                int idRefaccion = int.Parse(txtIdRefaccion.Text);
                int idServicio = int.Parse(txtIdServicio.Text);

                string insertQuery = $"INSERT INTO Carro (Marca, Modelo, Anio, IdCliente, IdRefaccion, IdServicio) VALUES ('{marca}', '{modelo}', {anio}, {idCliente}, {idRefaccion}, {idServicio})";
                conexionController.ExecuteQuery(insertQuery);

                MessageBox.Show("Registro creado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexionController.DisconnectFromDatabase();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtAnio.Text == "" || txtIdRefaccion.Text == "" || txtMarca.Text == "" || txtModelo.Text == "" || txtIdCliente.Text == "" || txtIdServicio.Text == "")
            {
                MessageBox.Show("Todos los campos deben tener un valor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Obtener la fila seleccionada del DataGridView 1
                DataGridViewRow selectedRow = dataGridView1.CurrentRow;

                // Verificar si hay una fila seleccionada
                if (selectedRow != null)
                {
                    // Obtener el valor de la columna "IdCarro" de la fila seleccionada
                    int idCarro = Convert.ToInt32(selectedRow.Cells["IdCarro"].Value);

                    // Resto del código...
                    conexionController.ConnectToDatabase();

                    string marca = txtMarca.Text;
                    string modelo = txtModelo.Text;
                    int anio = int.Parse(txtAnio.Text);
                    int idCliente = int.Parse(txtIdCliente.Text);
                    int idRefaccion = int.Parse(txtIdRefaccion.Text);
                    int idServicio = int.Parse(txtIdServicio.Text);

                    string updateQuery = $"UPDATE Carro SET Marca = '{marca}', Modelo = '{modelo}', Anio = {anio}, IdCliente = {idCliente}, IdRefaccion = {idRefaccion}, IdServicio = {idServicio} WHERE IdCarro = {idCarro}";
                    conexionController.ExecuteQuery(updateQuery);
                    MessageBox.Show("Registro actualizado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se ha seleccionado ninguna fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al borrar el registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexionController.DisconnectFromDatabase();
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtAnio.Text = "";
            txtIdRefaccion.Text = "";
            txtMarca.Text = "";
            txtModelo.Text = "";
            txtIdCliente.Text = "";
            txtIdServicio.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener la fila seleccionada del DataGridView 1
                DataGridViewRow selectedRow = dataGridView1.CurrentRow;

                // Verificar si hay una fila seleccionada
                if (selectedRow != null)
                {
                    // Obtener el valor de la columna "IdCarro" de la fila seleccionada
                    int idCarro = Convert.ToInt32(selectedRow.Cells["IdCarro"].Value);


                    // Resto del código...
                    conexionController.ConnectToDatabase();
                    string deleteQuery = $"DELETE FROM Carro WHERE IdCarro = {idCarro}";
                    conexionController.ExecuteQuery(deleteQuery);
                    MessageBox.Show("Registro eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("No se ha seleccionado ninguna fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al borrar el registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexionController.DisconnectFromDatabase();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conexionController.ConnectToDatabase();

                string queryCarro = "SELECT * FROM Carro";
                DataTable resultCarro = conexionController.ExecuteQuery(queryCarro);
                dataGridView1.DataSource = resultCarro;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexionController.DisconnectFromDatabase();
            }
        }
    }
}
