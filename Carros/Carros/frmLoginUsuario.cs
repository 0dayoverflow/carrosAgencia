using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carros
{
    public partial class frmLoginUsuario : Form
    {
        public frmLoginUsuario()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuarios = txtUser.Text;
            string pass = txtPass.Text;
            // Obtén la instancia de la conexión
            ConexionBD conexion = ConexionBD.GetInstance();

            // Abre la conexión
            SqlConnection connection = conexion.ConectarBD();

            if (connection != null)
            {
                // Define la consulta SQL
                string query = "SELECT * FROM Login WHERE Nombre ='" + usuarios + "' AND Clave ='" + pass + "' AND Nivel ='Employee';";

                // Crea el comando SQL
                SqlCommand command = new SqlCommand(query, connection);

                // Ejecuta el comando y obtén los resultados
                SqlDataReader reader = command.ExecuteReader();

                // Verifica si se encontró un usuario
                if (reader.HasRows)
                {
                    // El usuario y la contraseña son correctos
                    Usuario usuario = new Usuario();
                    usuario.Show();
                    this.Hide();

       

                }
                else
                {
                    // El usuario o la contraseña son incorrectos
                    MessageBox.Show("Usuario o contraseña incorrectos");
                }

                // Cierra el lector y la conexión
                reader.Close();
                connection.Close();
            }
            else
            {
                // Hubo un problema al conectar a la base de datos
                MessageBox.Show("No se pudo conectar a la base de datos");
            }

        }
    }
}
