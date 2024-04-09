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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            frmEstatus estatusCarro = new frmEstatus();
            estatusCarro.Show();
            this.Hide();
        }

        private void btnAdministrador_Click(object sender, EventArgs e)
        {
            frmLoginAdmin loginAdmin = new frmLoginAdmin();
            loginAdmin.Show();
            this.Hide();

        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            frmLoginUsuario loginUsuario = new frmLoginUsuario();   
            loginUsuario.Show();
                this.Hide();
        }
    }
}
