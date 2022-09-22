using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace FabricaDeMuebles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //ArrayList lista = new ArrayList();
        Muebleria presupuesto;
        private void button1_Click(object sender, EventArgs e)
        {
            FormDatosdelProducto fDatos = new FormDatosdelProducto();
            if (fDatos.ShowDialog() == DialogResult.OK)
            {
                int tipoProducto = fDatos.comboBox1.SelectedIndex;
                string descripcion = fDatos.textBox1.Text;
                double precio = Convert.ToDouble(fDatos.numericUpDown2.Value);
                int material = fDatos.comboBox2.SelectedIndex + 1;
                if (tipoProducto == 0)
                {
                    double largo = Convert.ToDouble(fDatos.numericUpDown1.Value);
                    Mesa nuevaMesa = new Mesa(precio, descripcion);
                    nuevaMesa.Detalle(largo, material);
                    presupuesto.AgregarProducto(nuevaMesa);
                }
                else if (tipoProducto == 1)
                {
                    Silla nuevaSilla = new Silla(descripcion);
                    nuevaSilla.Detalle(material, precio);
                    presupuesto.AgregarProducto(nuevaSilla);
                }
            }
            fDatos.Dispose();
            //if (fDatos.ShowDialog() == DialogResult.OK)
            //{
            //    int tipoProducto = fDatos.comboBox1.SelectedIndex;
            //    string descripcion = fDatos.textBox1.Text;
            //    double precio = Convert.ToDouble(fDatos.numericUpDown2.Value);
            //    int material = fDatos.comboBox2.SelectedIndex + 1;
            //    if (tipoProducto == 0)
            //    {
            //        double largo = Convert.ToDouble(fDatos.numericUpDown1.Value);
            //        Mesa nuevaMesa = new Mesa(precio, descripcion);
            //        nuevaMesa.Detalle(largo, material);
            //        lista.Add(nuevaMesa);
            //    }
            //    else if (tipoProducto == 1)
            //    {
            //        Silla nuevaSilla = new Silla(descripcion);
            //        nuevaSilla.Detalle(material, precio);
            //        lista.Add(nuevaSilla);
            //    }
            //}
            //fDatos.Dispose();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormResultado fResultados = new FormResultado();
            fResultados.listBox1.Items.Clear();
            presupuesto.Ordenar();
            fResultados.listBox1.Items.Add(string.Format("Cliente: {0}",
            presupuesto.Cliente));
            fResultados.listBox1.Items.Add(string.Format("Direccion: {0}",
            presupuesto.Direccion));
            fResultados.listBox1.Items.Add("Items presupuestados:");
            for (int n = 0; n < presupuesto.CantProductos; n++)
            {
                Producto producto = (Producto)presupuesto[n];
                fResultados.listBox1.Items.Add(string.Format(" {0,-30},{1,10:f2}",
                producto.ToString(),
                producto.Precio()));
            }
            fResultados.listBox1.Items.Add(string.Format(" {0,30},{1,10:f2}", "Total: ",
            presupuesto.CostoTotal));
            fResultados.ShowDialog();
            fResultados.Dispose();

            //FormResultado fResultados = new FormResultado();
            //fResultados.listBox1.Items.Clear();
            //lista.Sort();
            //foreach (Producto producto in lista)
            //{
            //    fResultados.listBox1.Items.Add(
            //    string.Format("{0}: {1}",
            //    producto.ToString(),
            //    producto.Precio()
            //    ));
            //}
            //fResultados.ShowDialog();
            //fResultados.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            base.Dispose();
            //Close();
        }
    }
}
