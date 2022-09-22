namespace ejercicio2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tBnumero = new System.Windows.Forms.TextBox();
            this.bVer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tBnombre = new System.Windows.Forms.TextBox();
            this.bAgregar = new System.Windows.Forms.Button();
            this.bSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número:";
            // 
            // tBnumero
            // 
            this.tBnumero.Location = new System.Drawing.Point(62, 16);
            this.tBnumero.Name = "tBnumero";
            this.tBnumero.Size = new System.Drawing.Size(49, 20);
            this.tBnumero.TabIndex = 1;
            this.tBnumero.Text = "tBnumero";
            // 
            // bVer
            // 
            this.bVer.Location = new System.Drawing.Point(126, 14);
            this.bVer.Name = "bVer";
            this.bVer.Size = new System.Drawing.Size(73, 23);
            this.bVer.TabIndex = 2;
            this.bVer.Text = "Ver";
            this.bVer.UseVisualStyleBackColor = true;
            this.bVer.Click += new System.EventHandler(this.bVer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre:";
            // 
            // tBnombre
            // 
            this.tBnombre.Location = new System.Drawing.Point(61, 52);
            this.tBnombre.Name = "tBnombre";
            this.tBnombre.Size = new System.Drawing.Size(138, 20);
            this.tBnombre.TabIndex = 4;
            this.tBnombre.Text = "tBnombre";
            // 
            // bAgregar
            // 
            this.bAgregar.Location = new System.Drawing.Point(14, 90);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(75, 23);
            this.bAgregar.TabIndex = 5;
            this.bAgregar.Text = "Agregar";
            this.bAgregar.UseVisualStyleBackColor = true;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // bSalir
            // 
            this.bSalir.Location = new System.Drawing.Point(123, 90);
            this.bSalir.Name = "bSalir";
            this.bSalir.Size = new System.Drawing.Size(75, 23);
            this.bSalir.TabIndex = 6;
            this.bSalir.Text = "Salir";
            this.bSalir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 125);
            this.Controls.Add(this.bSalir);
            this.Controls.Add(this.bAgregar);
            this.Controls.Add(this.tBnombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bVer);
            this.Controls.Add(this.tBnumero);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Jugadores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBnumero;
        private System.Windows.Forms.Button bVer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBnombre;
        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.Button bSalir;
    }
}

