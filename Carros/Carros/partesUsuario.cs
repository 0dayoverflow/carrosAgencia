﻿using System;
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
    public partial class partesUsuario : Form
    {
        public partesUsuario()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmLoginUsuario loginUsuario = new frmLoginUsuario();
            loginUsuario.Show();
                 this.Hide();
        }
    }
}