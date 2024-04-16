namespace CarrosMVC.Vista
{
    partial class AdminPanel
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
            this.btnPartes = new System.Windows.Forms.Button();
            this.Servicios = new System.Windows.Forms.Button();
            this.btnCarros = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(12, 350);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(639, 58);
            this.btnRegresar.TabIndex = 1;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnPartes
            // 
            this.btnPartes.Location = new System.Drawing.Point(506, 11);
            this.btnPartes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPartes.Name = "btnPartes";
            this.btnPartes.Size = new System.Drawing.Size(145, 241);
            this.btnPartes.TabIndex = 6;
            this.btnPartes.Text = "Partes";
            this.btnPartes.UseVisualStyleBackColor = true;
            this.btnPartes.Click += new System.EventHandler(this.btnPartes_Click);
            // 
            // Servicios
            // 
            this.Servicios.Location = new System.Drawing.Point(343, 11);
            this.Servicios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Servicios.Name = "Servicios";
            this.Servicios.Size = new System.Drawing.Size(145, 241);
            this.Servicios.TabIndex = 5;
            this.Servicios.Text = "Servicios";
            this.Servicios.UseVisualStyleBackColor = true;
            this.Servicios.Click += new System.EventHandler(this.Servicios_Click);
            // 
            // btnCarros
            // 
            this.btnCarros.Location = new System.Drawing.Point(176, 11);
            this.btnCarros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCarros.Name = "btnCarros";
            this.btnCarros.Size = new System.Drawing.Size(145, 241);
            this.btnCarros.TabIndex = 4;
            this.btnCarros.Text = "Carros";
            this.btnCarros.UseVisualStyleBackColor = true;
            this.btnCarros.Click += new System.EventHandler(this.btnCarros_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 272);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(639, 58);
            this.button1.TabIndex = 7;
            this.button1.Text = "Agendar Proxima Cita";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(15, 14);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(145, 241);
            this.btnClientes.TabIndex = 8;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 421);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPartes);
            this.Controls.Add(this.Servicios);
            this.Controls.Add(this.btnCarros);
            this.Controls.Add(this.btnRegresar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnPartes;
        private System.Windows.Forms.Button Servicios;
        private System.Windows.Forms.Button btnCarros;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClientes;
    }
}