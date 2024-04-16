using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarrosMVC.Vista.AdminCRUDS;


namespace CarrosMVC.Vista
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            loginAdmin login = new loginAdmin();
            login.Show();
            this.Hide();
        }

        private void btnCarros_Click(object sender, EventArgs e)
        {
            CarrosA carrosA = new CarrosA();    
            carrosA.Show();
            this.Hide();
        }

        private void Servicios_Click(object sender, EventArgs e)
        {
            ServicioA serviciosA = new ServicioA();
            serviciosA.Show();
            this.Hide();
        }

        private void btnPartes_Click(object sender, EventArgs e)
        {
            RefaccoinesA refaccoinesA = new RefaccoinesA();
            refaccoinesA.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProximaCita proximaCita = new ProximaCita();
            proximaCita.Show();
                this.Hide();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            UsuarioA usuarioA = new UsuarioA();
            usuarioA.Show();
            this.Hide();
        }
    }
}
