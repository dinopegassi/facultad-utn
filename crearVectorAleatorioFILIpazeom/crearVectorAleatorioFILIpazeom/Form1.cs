using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crearVectorAleatorioFILIpazeom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        { }

        private void button1_Click_1(object sender, EventArgs e)
        {
            {
                textBox1.Clear();
                Random azar = new Random();

                int tamañoConjunto = 26 * 2 + 10;

                //genero mi conjunto alfanumerico
                char[] miConjunto = new char[tamañoConjunto];
                int n = 0, m = 0;
                while (n < 26)
                {
                    miConjunto[m++] = Convert.ToChar(65 + n); //"65=A"es necesario convertir
                    miConjunto[m++] = Convert.ToChar(97 + n); //"97=a"
                    if (n < 10) miConjunto[m++] = Convert.ToChar(48 + n);  //"48=0"
                    n++;
                }

                //de lo que te pase, hay que usar constructor para
                //convertir esa cadena de char en string
                textBox1.AppendText("conjunto alfanumerico: " +
                                                 new string(miConjunto));
                //el textBox1 en multilinea usa appendText()

                //generando una palabra con caracteres aleatorios
                char[] miPalabraChr = new char[10];
                for (int p = 0; p < 10; p++)
                {
                    int idx = azar.Next(0, tamañoConjunto);
                    miPalabraChr[p] = miConjunto[idx]; //copio el caracter elegido aleatoriamente de mi conjunto
                }
                string miPalabra = new string(miPalabraChr);

                textBox1.AppendText(Environment.NewLine +
                                    "------" +
                                    Environment.NewLine +
                                    "Mi palabra : " + miPalabra);
            }
        }
    }
}
