
namespace TransporteDeCargas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkSeTrabaja = new System.Windows.Forms.CheckBox();
            this.checkHora = new System.Windows.Forms.CheckBox();
            this.rBfull = new System.Windows.Forms.RadioButton();
            this.rBexpreso = new System.Windows.Forms.RadioButton();
            this.numB = new System.Windows.Forms.NumericUpDown();
            this.numC = new System.Windows.Forms.NumericUpDown();
            this.numA = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numCapMax = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tBdespachante = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.bFinalizar = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCapMax)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Tan;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(206, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 113);
            this.button1.TabIndex = 0;
            this.button1.Text = "\r\n\r\n\r\n\r\n\r\n\r\nCobrar\r\n";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkSeTrabaja);
            this.groupBox1.Controls.Add(this.checkHora);
            this.groupBox1.Controls.Add(this.rBfull);
            this.groupBox1.Controls.Add(this.rBexpreso);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.numB);
            this.groupBox1.Controls.Add(this.numC);
            this.groupBox1.Controls.Add(this.numA);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numCapMax);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tBdespachante);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 207);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Contenedor";
            // 
            // checkSeTrabaja
            // 
            this.checkSeTrabaja.AutoSize = true;
            this.checkSeTrabaja.Location = new System.Drawing.Point(100, 174);
            this.checkSeTrabaja.Name = "checkSeTrabaja";
            this.checkSeTrabaja.Size = new System.Drawing.Size(121, 17);
            this.checkSeTrabaja.TabIndex = 10;
            this.checkSeTrabaja.Text = "Domingo o Feriado?";
            this.checkSeTrabaja.UseVisualStyleBackColor = true;
            this.checkSeTrabaja.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkHora
            // 
            this.checkHora.AutoSize = true;
            this.checkHora.Checked = true;
            this.checkHora.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkHora.Location = new System.Drawing.Point(6, 174);
            this.checkHora.Name = "checkHora";
            this.checkHora.Size = new System.Drawing.Size(88, 17);
            this.checkHora.TabIndex = 9;
            this.checkHora.Text = "6 AM a 8 PM";
            this.checkHora.UseVisualStyleBackColor = true;
            // 
            // rBfull
            // 
            this.rBfull.AutoSize = true;
            this.rBfull.Location = new System.Drawing.Point(106, 51);
            this.rBfull.Name = "rBfull";
            this.rBfull.Size = new System.Drawing.Size(41, 17);
            this.rBfull.TabIndex = 8;
            this.rBfull.Text = "Full";
            this.rBfull.UseVisualStyleBackColor = true;
            // 
            // rBexpreso
            // 
            this.rBexpreso.AutoSize = true;
            this.rBexpreso.Checked = true;
            this.rBexpreso.Location = new System.Drawing.Point(10, 51);
            this.rBexpreso.Name = "rBexpreso";
            this.rBexpreso.Size = new System.Drawing.Size(63, 17);
            this.rBexpreso.TabIndex = 7;
            this.rBexpreso.TabStop = true;
            this.rBexpreso.Text = "Expreso";
            this.rBexpreso.UseVisualStyleBackColor = true;
            // 
            // numB
            // 
            this.numB.BackColor = System.Drawing.SystemColors.Info;
            this.numB.Location = new System.Drawing.Point(106, 121);
            this.numB.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numB.Name = "numB";
            this.numB.Size = new System.Drawing.Size(100, 20);
            this.numB.TabIndex = 5;
            // 
            // numC
            // 
            this.numC.BackColor = System.Drawing.SystemColors.Info;
            this.numC.Location = new System.Drawing.Point(106, 143);
            this.numC.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numC.Name = "numC";
            this.numC.Size = new System.Drawing.Size(100, 20);
            this.numC.TabIndex = 6;
            // 
            // numA
            // 
            this.numA.BackColor = System.Drawing.SystemColors.Info;
            this.numA.Location = new System.Drawing.Point(106, 100);
            this.numA.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numA.Name = "numA";
            this.numA.Size = new System.Drawing.Size(100, 20);
            this.numA.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Paquetes C";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Paquetes B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Paquetes A";
            // 
            // numCapMax
            // 
            this.numCapMax.BackColor = System.Drawing.Color.MediumTurquoise;
            this.numCapMax.Cursor = System.Windows.Forms.Cursors.Default;
            this.numCapMax.DecimalPlaces = 2;
            this.numCapMax.Location = new System.Drawing.Point(106, 74);
            this.numCapMax.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numCapMax.Name = "numCapMax";
            this.numCapMax.Size = new System.Drawing.Size(100, 20);
            this.numCapMax.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Capacidad Max.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Despachante";
            // 
            // tBdespachante
            // 
            this.tBdespachante.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tBdespachante.Location = new System.Drawing.Point(106, 17);
            this.tBdespachante.Name = "tBdespachante";
            this.tBdespachante.Size = new System.Drawing.Size(100, 20);
            this.tBdespachante.TabIndex = 1;
            this.tBdespachante.Text = "Nombre";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Location = new System.Drawing.Point(334, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 207);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ver Contenedor";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(185, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Window;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(9, 54);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(185, 147);
            this.listBox1.TabIndex = 1;
            // 
            // bFinalizar
            // 
            this.bFinalizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bFinalizar.BackgroundImage")));
            this.bFinalizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bFinalizar.Location = new System.Drawing.Point(382, 231);
            this.bFinalizar.Name = "bFinalizar";
            this.bFinalizar.Size = new System.Drawing.Size(94, 95);
            this.bFinalizar.TabIndex = 0;
            this.bFinalizar.UseVisualStyleBackColor = true;
            this.bFinalizar.Click += new System.EventHandler(this.bFinalizar_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(12, 231);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(307, 95);
            this.listBox2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(554, 338);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.bFinalizar);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCapMax)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBdespachante;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bFinalizar;
        private System.Windows.Forms.NumericUpDown numB;
        private System.Windows.Forms.NumericUpDown numC;
        private System.Windows.Forms.NumericUpDown numA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RadioButton rBfull;
        private System.Windows.Forms.RadioButton rBexpreso;
        private System.Windows.Forms.CheckBox checkSeTrabaja;
        private System.Windows.Forms.CheckBox checkHora;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown numCapMax;
        private System.Windows.Forms.ListBox listBox2;
        public System.Windows.Forms.Button button1;
    }
}

