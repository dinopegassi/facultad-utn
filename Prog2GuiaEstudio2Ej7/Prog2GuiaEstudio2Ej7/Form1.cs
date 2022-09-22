using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog2GuiaEstudio2Ej7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Constructor cosirulo;
        Busqueda busqueda;
        private void button1_Click(object sender, EventArgs e)
        {
            cosirulo = new Constructor();
            foreach (int[] i in cosirulo.GetCosito())
            {
                foreach (int j in i)
                {
                    listBox1.Items.Add(j);
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            busqueda = new Busqueda();
            busqueda.BubbleSort(cosirulo.GetCosito(), (int)numericUpDown1.Value);
            MessageBox.Show(string.Format("Fila {0}\nColumna {1}", busqueda.PosicionExterna.ToString(), busqueda.PosicionInterna.ToString()));
            
        }
    }
}
