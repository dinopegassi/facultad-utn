namespace DCCbook1
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
            this.btCrear = new System.Windows.Forms.Button();
            this.tbTamanio = new System.Windows.Forms.TextBox();
            this.lbArreglo = new System.Windows.Forms.ListBox();
            this.lbArregloNuevo = new System.Windows.Forms.ListBox();
            this.btCalcular = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btCrear
            // 
            this.btCrear.Location = new System.Drawing.Point(272, 63);
            this.btCrear.Name = "btCrear";
            this.btCrear.Size = new System.Drawing.Size(75, 23);
            this.btCrear.TabIndex = 0;
            this.btCrear.Text = "Crear";
            this.btCrear.UseVisualStyleBackColor = true;
            this.btCrear.Click += new System.EventHandler(this.btCrear_Click);
            // 
            // tbTamanio
            // 
            this.tbTamanio.Location = new System.Drawing.Point(111, 65);
            this.tbTamanio.Name = "tbTamanio";
            this.tbTamanio.Size = new System.Drawing.Size(100, 20);
            this.tbTamanio.TabIndex = 1;
            // 
            // lbArreglo
            // 
            this.lbArreglo.FormattingEnabled = true;
            this.lbArreglo.Location = new System.Drawing.Point(540, 32);
            this.lbArreglo.Name = "lbArreglo";
            this.lbArreglo.Size = new System.Drawing.Size(120, 95);
            this.lbArreglo.TabIndex = 2;
            // 
            // lbArregloNuevo
            // 
            this.lbArregloNuevo.FormattingEnabled = true;
            this.lbArregloNuevo.Location = new System.Drawing.Point(540, 246);
            this.lbArregloNuevo.Name = "lbArregloNuevo";
            this.lbArregloNuevo.Size = new System.Drawing.Size(120, 95);
            this.lbArregloNuevo.TabIndex = 3;
            // 
            // btCalcular
            // 
            this.btCalcular.Location = new System.Drawing.Point(272, 246);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(75, 23);
            this.btCalcular.TabIndex = 4;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(713, 415);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(75, 23);
            this.btSalir.TabIndex = 5;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.lbArregloNuevo);
            this.Controls.Add(this.lbArreglo);
            this.Controls.Add(this.tbTamanio);
            this.Controls.Add(this.btCrear);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCrear;
        private System.Windows.Forms.TextBox tbTamanio;
        private System.Windows.Forms.ListBox lbArreglo;
        private System.Windows.Forms.ListBox lbArregloNuevo;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Button btSalir;
    }
}

