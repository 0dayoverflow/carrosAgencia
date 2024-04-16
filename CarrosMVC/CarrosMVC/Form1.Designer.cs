namespace CarrosMVC
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEstatus = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.btnAutoDuenio = new System.Windows.Forms.Button();
            this.btnAdministrador = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(43, 430);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(716, 69);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEstatus
            // 
            this.btnEstatus.Location = new System.Drawing.Point(43, 354);
            this.btnEstatus.Margin = new System.Windows.Forms.Padding(4);
            this.btnEstatus.Name = "btnEstatus";
            this.btnEstatus.Size = new System.Drawing.Size(716, 69);
            this.btnEstatus.TabIndex = 13;
            this.btnEstatus.Text = "Estatus Autos";
            this.btnEstatus.UseVisualStyleBackColor = true;
            this.btnEstatus.Click += new System.EventHandler(this.btnEstatus_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.Location = new System.Drawing.Point(537, 39);
            this.btnUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(221, 202);
            this.btnUsuario.TabIndex = 12;
            this.btnUsuario.Text = "Usuarios";
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // btnAutoDuenio
            // 
            this.btnAutoDuenio.Location = new System.Drawing.Point(287, 39);
            this.btnAutoDuenio.Margin = new System.Windows.Forms.Padding(4);
            this.btnAutoDuenio.Name = "btnAutoDuenio";
            this.btnAutoDuenio.Size = new System.Drawing.Size(221, 202);
            this.btnAutoDuenio.TabIndex = 11;
            this.btnAutoDuenio.Text = "Auto\r\nY\r\nDueño\r\n";
            this.btnAutoDuenio.UseVisualStyleBackColor = true;
            this.btnAutoDuenio.Click += new System.EventHandler(this.btnAutoDuenio_Click);
            // 
            // btnAdministrador
            // 
            this.btnAdministrador.Location = new System.Drawing.Point(43, 39);
            this.btnAdministrador.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdministrador.Name = "btnAdministrador";
            this.btnAdministrador.Size = new System.Drawing.Size(221, 202);
            this.btnAdministrador.TabIndex = 10;
            this.btnAdministrador.Text = "Administrador";
            this.btnAdministrador.UseVisualStyleBackColor = true;
            this.btnAdministrador.Click += new System.EventHandler(this.btnAdministrador_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Location = new System.Drawing.Point(43, 277);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(4);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(716, 69);
            this.btnDashboard.TabIndex = 15;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 509);
            this.Controls.Add(this.btnDashboard);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEstatus);
            this.Controls.Add(this.btnUsuario);
            this.Controls.Add(this.btnAutoDuenio);
            this.Controls.Add(this.btnAdministrador);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Salir";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEstatus;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Button btnAutoDuenio;
        private System.Windows.Forms.Button btnAdministrador;
        private System.Windows.Forms.Button btnDashboard;
    }
}

