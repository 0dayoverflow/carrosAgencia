namespace CarrosMVC.Vista
{
    partial class UserPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnCarros = new System.Windows.Forms.Button();
            this.btnPartes = new System.Windows.Forms.Button();
            this.Servicios = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(9, 235);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(530, 39);
            this.btnRegresar.TabIndex = 0;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnCarros
            // 
            this.btnCarros.Location = new System.Drawing.Point(9, 20);
            this.btnCarros.Margin = new System.Windows.Forms.Padding(2);
            this.btnCarros.Name = "btnCarros";
            this.btnCarros.Size = new System.Drawing.Size(109, 196);
            this.btnCarros.TabIndex = 1;
            this.btnCarros.Text = "Carros";
            this.btnCarros.UseVisualStyleBackColor = true;
            this.btnCarros.Click += new System.EventHandler(this.btnCarros_Click);
            // 
            // btnPartes
            // 
            this.btnPartes.Location = new System.Drawing.Point(430, 20);
            this.btnPartes.Margin = new System.Windows.Forms.Padding(2);
            this.btnPartes.Name = "btnPartes";
            this.btnPartes.Size = new System.Drawing.Size(109, 196);
            this.btnPartes.TabIndex = 3;
            this.btnPartes.Text = "Partes";
            this.btnPartes.UseVisualStyleBackColor = true;
            this.btnPartes.Click += new System.EventHandler(this.btnPartes_Click);
            // 
            // Servicios
            // 
            this.Servicios.Location = new System.Drawing.Point(288, 20);
            this.Servicios.Margin = new System.Windows.Forms.Padding(2);
            this.Servicios.Name = "Servicios";
            this.Servicios.Size = new System.Drawing.Size(109, 196);
            this.Servicios.TabIndex = 2;
            this.Servicios.Text = "Servicios";
            this.Servicios.UseVisualStyleBackColor = true;
            this.Servicios.Click += new System.EventHandler(this.Servicios_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(143, 20);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(2);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(109, 196);
            this.btnClientes.TabIndex = 4;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // UserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 289);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnPartes);
            this.Controls.Add(this.Servicios);
            this.Controls.Add(this.btnCarros);
            this.Controls.Add(this.btnRegresar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserPanel";
            this.Text = "UserPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnCarros;
        private System.Windows.Forms.Button btnPartes;
        private System.Windows.Forms.Button Servicios;
        private System.Windows.Forms.Button btnClientes;
    }
}