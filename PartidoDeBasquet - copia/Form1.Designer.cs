
namespace PartidoDeBasquet
{
    partial class Form1Partido
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
            this.btnCargarEquipos = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxV = new System.Windows.Forms.TextBox();
            this.tboxL = new System.Windows.Forms.TextBox();
            this.gbCargaJugadores = new System.Windows.Forms.GroupBox();
            this.gbListaJugadores = new System.Windows.Forms.GroupBox();
            this.labVisitanteLista = new System.Windows.Forms.Label();
            this.labLocalLista = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnPenalizar = new System.Windows.Forms.Button();
            this.btnPunto = new System.Windows.Forms.Button();
            this.gbTantos = new System.Windows.Forms.GroupBox();
            this.rbTriple = new System.Windows.Forms.RadioButton();
            this.rbSimple = new System.Windows.Forms.RadioButton();
            this.rbDoble = new System.Windows.Forms.RadioButton();
            this.labNecesitanJugadores = new System.Windows.Forms.Label();
            this.btnFinalizarCarga = new System.Windows.Forms.Button();
            this.radioButtonV = new System.Windows.Forms.RadioButton();
            this.radioButtonL = new System.Windows.Forms.RadioButton();
            this.tboxNombre = new System.Windows.Forms.TextBox();
            this.btnCargarJugador = new System.Windows.Forms.Button();
            this.gbTablero = new System.Windows.Forms.GroupBox();
            this.tbVisitanteFaltasTablero = new System.Windows.Forms.TextBox();
            this.tbVisitanteTablero = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbLocalFaltasTablero = new System.Windows.Forms.TextBox();
            this.tbLocalTablero = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbCargaJugadores.SuspendLayout();
            this.gbListaJugadores.SuspendLayout();
            this.gbTantos.SuspendLayout();
            this.gbTablero.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCargarEquipos
            // 
            this.btnCargarEquipos.Location = new System.Drawing.Point(20, 86);
            this.btnCargarEquipos.Name = "btnCargarEquipos";
            this.btnCargarEquipos.Size = new System.Drawing.Size(234, 22);
            this.btnCargarEquipos.TabIndex = 0;
            this.btnCargarEquipos.Text = "Cargar Equipos";
            this.btnCargarEquipos.UseVisualStyleBackColor = true;
            this.btnCargarEquipos.Click += new System.EventHandler(this.btnCargarEquipos_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tboxV);
            this.groupBox1.Controls.Add(this.tboxL);
            this.groupBox1.Controls.Add(this.btnCargarEquipos);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 117);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Equipos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Visitante";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Local";
            // 
            // tboxV
            // 
            this.tboxV.Location = new System.Drawing.Point(164, 41);
            this.tboxV.Name = "tboxV";
            this.tboxV.Size = new System.Drawing.Size(100, 20);
            this.tboxV.TabIndex = 2;
            // 
            // tboxL
            // 
            this.tboxL.Location = new System.Drawing.Point(6, 41);
            this.tboxL.Name = "tboxL";
            this.tboxL.Size = new System.Drawing.Size(100, 20);
            this.tboxL.TabIndex = 1;
            // 
            // gbCargaJugadores
            // 
            this.gbCargaJugadores.Controls.Add(this.gbListaJugadores);
            this.gbCargaJugadores.Controls.Add(this.btnPenalizar);
            this.gbCargaJugadores.Controls.Add(this.btnPunto);
            this.gbCargaJugadores.Controls.Add(this.gbTantos);
            this.gbCargaJugadores.Controls.Add(this.labNecesitanJugadores);
            this.gbCargaJugadores.Controls.Add(this.btnFinalizarCarga);
            this.gbCargaJugadores.Controls.Add(this.radioButtonV);
            this.gbCargaJugadores.Controls.Add(this.radioButtonL);
            this.gbCargaJugadores.Controls.Add(this.tboxNombre);
            this.gbCargaJugadores.Controls.Add(this.btnCargarJugador);
            this.gbCargaJugadores.Enabled = false;
            this.gbCargaJugadores.Location = new System.Drawing.Point(12, 145);
            this.gbCargaJugadores.Name = "gbCargaJugadores";
            this.gbCargaJugadores.Size = new System.Drawing.Size(546, 212);
            this.gbCargaJugadores.TabIndex = 2;
            this.gbCargaJugadores.TabStop = false;
            this.gbCargaJugadores.Text = "Cargar Jugadores";
            // 
            // gbListaJugadores
            // 
            this.gbListaJugadores.Controls.Add(this.labVisitanteLista);
            this.gbListaJugadores.Controls.Add(this.labLocalLista);
            this.gbListaJugadores.Controls.Add(this.listBox2);
            this.gbListaJugadores.Controls.Add(this.listBox1);
            this.gbListaJugadores.Enabled = false;
            this.gbListaJugadores.Location = new System.Drawing.Point(322, 0);
            this.gbListaJugadores.Name = "gbListaJugadores";
            this.gbListaJugadores.Size = new System.Drawing.Size(225, 212);
            this.gbListaJugadores.TabIndex = 4;
            this.gbListaJugadores.TabStop = false;
            this.gbListaJugadores.Text = "Lista de Jugadores";
            // 
            // labVisitanteLista
            // 
            this.labVisitanteLista.AutoSize = true;
            this.labVisitanteLista.Location = new System.Drawing.Point(146, 16);
            this.labVisitanteLista.Name = "labVisitanteLista";
            this.labVisitanteLista.Size = new System.Drawing.Size(47, 13);
            this.labVisitanteLista.TabIndex = 5;
            this.labVisitanteLista.Text = "Visitante";
            this.labVisitanteLista.Click += new System.EventHandler(this.label9_Click);
            // 
            // labLocalLista
            // 
            this.labLocalLista.AutoSize = true;
            this.labLocalLista.Location = new System.Drawing.Point(37, 16);
            this.labLocalLista.Name = "labLocalLista";
            this.labLocalLista.Size = new System.Drawing.Size(33, 13);
            this.labLocalLista.TabIndex = 5;
            this.labLocalLista.Text = "Local";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(116, 32);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(102, 173);
            this.listBox2.TabIndex = 2;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(8, 32);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(102, 173);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnPenalizar
            // 
            this.btnPenalizar.ForeColor = System.Drawing.Color.Crimson;
            this.btnPenalizar.Location = new System.Drawing.Point(141, 161);
            this.btnPenalizar.Name = "btnPenalizar";
            this.btnPenalizar.Size = new System.Drawing.Size(170, 25);
            this.btnPenalizar.TabIndex = 0;
            this.btnPenalizar.Text = "Penalizar";
            this.btnPenalizar.UseVisualStyleBackColor = true;
            this.btnPenalizar.Visible = false;
            this.btnPenalizar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPunto
            // 
            this.btnPunto.ForeColor = System.Drawing.Color.Blue;
            this.btnPunto.Location = new System.Drawing.Point(140, 124);
            this.btnPunto.Name = "btnPunto";
            this.btnPunto.Size = new System.Drawing.Size(171, 25);
            this.btnPunto.TabIndex = 7;
            this.btnPunto.Text = "Dar Punto";
            this.btnPunto.UseVisualStyleBackColor = true;
            this.btnPunto.Visible = false;
            this.btnPunto.Click += new System.EventHandler(this.btnPunto_Click);
            // 
            // gbTantos
            // 
            this.gbTantos.Controls.Add(this.rbTriple);
            this.gbTantos.Controls.Add(this.rbSimple);
            this.gbTantos.Controls.Add(this.rbDoble);
            this.gbTantos.Location = new System.Drawing.Point(235, 19);
            this.gbTantos.Name = "gbTantos";
            this.gbTantos.Size = new System.Drawing.Size(81, 89);
            this.gbTantos.TabIndex = 3;
            this.gbTantos.TabStop = false;
            this.gbTantos.Text = "Tantos";
            this.gbTantos.Visible = false;
            // 
            // rbTriple
            // 
            this.rbTriple.AutoSize = true;
            this.rbTriple.Location = new System.Drawing.Point(6, 65);
            this.rbTriple.Name = "rbTriple";
            this.rbTriple.Size = new System.Drawing.Size(51, 17);
            this.rbTriple.TabIndex = 9;
            this.rbTriple.Text = "Triple";
            this.rbTriple.UseVisualStyleBackColor = true;
            // 
            // rbSimple
            // 
            this.rbSimple.AutoSize = true;
            this.rbSimple.Checked = true;
            this.rbSimple.Location = new System.Drawing.Point(6, 19);
            this.rbSimple.Name = "rbSimple";
            this.rbSimple.Size = new System.Drawing.Size(56, 17);
            this.rbSimple.TabIndex = 7;
            this.rbSimple.TabStop = true;
            this.rbSimple.Text = "Simple";
            this.rbSimple.UseVisualStyleBackColor = true;
            // 
            // rbDoble
            // 
            this.rbDoble.AutoSize = true;
            this.rbDoble.Location = new System.Drawing.Point(6, 42);
            this.rbDoble.Name = "rbDoble";
            this.rbDoble.Size = new System.Drawing.Size(53, 17);
            this.rbDoble.TabIndex = 8;
            this.rbDoble.Text = "Doble";
            this.rbDoble.UseVisualStyleBackColor = true;
            // 
            // labNecesitanJugadores
            // 
            this.labNecesitanJugadores.AutoSize = true;
            this.labNecesitanJugadores.Location = new System.Drawing.Point(6, 123);
            this.labNecesitanJugadores.Name = "labNecesitanJugadores";
            this.labNecesitanJugadores.Size = new System.Drawing.Size(40, 13);
            this.labNecesitanJugadores.TabIndex = 6;
            this.labNecesitanJugadores.Text = "LABEL";
            // 
            // btnFinalizarCarga
            // 
            this.btnFinalizarCarga.Enabled = false;
            this.btnFinalizarCarga.Location = new System.Drawing.Point(9, 139);
            this.btnFinalizarCarga.Name = "btnFinalizarCarga";
            this.btnFinalizarCarga.Size = new System.Drawing.Size(66, 66);
            this.btnFinalizarCarga.TabIndex = 5;
            this.btnFinalizarCarga.Text = "Iniciar Partido";
            this.btnFinalizarCarga.UseVisualStyleBackColor = true;
            this.btnFinalizarCarga.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButtonV
            // 
            this.radioButtonV.AutoSize = true;
            this.radioButtonV.ForeColor = System.Drawing.Color.DarkOrchid;
            this.radioButtonV.Location = new System.Drawing.Point(152, 45);
            this.radioButtonV.Name = "radioButtonV";
            this.radioButtonV.Size = new System.Drawing.Size(65, 17);
            this.radioButtonV.TabIndex = 4;
            this.radioButtonV.TabStop = true;
            this.radioButtonV.Text = "Visitante";
            this.radioButtonV.UseVisualStyleBackColor = true;
            // 
            // radioButtonL
            // 
            this.radioButtonL.AutoSize = true;
            this.radioButtonL.Checked = true;
            this.radioButtonL.ForeColor = System.Drawing.Color.IndianRed;
            this.radioButtonL.Location = new System.Drawing.Point(152, 22);
            this.radioButtonL.Name = "radioButtonL";
            this.radioButtonL.Size = new System.Drawing.Size(51, 17);
            this.radioButtonL.TabIndex = 3;
            this.radioButtonL.TabStop = true;
            this.radioButtonL.Text = "Local";
            this.radioButtonL.UseVisualStyleBackColor = true;
            // 
            // tboxNombre
            // 
            this.tboxNombre.Location = new System.Drawing.Point(39, 19);
            this.tboxNombre.Name = "tboxNombre";
            this.tboxNombre.Size = new System.Drawing.Size(86, 20);
            this.tboxNombre.TabIndex = 2;
            // 
            // btnCargarJugador
            // 
            this.btnCargarJugador.Location = new System.Drawing.Point(7, 47);
            this.btnCargarJugador.Name = "btnCargarJugador";
            this.btnCargarJugador.Size = new System.Drawing.Size(119, 25);
            this.btnCargarJugador.TabIndex = 0;
            this.btnCargarJugador.Text = "Cargar Jugador";
            this.btnCargarJugador.UseVisualStyleBackColor = true;
            this.btnCargarJugador.Click += new System.EventHandler(this.btnCargarJugador_Click);
            // 
            // gbTablero
            // 
            this.gbTablero.Controls.Add(this.tbVisitanteFaltasTablero);
            this.gbTablero.Controls.Add(this.tbVisitanteTablero);
            this.gbTablero.Controls.Add(this.label7);
            this.gbTablero.Controls.Add(this.label6);
            this.gbTablero.Controls.Add(this.tbLocalFaltasTablero);
            this.gbTablero.Controls.Add(this.tbLocalTablero);
            this.gbTablero.Controls.Add(this.label5);
            this.gbTablero.Controls.Add(this.label4);
            this.gbTablero.Enabled = false;
            this.gbTablero.Location = new System.Drawing.Point(310, 13);
            this.gbTablero.Name = "gbTablero";
            this.gbTablero.Size = new System.Drawing.Size(167, 117);
            this.gbTablero.TabIndex = 3;
            this.gbTablero.TabStop = false;
            this.gbTablero.Text = "Tablero";
            // 
            // tbVisitanteFaltasTablero
            // 
            this.tbVisitanteFaltasTablero.BackColor = System.Drawing.Color.Plum;
            this.tbVisitanteFaltasTablero.Location = new System.Drawing.Point(99, 88);
            this.tbVisitanteFaltasTablero.Name = "tbVisitanteFaltasTablero";
            this.tbVisitanteFaltasTablero.ReadOnly = true;
            this.tbVisitanteFaltasTablero.Size = new System.Drawing.Size(41, 20);
            this.tbVisitanteFaltasTablero.TabIndex = 7;
            // 
            // tbVisitanteTablero
            // 
            this.tbVisitanteTablero.BackColor = System.Drawing.Color.Plum;
            this.tbVisitanteTablero.Location = new System.Drawing.Point(99, 69);
            this.tbVisitanteTablero.Name = "tbVisitanteTablero";
            this.tbVisitanteTablero.ReadOnly = true;
            this.tbVisitanteTablero.Size = new System.Drawing.Size(41, 20);
            this.tbVisitanteTablero.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Visitante Faltas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Local Faltas";
            // 
            // tbLocalFaltasTablero
            // 
            this.tbLocalFaltasTablero.BackColor = System.Drawing.Color.DarkSalmon;
            this.tbLocalFaltasTablero.Location = new System.Drawing.Point(99, 35);
            this.tbLocalFaltasTablero.Name = "tbLocalFaltasTablero";
            this.tbLocalFaltasTablero.ReadOnly = true;
            this.tbLocalFaltasTablero.Size = new System.Drawing.Size(41, 20);
            this.tbLocalFaltasTablero.TabIndex = 3;
            // 
            // tbLocalTablero
            // 
            this.tbLocalTablero.BackColor = System.Drawing.Color.DarkSalmon;
            this.tbLocalTablero.Location = new System.Drawing.Point(99, 16);
            this.tbLocalTablero.Name = "tbLocalTablero";
            this.tbLocalTablero.ReadOnly = true;
            this.tbLocalTablero.Size = new System.Drawing.Size(41, 20);
            this.tbLocalTablero.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Visitante";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Local";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Enabled = false;
            this.btnFinalizar.Location = new System.Drawing.Point(483, 13);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(69, 117);
            this.btnFinalizar.TabIndex = 5;
            this.btnFinalizar.Text = "Finalizar Partido";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // Form1Partido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 369);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.gbTablero);
            this.Controls.Add(this.gbCargaJugadores);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1Partido";
            this.Text = "Partido";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbCargaJugadores.ResumeLayout(false);
            this.gbCargaJugadores.PerformLayout();
            this.gbListaJugadores.ResumeLayout(false);
            this.gbListaJugadores.PerformLayout();
            this.gbTantos.ResumeLayout(false);
            this.gbTantos.PerformLayout();
            this.gbTablero.ResumeLayout(false);
            this.gbTablero.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCargarEquipos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxV;
        private System.Windows.Forms.TextBox tboxL;
        private System.Windows.Forms.GroupBox gbCargaJugadores;
        private System.Windows.Forms.TextBox tboxNombre;
        private System.Windows.Forms.Button btnCargarJugador;
        private System.Windows.Forms.RadioButton radioButtonV;
        private System.Windows.Forms.RadioButton radioButtonL;
        private System.Windows.Forms.Button btnFinalizarCarga;
        private System.Windows.Forms.RadioButton rbTriple;
        private System.Windows.Forms.RadioButton rbDoble;
        private System.Windows.Forms.RadioButton rbSimple;
        private System.Windows.Forms.GroupBox gbTantos;
        private System.Windows.Forms.GroupBox gbTablero;
        private System.Windows.Forms.TextBox tbLocalTablero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbLocalFaltasTablero;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbVisitanteFaltasTablero;
        private System.Windows.Forms.TextBox tbVisitanteTablero;
        private System.Windows.Forms.GroupBox gbListaJugadores;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnPenalizar;
        private System.Windows.Forms.Button btnPunto;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label labNecesitanJugadores;
        private System.Windows.Forms.Label labVisitanteLista;
        private System.Windows.Forms.Label labLocalLista;
        private System.Windows.Forms.Button btnFinalizar;
    }
}

