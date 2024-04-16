using CarrosMVC.Controlador;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace CarrosMVC.Vista
{
    public partial class Dashboard : Form
    {
        private ConexionController conexionController;

        public Dashboard()
        {
            InitializeComponent();
            conexionController = ConexionController.GetInstance();

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ConexionController conexionController = ConexionController.GetInstance();
            try
            {
                conexionController.ConnectToDatabase();
                string queryFinalizado = "SELECT COUNT(*) FROM Servicio WHERE Estatus='Finalizado';";
                string queryEnEspera = "SELECT COUNT(*) FROM Servicio WHERE Estatus='En Espera';";
                string queryEnProceso = "SELECT COUNT(*) FROM Servicio WHERE Estatus='En Proceso';";
                DataTable resultFinalizado = conexionController.ExecuteQuery(queryFinalizado);
                DataTable resultEnEspera = conexionController.ExecuteQuery(queryEnEspera);
                DataTable resultEnProceso = conexionController.ExecuteQuery(queryEnProceso);

                // Create a new chart series
                Series series = new Series();
                series.ChartType = SeriesChartType.Pie;

                // Add data points to the series
                series.Points.AddXY("Finalizado", resultFinalizado.Rows[0][0]);
                series.Points.AddXY("En Espera", resultEnEspera.Rows[0][0]);
                series.Points.AddXY("En Proceso", resultEnProceso.Rows[0][0]);

                // Clear existing series in the chart
                chart1.Series.Clear();

                // Add the new series to the chart
                chart1.Series.Add(series);

                txtE.Text = resultEnEspera.Rows[0][0].ToString();
                txtF.Text = resultFinalizado.Rows[0][0].ToString();
                txtP.Text = resultEnProceso.Rows[0][0].ToString();


            }
            catch (Exception ex)
            {
                // Handle the exception here
                MessageBox.Show("Error al obtener los datos de la base de datos: " + ex.Message);
            }
            finally
            {
                conexionController.DisconnectFromDatabase();
            }

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();   //F1 lol
            f1.Show();
            this.Hide();

                
        }
    }
}
