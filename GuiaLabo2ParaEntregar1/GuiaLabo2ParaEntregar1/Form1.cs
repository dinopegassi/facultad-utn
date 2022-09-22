using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuiaLabo2ParaEntregar1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        PolimorfisGamer game;
        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            groupBox2.Enabled = true;
            button2.Enabled = true;
            string name = textBox1.Text;
            int cant = (int)numericUpDown1.Value;
            if(radioButton1.Checked)
            {
                game = new PolimorfisGamer(name, cant);
            }
            else if (radioButton2.Checked)
            {
                game = new RealPolimorfisGamer(name, cant);
                foreach (Elemento ele in ((RealPolimorfisGamer)game).ListarElementos())
                {
                    string lista = String.Format("{0}-> Inicio: {1} - Fin: {2}", ele.ToString(),
                                                                                ele.PosInit,
                                                                                ele.PosFinal);
                    listBox1.Items.Add(lista);
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (game.HaFinalizado == false)
            {
                game.JugarRonda();
                foreach (Jugador j in game.ListarJugadores())
                {
                    //listBox1.Items.Insert(0, String.Format("{0} afecto a {1} de {2} a {3}",j.PorQuienFueAfectado.ToString(),
                    //    j.Nombre, j.PorQuienFueAfectado.PosInit, j.PorQuienFueAfectado.PosFinal));
                    string lista = String.Format("{0} movió desde {1} a {2} (Dado:{3})", j.Nombre,
                                                                                    j.PosicionAnt,
                                                                                    j.Posicion,
                                                                                    j.Avance);
                    listBox1.Items.Insert(0, lista);
                }
                listBox1.Items.Insert(0, "---------------------------------------------------------");
            }
            else
                button2.Enabled = false;
            //falta notificar por que elemento y de donde a donde fue llevado
        }
    }
}
