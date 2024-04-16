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

namespace CarrosMVC.Vista
{
    public partial class loginUser : Form
    {
        public loginUser()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form1 form1
                = new Form1();
            form1.Show();
            this.Close();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            loginController loginController = new loginController();
            bool result = loginController.loginUser(txtUser.Text, txtPass.Text);
            if (result == true)
            {
                MessageBox.Show("Bienvenido Usuario");
                UserPanel userPanel = new UserPanel();  
                userPanel.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos. \t Intente de Nuevo. ");
            }

        }
    }
}
