using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Prog2Parcial1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Rotiseria laRoti;
        private void button1_Click(object sender, EventArgs e)
        {
            laRoti = new Rotiseria();
            Form2 form = new Form2();
            Pedido pedido;
            if (form.ShowDialog() == DialogResult.OK)
            {
                if (form.checkBox1.Checked)
                {
                    pedido = new Delivery(0, textBox1.Text, Convert.ToInt32(textBox2.Text));
                    // como concha se codifica el numero de pedido??
                    // acaso tiene que contar la cantidad de veces
                    // que se abrio form2??
                    laRoti.AgregarPedido(pedido);
                }
                else
                {
                    pedido = new Pedido(textBox1.Text, 0);
                    laRoti.AgregarPedido(pedido);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            if (form.ShowDialog() == DialogResult.OK)
            {
                ItemMenu menu = new ItemMenu(textBox1.Text, Convert.ToDouble(textBox2));
            }
        }
    }
}
