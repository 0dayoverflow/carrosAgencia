using CarrosMVC.Vista.AdminCRUDS;
using CarrosMVC.Vista.UserViews;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarrosMVC.Vista
{
    public partial class UserPanel : Form
    {
        public UserPanel()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            loginUser login = new loginUser();login.Show();this.Hide();
        }

        private void Servicios_Click(object sender, EventArgs e)
        {
            ServicioU servicioU = new ServicioU();servicioU.Show();this.Hide();
        }

        private void btnPartes_Click(object sender, EventArgs e)
        {
            RefaccionesU refaccionesU = new RefaccionesU();refaccionesU.Show();this.Hide();
        }

        private void btnCarros_Click(object sender, EventArgs e)
        {
            CarroU carroU = new CarroU();carroU.Show();this.Hide();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            ClienteU clienteU = new ClienteU();clienteU.Show();this.Hide();
        }
    }
}
