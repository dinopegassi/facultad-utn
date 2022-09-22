namespace Prog2Guia1Ej1
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
            this.lbNros = new System.Windows.Forms.ListBox();
            this.labLista = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.gbOrdenar = new System.Windows.Forms.GroupBox();
            this.rbAscendente = new System.Windows.Forms.RadioButton();
            this.rbDescendente = new System.Windows.Forms.RadioButton();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.labNro = new System.Windows.Forms.Label();
            this.TextoAbuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gbOrdenar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNros
            // 
            this.lbNros.FormattingEnabled = true;
            this.lbNros.Location = new System.Drawing.Point(29, 47);
            this.lbNros.Name = "lbNros";
            this.lbNros.Size = new System.Drawing.Size(120, 95);
            this.lbNros.TabIndex = 0;
            // 
            // labLista
            // 
            this.labLista.AutoSize = true;
            this.labLista.Location = new System.Drawing.Point(29, 13);
            this.labLista.Name = "labLista";
            this.labLista.Size = new System.Drawing.Size(29, 13);
            this.labLista.TabIndex = 1;
            this.labLista.Text = "Lista";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(488, 12);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // gbOrdenar
            // 
            this.gbOrdenar.Controls.Add(this.btnAceptar);
            this.gbOrdenar.Controls.Add(this.rbDescendente);
            this.gbOrdenar.Controls.Add(this.rbAscendente);
            this.gbOrdenar.Location = new System.Drawing.Point(469, 56);
            this.gbOrdenar.Name = "gbOrdenar";
            this.gbOrdenar.Size = new System.Drawing.Size(200, 100);
            this.gbOrdenar.TabIndex = 3;
            this.gbOrdenar.TabStop = false;
            this.gbOrdenar.Text = "Ordenar";
            // 
            // rbAscendente
            // 
            this.rbAscendente.AutoSize = true;
            this.rbAscendente.Location = new System.Drawing.Point(9, 16);
            this.rbAscendente.Name = "rbAscendente";
            this.rbAscendente.Size = new System.Drawing.Size(82, 17);
            this.rbAscendente.TabIndex = 0;
            this.rbAscendente.TabStop = true;
            this.rbAscendente.Text = "Ascendente";
            this.rbAscendente.UseVisualStyleBackColor = true;
            // 
            // rbDescendente
            // 
            this.rbDescendente.AutoSize = true;
            this.rbDescendente.Location = new System.Drawing.Point(9, 39);
            this.rbDescendente.Name = "rbDescendente";
            this.rbDescendente.Size = new System.Drawing.Size(89, 17);
            this.rbDescendente.TabIndex = 1;
            this.rbDescendente.TabStop = true;
            this.rbDescendente.Text = "Descendente";
            this.rbDescendente.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(59, 62);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // labNro
            // 
            this.labNro.AutoSize = true;
            this.labNro.Location = new System.Drawing.Point(485, 199);
            this.labNro.Name = "labNro";
            this.labNro.Size = new System.Drawing.Size(24, 13);
            this.labNro.TabIndex = 4;
            this.labNro.Text = "Nro";
            // 
            // TextoAbuscar
            // 
            this.TextoAbuscar.Location = new System.Drawing.Point(569, 196);
            this.TextoAbuscar.Name = "TextoAbuscar";
            this.TextoAbuscar.Size = new System.Drawing.Size(100, 20);
            this.TextoAbuscar.TabIndex = 5;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(488, 233);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.TextoAbuscar);
            this.Controls.Add(this.labNro);
            this.Controls.Add(this.gbOrdenar);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.labLista);
            this.Controls.Add(this.lbNros);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbOrdenar.ResumeLayout(false);
            this.gbOrdenar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbNros;
        private System.Windows.Forms.Label labLista;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.GroupBox gbOrdenar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.RadioButton rbDescendente;
        private System.Windows.Forms.RadioButton rbAscendente;
        private System.Windows.Forms.Label labNro;
        private System.Windows.Forms.TextBox TextoAbuscar;
        private System.Windows.Forms.Button btnBuscar;
    }
}

