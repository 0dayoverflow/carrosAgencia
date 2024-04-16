using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarrosMVC.Modelo;
using CarrosMVC.Controlador;

namespace CarrosMVC.Vista
{
    public partial class loginAdmin : Form
    {
        private LoginModel loginModel; // Declare an instance of the LoginModel class

        public loginAdmin()
        {
            InitializeComponent();
            loginModel = new LoginModel(); // Instantiate the LoginModel class
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Add your logic here based on the authentication result
            loginController loginController = new loginController();
            bool result = loginController.loginAdmin(txtUser.Text, txtPass.Text);
            if (result == true) {
                MessageBox.Show("Bienvenido Administrador");
                AdminPanel adminPanel = new AdminPanel();
                adminPanel.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
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
