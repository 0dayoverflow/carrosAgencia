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
    public partial class frmEstatus : Form
    {
        private ConexionBD conexionBD;

        public frmEstatus()
        {
            InitializeComponent();
            conexionBD = ConexionBD.GetInstance();
        }

        private void frmEstatus_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = conexionBD.ConectarBD();
                if (connection != null)
                {
                    string query = "SELECT Customers.FirstName,Customers.LastName,Cars.Make,Cars.Model,Services.ServiceType,Services.ServiceDate FROM  Customers JOIN CustomerCar ON Customers.CustomerID = CustomerCar.CustomerID JOIN Cars ON CustomerCar.CarID = Cars.CarID JOIN Services ON Cars.CarID = Services.CarID;";
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
            Form1 form1 = new Form1();
                form1.Show();
            this.Hide();
        }
    }
}
