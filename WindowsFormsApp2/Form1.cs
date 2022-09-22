using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        Colectivo unCole;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num=Convert.ToInt32(textBox1.Text);
            unCole=new Colectivo(num);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int dia=Convert.ToInt32(textBox2.Text);
            double km=Convert.ToDouble(textBox3.Text);
            unCole.AgregarViaje(dia, km);

        }

        private void btnResumen_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("dia menor distancia" + unCole.DiaMenorKm);
            listBox1.Items.Add("dia mayor distancia" + unCole.DiaMayorKm);
            listBox1.Items.Add("km totales" + unCole.VerKmTotal());
            listBox1.Items.Add("viajes totales" + unCole.VerCantViajesTotal());
            listBox1.Items.Add("promedio" + unCole.Promedio());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
    }
}
