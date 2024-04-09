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
    public partial class serviciosUsuario : Form
    {

        private ConexionBD conexionBD;
        public serviciosUsuario()
        {
            InitializeComponent();
            conexionBD = ConexionBD.GetInstance();
        }

        private void serviciosUsuario_Load(object sender, EventArgs e)
        {
            //this.servicesTableAdapter.Fill(this.carMaintenanceDataSet.Services);
            try
            {
                SqlConnection connection = conexionBD.ConectarBD();
                if (connection!=null) {
                    string query = "SELECT Customers.FirstName, Customers.LastName, Cars.CarID, Cars.Make,Cars.Year,Services.ServiceID FROM CustomerCar INNER JOIN Customers ON CustomerCar.CustomerID = Customers.CustomerID INNER JOIN Cars ON CustomerCar.CarID = Cars.CarID INNER JOIN    PartService ON Customers.CustomerID = PartService.ServiceID INNER JOIN Services ON PartService.ServiceID = Services.ServiceID";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmLoginUsuario loginUsuario = new frmLoginUsuario();
                loginUsuario.Show();
                this.Hide();

        }

        //solo falta hacer agregar lo del video para buscar en chinga,  se puede copiar  todo esto 
    }
}
