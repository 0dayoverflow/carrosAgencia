namespace Carros
{
    partial class Usuario
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
            this.btnServicios = new System.Windows.Forms.Button();
            this.btnPartes = new System.Windows.Forms.Button();
            this.btnCarros = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(127, 162);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(276, 52);
            this.btnRegresar.TabIndex = 7;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnServicios
            // 
            this.btnServicios.Location = new System.Drawing.Point(388, 12);
            this.btnServicios.Name = "btnServicios";
            this.btnServicios.Size = new System.Drawing.Size(140, 106);
            this.btnServicios.TabIndex = 10;
            this.btnServicios.Text = "Servicios";
            this.btnServicios.UseVisualStyleBackColor = true;
            this.btnServicios.Click += new System.EventHandler(this.btnServicios_Click);
            // 
            // btnPartes
            // 
            this.btnPartes.Location = new System.Drawing.Point(200, 12);
            this.btnPartes.Name = "btnPartes";
            this.btnPartes.Size = new System.Drawing.Size(140, 106);
            this.btnPartes.TabIndex = 9;
            this.btnPartes.Text = "Partes";
            this.btnPartes.UseVisualStyleBackColor = true;
            this.btnPartes.Click += new System.EventHandler(this.btnPartes_Click);
            // 
            // btnCarros
            // 
            this.btnCarros.Location = new System.Drawing.Point(27, 12);
            this.btnCarros.Name = "btnCarros";
            this.btnCarros.Size = new System.Drawing.Size(140, 106);
            this.btnCarros.TabIndex = 8;
            this.btnCarros.Text = "Carros";
            this.btnCarros.UseVisualStyleBackColor = true;
            this.btnCarros.Click += new System.EventHandler(this.btnCarros_Click);
            // 
            // Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 254);
            this.Controls.Add(this.btnServicios);
            this.Controls.Add(this.btnPartes);
            this.Controls.Add(this.btnCarros);
            this.Controls.Add(this.btnRegresar);
            this.Name = "Usuario";
            this.Text = "Usuario";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnServicios;
        private System.Windows.Forms.Button btnPartes;
        private System.Windows.Forms.Button btnCarros;
    }
}