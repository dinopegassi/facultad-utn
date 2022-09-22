using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Impresora3D
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Impresion3D imp;
        private void button1_Click(object sender, EventArgs e)
        {
            string n = textBox1.Text;
            long cuit= Convert.ToInt64(textBox2.Text);
            double p = Convert.ToDouble(textBox3.Text);
            imp = new Impresion3D(p, n, cuit);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            if(form.ShowDialog()==DialogResult.OK)
            {
                double largo_radio, ancho, alto;
                largo_radio = Convert.ToDouble(form.textBox1); //no castee "form."
                ancho = Convert.ToDouble(form.textBox2);
                alto = Convert.ToDouble(form.textBox3);
                if (form.radioButton1.Checked)
                    imp.AgregarFigura(new Cilindro(largo_radio, alto)); // mande ancho tmb
                if (form.radioButton2.Checked)
                    imp.AgregarFigura(new Prisma(largo_radio, alto, ancho));
            }
            form.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(imp.Empresa);
            ArrayList lista = imp.figuras;
            lista.Sort();

            for(int i=0;i<lista.Count;i++)
            {
                listBox1.Items.Add(((Figura)lista[i]).Descripcion);
            }
            listBox1.Items.Add("Precio estimado: " + imp.PrecioEstimado());
            listBox1.Items.Add("Tiempo:          " + imp.Tiempo()+" s.");
        }
    }
}
