namespace Ordenamiento
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn32Caract = new System.Windows.Forms.RadioButton();
            this.btn8Caract = new System.Windows.Forms.RadioButton();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.btnDecimal = new System.Windows.Forms.RadioButton();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.btnSingle = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnInt64 = new System.Windows.Forms.RadioButton();
            this.btnInt16 = new System.Windows.Forms.RadioButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusTxt = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(506, 275);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 40);
            this.button3.TabIndex = 12;
            this.button3.Text = "Comenzar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(289, 275);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 40);
            this.button2.TabIndex = 11;
            this.button2.Text = "Comenzar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn32Caract);
            this.groupBox3.Controls.Add(this.btn8Caract);
            this.groupBox3.Controls.Add(this.checkBox9);
            this.groupBox3.Controls.Add(this.listBox3);
            this.groupBox3.Controls.Add(this.checkBox10);
            this.groupBox3.Controls.Add(this.checkBox11);
            this.groupBox3.Controls.Add(this.checkBox12);
            this.groupBox3.Location = new System.Drawing.Point(450, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(194, 263);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos Strings";
            // 
            // btn32Caract
            // 
            this.btn32Caract.AutoSize = true;
            this.btn32Caract.Location = new System.Drawing.Point(103, 19);
            this.btn32Caract.Name = "btn32Caract";
            this.btn32Caract.Size = new System.Drawing.Size(73, 17);
            this.btn32Caract.TabIndex = 12;
            this.btn32Caract.TabStop = true;
            this.btn32Caract.Text = "32 caract.";
            this.btn32Caract.UseVisualStyleBackColor = true;
            // 
            // btn8Caract
            // 
            this.btn8Caract.AutoSize = true;
            this.btn8Caract.Location = new System.Drawing.Point(19, 19);
            this.btn8Caract.Name = "btn8Caract";
            this.btn8Caract.Size = new System.Drawing.Size(67, 17);
            this.btn8Caract.TabIndex = 12;
            this.btn8Caract.TabStop = true;
            this.btn8Caract.Text = "8 caract.";
            this.btn8Caract.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(19, 109);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(92, 17);
            this.checkBox9.TabIndex = 11;
            this.checkBox9.Text = "Selection Sort";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Items.AddRange(new object[] {
            "10000",
            "500000",
            "1000000",
            "5000000",
            "8000000"});
            this.listBox3.Location = new System.Drawing.Point(19, 143);
            this.listBox3.Name = "listBox3";
            this.listBox3.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox3.Size = new System.Drawing.Size(160, 95);
            this.listBox3.TabIndex = 3;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(19, 86);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(78, 17);
            this.checkBox10.TabIndex = 8;
            this.checkBox10.Text = "Merge Sort";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Location = new System.Drawing.Point(19, 63);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(81, 17);
            this.checkBox11.TabIndex = 9;
            this.checkBox11.Text = "Bubble Sort";
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Location = new System.Drawing.Point(19, 42);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(73, 17);
            this.checkBox12.TabIndex = 10;
            this.checkBox12.Text = "QuickSort";
            this.checkBox12.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox5);
            this.groupBox2.Controls.Add(this.listBox2);
            this.groupBox2.Controls.Add(this.checkBox6);
            this.groupBox2.Controls.Add(this.btnDecimal);
            this.groupBox2.Controls.Add(this.checkBox7);
            this.groupBox2.Controls.Add(this.checkBox8);
            this.groupBox2.Controls.Add(this.btnSingle);
            this.groupBox2.Location = new System.Drawing.Point(230, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(194, 263);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Números Reales";
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(19, 109);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(92, 17);
            this.checkBox5.TabIndex = 11;
            this.checkBox5.Text = "Selection Sort";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Items.AddRange(new object[] {
            "10000",
            "500000",
            "1000000",
            "5000000",
            "8000000"});
            this.listBox2.Location = new System.Drawing.Point(19, 143);
            this.listBox2.Name = "listBox2";
            this.listBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox2.Size = new System.Drawing.Size(160, 95);
            this.listBox2.TabIndex = 6;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(19, 86);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(78, 17);
            this.checkBox6.TabIndex = 8;
            this.checkBox6.Text = "Merge Sort";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // btnDecimal
            // 
            this.btnDecimal.AutoSize = true;
            this.btnDecimal.Location = new System.Drawing.Point(116, 19);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(63, 17);
            this.btnDecimal.TabIndex = 5;
            this.btnDecimal.TabStop = true;
            this.btnDecimal.Text = "Decimal";
            this.btnDecimal.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(19, 63);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(81, 17);
            this.checkBox7.TabIndex = 9;
            this.checkBox7.Text = "Bubble Sort";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(19, 42);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(73, 17);
            this.checkBox8.TabIndex = 10;
            this.checkBox8.Text = "QuickSort";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // btnSingle
            // 
            this.btnSingle.AutoSize = true;
            this.btnSingle.Location = new System.Drawing.Point(19, 19);
            this.btnSingle.Name = "btnSingle";
            this.btnSingle.Size = new System.Drawing.Size(48, 17);
            this.btnSingle.TabIndex = 4;
            this.btnSingle.TabStop = true;
            this.btnSingle.Text = "Float";
            this.btnSingle.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.btnInt64);
            this.groupBox1.Controls.Add(this.btnInt16);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 263);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Números Enteros";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(18, 109);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(92, 17);
            this.checkBox4.TabIndex = 4;
            this.checkBox4.Text = "Selection Sort";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(18, 86);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(78, 17);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "Merge Sort";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(18, 63);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(81, 17);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "Bubble Sort";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(18, 42);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(73, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "QuickSort";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "5",
            "10000",
            "500000",
            "1000000",
            "5000000",
            "8000000"});
            this.listBox1.Location = new System.Drawing.Point(18, 143);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(160, 95);
            this.listBox1.TabIndex = 2;
            // 
            // btnInt64
            // 
            this.btnInt64.AutoSize = true;
            this.btnInt64.Location = new System.Drawing.Point(129, 19);
            this.btnInt64.Name = "btnInt64";
            this.btnInt64.Size = new System.Drawing.Size(49, 17);
            this.btnInt64.TabIndex = 1;
            this.btnInt64.TabStop = true;
            this.btnInt64.Text = "Int64";
            this.btnInt64.UseVisualStyleBackColor = true;
            // 
            // btnInt16
            // 
            this.btnInt16.AutoSize = true;
            this.btnInt16.Location = new System.Drawing.Point(18, 19);
            this.btnInt16.Name = "btnInt16";
            this.btnInt16.Size = new System.Drawing.Size(49, 17);
            this.btnInt16.TabIndex = 0;
            this.btnInt16.TabStop = true;
            this.btnInt16.Text = "Int16";
            this.btnInt16.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusTxt,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 546);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(662, 22);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusTxt
            // 
            this.statusTxt.Name = "statusTxt";
            this.statusTxt.Size = new System.Drawing.Size(71, 17);
            this.statusTxt.Text = "Esperando...";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(12, 345);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(632, 190);
            this.textBox1.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(68, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 40);
            this.button1.TabIndex = 15;
            this.button1.Text = "Comenzar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 568);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton btn32Caract;
        private System.Windows.Forms.RadioButton btn8Caract;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.RadioButton btnDecimal;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.RadioButton btnSingle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RadioButton btnInt64;
        private System.Windows.Forms.RadioButton btnInt16;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusTxt;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}

