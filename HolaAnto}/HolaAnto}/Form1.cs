using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HolaAnto_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Class1 class1 = new Class1(String.Format("Manolito"));
        private void button1_Click(object sender, EventArgs e)
        {
            string cadenaUno = @"\tHola\n";
            string cadenaDos = "\tHola\n";
            labCadenaUno.Text = cadenaUno;
            labCadenaDos.Text = cadenaDos;
        }

        private void labCadenaUno_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Composite formatting:
            label1.Text = String.Format("Hello, {0}!", class1.Nombre);
            // String interpolation:
            label2.Text = String.Format($"Hello, {class1.Nombre}!");
            // Composite formatting:
            label3.Text = String.Format(@"Hello, {0}!", class1.Nombre);
            // String interpolation:
            label4.Text = String.Format($@"Hello, {class1.Nombre}!");


        }
    }
}
