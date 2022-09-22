namespace WindowsFormsApp3
{
    partial class Form2
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
            this.gbContenedor = new System.Windows.Forms.GroupBox();
            this.labHora = new System.Windows.Forms.Label();
            this.numUDMinutos = new System.Windows.Forms.NumericUpDown();
            this.numUDHoras = new System.Windows.Forms.NumericUpDown();
            this.numUDCargaMaxima = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.gbTipoEnvio = new System.Windows.Forms.GroupBox();
            this.rbtnExpress = new System.Windows.Forms.RadioButton();
            this.rbtnFull = new System.Windows.Forms.RadioButton();
            this.gbPaquetes = new System.Windows.Forms.GroupBox();
            this.numUDB = new System.Windows.Forms.NumericUpDown();
            this.numUDC = new System.Windows.Forms.NumericUpDown();
            this.numUDA = new System.Windows.Forms.NumericUpDown();
            this.cbC = new System.Windows.Forms.CheckBox();
            this.cbB = new System.Windows.Forms.CheckBox();
            this.cbA = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnVerInfo = new System.Windows.Forms.Button();
            this.btnTicket = new System.Windows.Forms.Button();
            this.cbDomingoFeriado = new System.Windows.Forms.CheckBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbFechaHora = new System.Windows.Forms.GroupBox();
            this.gbContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDMinutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDHoras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDCargaMaxima)).BeginInit();
            this.gbTipoEnvio.SuspendLayout();
            this.gbPaquetes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDA)).BeginInit();
            this.gbFechaHora.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbContenedor
            // 
            this.gbContenedor.Controls.Add(this.btnCancelar);
            this.gbContenedor.Controls.Add(this.btnAceptar);
            this.gbContenedor.Controls.Add(this.numUDCargaMaxima);
            this.gbContenedor.Controls.Add(this.label2);
            this.gbContenedor.Controls.Add(this.label5);
            this.gbContenedor.Controls.Add(this.textBox5);
            this.gbContenedor.Controls.Add(this.gbTipoEnvio);
            this.gbContenedor.Location = new System.Drawing.Point(12, 12);
            this.gbContenedor.Name = "gbContenedor";
            this.gbContenedor.Size = new System.Drawing.Size(218, 250);
            this.gbContenedor.TabIndex = 8;
            this.gbContenedor.TabStop = false;
            this.gbContenedor.Text = "Contenedor";
            // 
            // labHora
            // 
            this.labHora.AutoSize = true;
            this.labHora.Location = new System.Drawing.Point(15, 26);
            this.labHora.Name = "labHora";
            this.labHora.Size = new System.Drawing.Size(67, 13);
            this.labHora.TabIndex = 15;
            this.labHora.Text = "Hora/Minuto";
            // 
            // numUDMinutos
            // 
            this.numUDMinutos.Location = new System.Drawing.Point(145, 24);
            this.numUDMinutos.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numUDMinutos.Name = "numUDMinutos";
            this.numUDMinutos.Size = new System.Drawing.Size(47, 20);
            this.numUDMinutos.TabIndex = 14;
            // 
            // numUDHoras
            // 
            this.numUDHoras.Location = new System.Drawing.Point(92, 24);
            this.numUDHoras.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numUDHoras.Name = "numUDHoras";
            this.numUDHoras.Size = new System.Drawing.Size(47, 20);
            this.numUDHoras.TabIndex = 13;
            // 
            // numUDCargaMaxima
            // 
            this.numUDCargaMaxima.Location = new System.Drawing.Point(90, 40);
            this.numUDCargaMaxima.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numUDCargaMaxima.Name = "numUDCargaMaxima";
            this.numUDCargaMaxima.Size = new System.Drawing.Size(100, 20);
            this.numUDCargaMaxima.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Carga Máxima";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Despachante";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(90, 16);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 8;
            // 
            // gbTipoEnvio
            // 
            this.gbTipoEnvio.Controls.Add(this.rbtnExpress);
            this.gbTipoEnvio.Controls.Add(this.rbtnFull);
            this.gbTipoEnvio.Location = new System.Drawing.Point(16, 134);
            this.gbTipoEnvio.Name = "gbTipoEnvio";
            this.gbTipoEnvio.Size = new System.Drawing.Size(189, 42);
            this.gbTipoEnvio.TabIndex = 0;
            this.gbTipoEnvio.TabStop = false;
            this.gbTipoEnvio.Text = "Tipo Envío";
            // 
            // rbtnExpress
            // 
            this.rbtnExpress.AutoSize = true;
            this.rbtnExpress.Location = new System.Drawing.Point(121, 18);
            this.rbtnExpress.Name = "rbtnExpress";
            this.rbtnExpress.Size = new System.Drawing.Size(62, 17);
            this.rbtnExpress.TabIndex = 1;
            this.rbtnExpress.TabStop = true;
            this.rbtnExpress.Text = "Express";
            this.rbtnExpress.UseVisualStyleBackColor = true;
            // 
            // rbtnFull
            // 
            this.rbtnFull.AutoSize = true;
            this.rbtnFull.Location = new System.Drawing.Point(20, 18);
            this.rbtnFull.Name = "rbtnFull";
            this.rbtnFull.Size = new System.Drawing.Size(41, 17);
            this.rbtnFull.TabIndex = 0;
            this.rbtnFull.TabStop = true;
            this.rbtnFull.Text = "Full";
            this.rbtnFull.UseVisualStyleBackColor = true;
            // 
            // gbPaquetes
            // 
            this.gbPaquetes.Controls.Add(this.numUDB);
            this.gbPaquetes.Controls.Add(this.numUDC);
            this.gbPaquetes.Controls.Add(this.numUDA);
            this.gbPaquetes.Controls.Add(this.cbC);
            this.gbPaquetes.Controls.Add(this.cbB);
            this.gbPaquetes.Controls.Add(this.cbA);
            this.gbPaquetes.Enabled = false;
            this.gbPaquetes.Location = new System.Drawing.Point(256, 146);
            this.gbPaquetes.Name = "gbPaquetes";
            this.gbPaquetes.Size = new System.Drawing.Size(201, 140);
            this.gbPaquetes.TabIndex = 9;
            this.gbPaquetes.TabStop = false;
            this.gbPaquetes.Text = "Paquetes";
            // 
            // numUDB
            // 
            this.numUDB.Enabled = false;
            this.numUDB.Location = new System.Drawing.Point(95, 87);
            this.numUDB.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numUDB.Name = "numUDB";
            this.numUDB.Size = new System.Drawing.Size(100, 20);
            this.numUDB.TabIndex = 14;
            // 
            // numUDC
            // 
            this.numUDC.Enabled = false;
            this.numUDC.Location = new System.Drawing.Point(95, 112);
            this.numUDC.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numUDC.Name = "numUDC";
            this.numUDC.Size = new System.Drawing.Size(100, 20);
            this.numUDC.TabIndex = 13;
            // 
            // numUDA
            // 
            this.numUDA.Enabled = false;
            this.numUDA.Location = new System.Drawing.Point(95, 64);
            this.numUDA.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numUDA.Name = "numUDA";
            this.numUDA.Size = new System.Drawing.Size(100, 20);
            this.numUDA.TabIndex = 12;
            // 
            // cbC
            // 
            this.cbC.AutoSize = true;
            this.cbC.Location = new System.Drawing.Point(6, 113);
            this.cbC.Name = "cbC";
            this.cbC.Size = new System.Drawing.Size(66, 17);
            this.cbC.TabIndex = 3;
            this.cbC.Text = "C - 25kg";
            this.cbC.UseVisualStyleBackColor = true;
            // 
            // cbB
            // 
            this.cbB.AutoSize = true;
            this.cbB.Location = new System.Drawing.Point(6, 90);
            this.cbB.Name = "cbB";
            this.cbB.Size = new System.Drawing.Size(66, 17);
            this.cbB.TabIndex = 2;
            this.cbB.Text = "B - 15kg";
            this.cbB.UseVisualStyleBackColor = true;
            // 
            // cbA
            // 
            this.cbA.AutoSize = true;
            this.cbA.Location = new System.Drawing.Point(6, 67);
            this.cbA.Name = "cbA";
            this.cbA.Size = new System.Drawing.Size(60, 17);
            this.cbA.TabIndex = 1;
            this.cbA.Text = "A - 5kg";
            this.cbA.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(169, 343);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 12;
            // 
            // btnVerInfo
            // 
            this.btnVerInfo.Location = new System.Drawing.Point(74, 318);
            this.btnVerInfo.Name = "btnVerInfo";
            this.btnVerInfo.Size = new System.Drawing.Size(75, 23);
            this.btnVerInfo.TabIndex = 11;
            this.btnVerInfo.Text = "Ver Info";
            this.btnVerInfo.UseVisualStyleBackColor = true;
            this.btnVerInfo.Click += new System.EventHandler(this.btnVerInfo_Click);
            // 
            // btnTicket
            // 
            this.btnTicket.Location = new System.Drawing.Point(343, 318);
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.Size = new System.Drawing.Size(75, 23);
            this.btnTicket.TabIndex = 10;
            this.btnTicket.Text = "Ticket";
            this.btnTicket.UseVisualStyleBackColor = true;
            // 
            // cbDomingoFeriado
            // 
            this.cbDomingoFeriado.AutoSize = true;
            this.cbDomingoFeriado.Location = new System.Drawing.Point(38, 50);
            this.cbDomingoFeriado.Name = "cbDomingoFeriado";
            this.cbDomingoFeriado.Size = new System.Drawing.Size(124, 17);
            this.cbDomingoFeriado.TabIndex = 13;
            this.cbDomingoFeriado.Text = "¿Domingo o feriado?";
            this.cbDomingoFeriado.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(110, 193);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 16;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(16, 193);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // gbFechaHora
            // 
            this.gbFechaHora.Controls.Add(this.labHora);
            this.gbFechaHora.Controls.Add(this.cbDomingoFeriado);
            this.gbFechaHora.Controls.Add(this.numUDHoras);
            this.gbFechaHora.Controls.Add(this.numUDMinutos);
            this.gbFechaHora.Location = new System.Drawing.Point(256, 44);
            this.gbFechaHora.Name = "gbFechaHora";
            this.gbFechaHora.Size = new System.Drawing.Size(212, 100);
            this.gbFechaHora.TabIndex = 16;
            this.gbFechaHora.TabStop = false;
            this.gbFechaHora.Text = "Fecha Y Hora";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbFechaHora);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnVerInfo);
            this.Controls.Add(this.btnTicket);
            this.Controls.Add(this.gbPaquetes);
            this.Controls.Add(this.gbContenedor);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.gbContenedor.ResumeLayout(false);
            this.gbContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDMinutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDHoras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDCargaMaxima)).EndInit();
            this.gbTipoEnvio.ResumeLayout(false);
            this.gbTipoEnvio.PerformLayout();
            this.gbPaquetes.ResumeLayout(false);
            this.gbPaquetes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDA)).EndInit();
            this.gbFechaHora.ResumeLayout(false);
            this.gbFechaHora.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbContenedor;
        private System.Windows.Forms.Label labHora;
        private System.Windows.Forms.NumericUpDown numUDMinutos;
        private System.Windows.Forms.NumericUpDown numUDHoras;
        private System.Windows.Forms.NumericUpDown numUDCargaMaxima;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.GroupBox gbTipoEnvio;
        private System.Windows.Forms.RadioButton rbtnExpress;
        private System.Windows.Forms.RadioButton rbtnFull;
        private System.Windows.Forms.GroupBox gbPaquetes;
        private System.Windows.Forms.NumericUpDown numUDB;
        private System.Windows.Forms.NumericUpDown numUDC;
        private System.Windows.Forms.NumericUpDown numUDA;
        private System.Windows.Forms.CheckBox cbC;
        private System.Windows.Forms.CheckBox cbB;
        private System.Windows.Forms.CheckBox cbA;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnVerInfo;
        private System.Windows.Forms.Button btnTicket;
        private System.Windows.Forms.CheckBox cbDomingoFeriado;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.GroupBox gbFechaHora;
    }
}