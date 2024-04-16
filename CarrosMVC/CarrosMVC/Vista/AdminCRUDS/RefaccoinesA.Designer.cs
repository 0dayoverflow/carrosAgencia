namespace CarrosMVC.Vista.AdminCRUDS
{
    partial class RefaccoinesA
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
            this.txtActualizarDtg = new System.Windows.Forms.Button();
            this.txtBorrar = new System.Windows.Forms.Button();
            this.txtActualizar = new System.Windows.Forms.Button();
            this.txtLimpiar = new System.Windows.Forms.Button();
            this.txtAgregar = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtActualizarDtg
            // 
            this.txtActualizarDtg.Location = new System.Drawing.Point(413, 244);
            this.txtActualizarDtg.Name = "txtActualizarDtg";
            this.txtActualizarDtg.Size = new System.Drawing.Size(75, 23);
            this.txtActualizarDtg.TabIndex = 43;
            this.txtActualizarDtg.Text = "txtActualizar";
            this.txtActualizarDtg.UseVisualStyleBackColor = true;
            this.txtActualizarDtg.Click += new System.EventHandler(this.txtACtualziar_Click);
            // 
            // txtBorrar
            // 
            this.txtBorrar.Location = new System.Drawing.Point(413, 123);
            this.txtBorrar.Name = "txtBorrar";
            this.txtBorrar.Size = new System.Drawing.Size(75, 63);
            this.txtBorrar.TabIndex = 42;
            this.txtBorrar.Text = "Borrar";
            this.txtBorrar.UseVisualStyleBackColor = true;
            this.txtBorrar.Click += new System.EventHandler(this.txtBorrar_Click);
            // 
            // txtActualizar
            // 
            this.txtActualizar.Location = new System.Drawing.Point(413, 40);
            this.txtActualizar.Name = "txtActualizar";
            this.txtActualizar.Size = new System.Drawing.Size(75, 63);
            this.txtActualizar.TabIndex = 41;
            this.txtActualizar.Text = "Act ualizar ";
            this.txtActualizar.UseVisualStyleBackColor = true;
            this.txtActualizar.Click += new System.EventHandler(this.txtActualizar_Click);
            // 
            // txtLimpiar
            // 
            this.txtLimpiar.Location = new System.Drawing.Point(332, 123);
            this.txtLimpiar.Name = "txtLimpiar";
            this.txtLimpiar.Size = new System.Drawing.Size(75, 63);
            this.txtLimpiar.TabIndex = 40;
            this.txtLimpiar.Text = "Limpiar";
            this.txtLimpiar.UseVisualStyleBackColor = true;
            this.txtLimpiar.Click += new System.EventHandler(this.txtLimpiar_Click);
            // 
            // txtAgregar
            // 
            this.txtAgregar.Location = new System.Drawing.Point(332, 40);
            this.txtAgregar.Name = "txtAgregar";
            this.txtAgregar.Size = new System.Drawing.Size(75, 63);
            this.txtAgregar.TabIndex = 39;
            this.txtAgregar.Text = "Agregar";
            this.txtAgregar.UseVisualStyleBackColor = true;
            this.txtAgregar.Click += new System.EventHandler(this.txtAgregar_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(90, 123);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(194, 20);
            this.txtPrecio.TabIndex = 36;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(90, 77);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(194, 20);
            this.txtNombre.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Precio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Noimbre";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 273);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(471, 150);
            this.dataGridView1.TabIndex = 30;
            // 
            // RefaccoinesA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 450);
            this.Controls.Add(this.txtActualizarDtg);
            this.Controls.Add(this.txtBorrar);
            this.Controls.Add(this.txtActualizar);
            this.Controls.Add(this.txtLimpiar);
            this.Controls.Add(this.txtAgregar);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "RefaccoinesA";
            this.Text = "RefaccoinesA";
            this.Load += new System.EventHandler(this.RefaccoinesA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button txtActualizarDtg;
        private System.Windows.Forms.Button txtBorrar;
        private System.Windows.Forms.Button txtActualizar;
        private System.Windows.Forms.Button txtLimpiar;
        private System.Windows.Forms.Button txtAgregar;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}