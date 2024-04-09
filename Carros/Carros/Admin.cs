using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carros
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmLoginAdmin
                loginAdmin = new frmLoginAdmin();
            loginAdmin.Show();
                this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           carrosAdmin
                carrosAdmin = new carrosAdmin();
            carrosAdmin.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PartesAdmin
                partesAdmin = new PartesAdmin();
            partesAdmin.Show();
                this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ServiciosAdmin
                serviciosAdmin = new ServiciosAdmin();
            serviciosAdmin.Show();
                this.Hide();
        }
    }
}
