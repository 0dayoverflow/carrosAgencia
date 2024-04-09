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
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmLoginUsuario loginUsuario = new frmLoginUsuario();
            loginUsuario.Show();
            this.Hide();
        }

        private void btnPartes_Click(object sender, EventArgs e)
        {
            partesUsuario partesUsuario = new partesUsuario();
            partesUsuario.Show();
            this.Hide();
        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            serviciosUsuario serviciosUsuario = new serviciosUsuario();
            serviciosUsuario.Show();
            this.Hide();

        }

        private void btnCarros_Click(object sender, EventArgs e)
        {
            serviciosUsuario serviciosUsuario = new serviciosUsuario();
            serviciosUsuario.Show();
                this.Hide();
        }
    }
}
