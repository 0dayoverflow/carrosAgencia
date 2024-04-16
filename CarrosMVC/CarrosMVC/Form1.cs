using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarrosMVC.Controlador;
using CarrosMVC.Vista;


namespace CarrosMVC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            //ConexionController conexionController = ConexionController.GetInstance();
            //conexionController.ConnectToDatabase();
            //DataTable dataTable = conexionController.Execu 0teQuery("SELECT * FROM Orders");
            //string randomdata = dataTable.Columns[0].ColumnName;
            //Console.WriteLine(randomdata);

        }//Esto solo era para probar la conexion a la base de datos y verificar que trajera datos

        private void btnAutoDuenio_Click(object sender, EventArgs e)
        {
            DuenioXCarro DxC = new DuenioXCarro();
            DxC.Show();
            this.Hide();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
            Application.Exit();

        }

        private void btnEstatus_Click(object sender, EventArgs e)
        {
            EstatusServicio ES = new EstatusServicio();
            ES.Show();
            this.Hide();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            loginUser LU = new loginUser();
            LU.Show();
            this.Hide();
        }

        private void btnAdministrador_Click(object sender, EventArgs e)
        {
            loginAdmin LA = new loginAdmin();
            LA.Show();
            this.Hide();

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
           Dashboard D = new Dashboard();
            D.Show();
            this.Hide();
        }
    }
}
