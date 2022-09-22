namespace ejercicio1
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
            this.bNuevo = new System.Windows.Forms.Button();
            this.bCargar = new System.Windows.Forms.Button();
            this.bResumen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lTiempo = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tBvueltas = new System.Windows.Forms.TextBox();
            this.tBtiempo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bNuevo
            // 
            this.bNuevo.Location = new System.Drawing.Point(184, 22);
            this.bNuevo.Name = "bNuevo";
            this.bNuevo.Size = new System.Drawing.Size(62, 23);
            this.bNuevo.TabIndex = 0;
            this.bNuevo.Text = "Nuevo";
            this.bNuevo.UseVisualStyleBackColor = true;
            this.bNuevo.Click += new System.EventHandler(this.bNuevo_Click);
            // 
            // bCargar
            // 
            this.bCargar.Enabled = false;
            this.bCargar.Location = new System.Drawing.Point(184, 65);
            this.bCargar.Name = "bCargar";
            this.bCargar.Size = new System.Drawing.Size(62, 23);
            this.bCargar.TabIndex = 1;
            this.bCargar.Text = "Cargar";
            this.bCargar.UseVisualStyleBackColor = true;
            this.bCargar.Click += new System.EventHandler(this.bCargar_Click);
            // 
            // bResumen
            // 
            this.bResumen.Location = new System.Drawing.Point(12, 112);
            this.bResumen.Name = "bResumen";
            this.bResumen.Size = new System.Drawing.Size(62, 23);
            this.bResumen.TabIndex = 2;
            this.bResumen.Text = "Resumen";
            this.bResumen.UseVisualStyleBackColor = true;
            this.bResumen.Click += new System.EventHandler(this.bResumen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cantidad de vueltas";
            // 
            // lTiempo
            // 
            this.lTiempo.AutoSize = true;
            this.lTiempo.Location = new System.Drawing.Point(23, 70);
            this.lTiempo.Name = "lTiempo";
            this.lTiempo.Size = new System.Drawing.Size(45, 13);
            this.lTiempo.TabIndex = 4;
            this.lTiempo.Text = "Tiempo:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(82, 112);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(164, 95);
            this.listBox1.TabIndex = 5;
            // 
            // tBvueltas
            // 
            this.tBvueltas.Location = new System.Drawing.Point(119, 25);
            this.tBvueltas.Name = "tBvueltas";
            this.tBvueltas.Size = new System.Drawing.Size(48, 20);
            this.tBvueltas.TabIndex = 6;
            this.tBvueltas.Text = "tBvueltas";
            // 
            // tBtiempo
            // 
            this.tBtiempo.Location = new System.Drawing.Point(97, 67);
            this.tBtiempo.Name = "tBtiempo";
            this.tBtiempo.Size = new System.Drawing.Size(70, 20);
            this.tBtiempo.TabIndex = 7;
            this.tBtiempo.Text = "tBtiempo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 228);
            this.Controls.Add(this.tBtiempo);
            this.Controls.Add(this.tBvueltas);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lTiempo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bResumen);
            this.Controls.Add(this.bCargar);
            this.Controls.Add(this.bNuevo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bNuevo;
        private System.Windows.Forms.Button bCargar;
        private System.Windows.Forms.Button bResumen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lTiempo;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox tBvueltas;
        private System.Windows.Forms.TextBox tBtiempo;
    }
}

