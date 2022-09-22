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
        Rotiseria laRoti= new Rotiseria();
        Pedido pedido;
        int numPedido=0;
        private void button1_Click(object sender, EventArgs e)
        {
            
            Form2 form = new Form2();
            if(form.ShowDialog()==DialogResult.OK)
            {
                string nombre = form.textBox1.Text;
                if (form.checkBox1.Checked)
                {
                    double km = Convert.ToDouble(form.textBox2.Text);
                    pedido = new Delivery(numPedido++, nombre, km);
                }
                else pedido = new Pedido(nombre, numPedido++);
            }
            laRoti.AgregarPedido(pedido);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //ItemMenu item = new ItemMenu("queso");
            int cant = Convert.ToInt32(textBox1.Text);
            ItemMenu item = new ItemMenu(comboBox1.SelectedItem.ToString());
            //laRoti.VerPedido()
            pedido.AgregarItem(item, cant);
            listBox1.Items.Add("Menu: " + item.Descripcion() + " (x" + cant + ")");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Pedido p = laRoti.VerPedido(numPedido);
            listBox2.Items.Add("Nro P: "+p.Numero +" Nombre: " +p.ToString() + "  $" + p.VerPrecio());
        }
    }
}
