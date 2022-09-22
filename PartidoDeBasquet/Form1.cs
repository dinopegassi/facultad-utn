using System;
using System.Windows.Forms;

namespace PartidoDeBasquet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Equipo l, v;
        public void BloquearLocal()
        {
            if (l.VerJugador(listBox1.SelectedIndex).Juega)
            {
                btnPunto.Enabled = true;
                btnPenalizar.Enabled = true;
            }
            else
            {
                btnPunto.Enabled = false;
                btnPenalizar.Enabled = false;
            }
        }
        public void BloquearVisitante()
        {
            if (v.VerJugador(listBox2.SelectedIndex).Juega)
            {
                btnPunto.Enabled = true;
                btnPenalizar.Enabled = true;
            }
            else
            {
                btnPunto.Enabled = false;
                btnPenalizar.Enabled = false;
            }
        }
        private void btnCargarEquipos_Click(object sender, EventArgs e)             // 1) cargar equipos
        {
            l = new Equipo(tboxL.Text);
            v = new Equipo(tboxV.Text);
            groupBox1.Enabled = false;
            gbCargaJugadores.Enabled = true;
        }
        private void btnCargarJugador_Click(object sender, EventArgs e)
        {
            Jugador j = new Jugador(tboxNombre.Text);
            if (radioButtonL.Checked)
            {
                l.AgregarJugador(j);
                listBox1.Items.Add(j.Nombre);
            }
            if (radioButtonV.Checked)
            {
                v.AgregarJugador(j);
                listBox2.Items.Add(j.Nombre);
            }

            //if (l.NroJ > 4 && v.NroJ > 4)
            if (l.NroJ > -1 && v.NroJ > -1) //futbol 5 qcy                      GUARDAAAAAAAAAAAAA es 4, no -1
            {
                btnFinalizarCarga.Enabled = true;
                labNecesitanJugadores.Text = "Pueden comenzar";
            }
            else
                labNecesitanJugadores.Text = "Faltan jugadores aun";

        }
        private void button1_Click(object sender, EventArgs e)     //boton que finaliza la carga
        {
            btnFinalizarCarga.Hide();
            btnCargarJugador.Hide();
            gbCargaJugadores.Text = "Agregar Punto";
            labNecesitanJugadores.Hide();
            tboxNombre.Hide();
            btnPunto.Show();
            btnPenalizar.Show();
            gbTantos.Show();
            gbTablero.Enabled = true;
            gbListaJugadores.Enabled = true;
            radioButtonL.Visible = false;
            radioButtonV.Visible = false;
        }


        private void btnPunto_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                if (rbSimple.Checked)
                {
                    l.VerJugador(listBox1.SelectedIndex).Anotar(1);
                }
                else if (rbDoble.Checked)
                {
                    l.VerJugador(listBox1.SelectedIndex).Anotar(2);
                }
                else if (rbTriple.Checked)
                {
                    l.VerJugador(listBox1.SelectedIndex).Anotar(3);
                }
                tbLocalTablero.Text = String.Format("{0}", l.VerPuntajeEquipo());
            }
            else if (listBox2.SelectedIndex > -1)
            {
                if (rbSimple.Checked)
                {
                    v.VerJugador(listBox2.SelectedIndex).Anotar(1);
                }
                else if (rbDoble.Checked)
                {
                    v.VerJugador(listBox2.SelectedIndex).Anotar(2);
                }
                else if (rbTriple.Checked)
                {
                    v.VerJugador(listBox2.SelectedIndex).Anotar(3);
                }
                tbVisitanteTablero.Text = String.Format("{0}", v.VerPuntajeEquipo());
            }

            
            
        }
        private void button2_Click(object sender, EventArgs e)       //penalizar
        {
            if (listBox1.SelectedIndex > -1)
            {
                l.VerJugador(listBox1.SelectedIndex).Falta();
                tbLocalFaltasTablero.Text = String.Format("{0}", l.VerFaltasEquipo());
            }
            if (listBox2.SelectedIndex > -1)
            {
                v.VerJugador(listBox2.SelectedIndex).Falta();
                tbVisitanteFaltasTablero.Text = String.Format("{0}", v.VerFaltasEquipo());
            }
            BloquearLocal();
            BloquearVisitante();
            //string nombre = (string)listBox1.SelectedItem;
            //l.Falta(nombre);
            //v.Falta(nombre);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.ClearSelected();
            BloquearLocal();
            //if (l.VerJugador(listBox1.SelectedIndex).Juega)
            //{
            //    btnPunto.Enabled = true;
            //    btnPenalizar.Enabled = true;
            //}
            //else
            //{
            //    btnPunto.Enabled = false;
            //    btnPenalizar.Enabled = false;
            //}
        }
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            listBox1.ClearSelected();
            BloquearVisitante();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

    }
}
