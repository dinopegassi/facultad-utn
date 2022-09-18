namespace Clase25
{
    partial class Form1
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
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.tbTamanio = new System.Windows.Forms.TextBox();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gbVisualizacion = new System.Windows.Forms.GroupBox();
            this.lvVisualizacion = new System.Windows.Forms.ListView();
            this.TipoDatos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tamanio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BusquedaCol1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BusquedaCol2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BusquedaCol4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BusquedaFallida = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Promedio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gb1.SuspendLayout();
            this.gbVisualizacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.btnCrear);
            this.gb1.Controls.Add(this.tbTamanio);
            this.gb1.Controls.Add(this.cbTipo);
            this.gb1.Controls.Add(this.label2);
            this.gb1.Controls.Add(this.label1);
            this.gb1.Location = new System.Drawing.Point(12, 12);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(776, 109);
            this.gb1.TabIndex = 1;
            this.gb1.TabStop = false;
            this.gb1.Text = "Ingreso de Datos";
            // 
            // tbTamanio
            // 
            this.tbTamanio.Location = new System.Drawing.Point(166, 63);
            this.tbTamanio.Name = "tbTamanio";
            this.tbTamanio.Size = new System.Drawing.Size(100, 20);
            this.tbTamanio.TabIndex = 4;
            // 
            // cbTipo
            // 
            this.cbTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Byte",
            "Int 32",
            "Float",
            "Decimal",
            "String"});
            this.cbTipo.Location = new System.Drawing.Point(10, 63);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(94, 21);
            this.cbTipo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tamaño del Vector";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de Datos";
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(371, 49);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 5;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Enabled = false;
            this.btnBuscar.Location = new System.Drawing.Point(13, 128);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar Valor";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // gbVisualizacion
            // 
            this.gbVisualizacion.Controls.Add(this.lvVisualizacion);
            this.gbVisualizacion.Location = new System.Drawing.Point(13, 157);
            this.gbVisualizacion.Name = "gbVisualizacion";
            this.gbVisualizacion.Size = new System.Drawing.Size(775, 281);
            this.gbVisualizacion.TabIndex = 3;
            this.gbVisualizacion.TabStop = false;
            this.gbVisualizacion.Text = "Visualizacion";
            // 
            // lvVisualizacion
            // 
            this.lvVisualizacion.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TipoDatos,
            this.Tamanio,
            this.BusquedaCol1,
            this.BusquedaCol2,
            this.BusquedaCol4,
            this.BusquedaFallida,
            this.Promedio});
            this.lvVisualizacion.HideSelection = false;
            this.lvVisualizacion.Location = new System.Drawing.Point(9, 20);
            this.lvVisualizacion.Name = "lvVisualizacion";
            this.lvVisualizacion.Size = new System.Drawing.Size(760, 255);
            this.lvVisualizacion.TabIndex = 0;
            this.lvVisualizacion.UseCompatibleStateImageBehavior = false;
            this.lvVisualizacion.View = System.Windows.Forms.View.Details;
            // 
            // TipoDatos
            // 
            this.TipoDatos.Text = "Tipo de Datos";
            this.TipoDatos.Width = 110;
            // 
            // Tamanio
            // 
            this.Tamanio.Text = "Tamaño";
            this.Tamanio.Width = 110;
            // 
            // BusquedaCol1
            // 
            this.BusquedaCol1.Text = "Columna 1";
            this.BusquedaCol1.Width = 110;
            // 
            // BusquedaCol2
            // 
            this.BusquedaCol2.Text = "Columna 2";
            this.BusquedaCol2.Width = 110;
            // 
            // BusquedaCol4
            // 
            this.BusquedaCol4.Text = "Columna 4";
            this.BusquedaCol4.Width = 110;
            // 
            // BusquedaFallida
            // 
            this.BusquedaFallida.Text = "Fallida";
            this.BusquedaFallida.Width = 110;
            // 
            // Promedio
            // 
            this.Promedio.Text = "Promedio";
            this.Promedio.Width = 110;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbVisualizacion);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.gb1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.gbVisualizacion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb1;
        public System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTamanio;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox gbVisualizacion;
        private System.Windows.Forms.ListView lvVisualizacion;
        private System.Windows.Forms.ColumnHeader TipoDatos;
        private System.Windows.Forms.ColumnHeader Tamanio;
        private System.Windows.Forms.ColumnHeader BusquedaCol1;
        private System.Windows.Forms.ColumnHeader BusquedaCol2;
        private System.Windows.Forms.ColumnHeader BusquedaCol4;
        private System.Windows.Forms.ColumnHeader BusquedaFallida;
        private System.Windows.Forms.ColumnHeader Promedio;
    }
}