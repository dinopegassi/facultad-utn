using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Guia_4_Consigna_25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        GenerarVectores vectores = new GenerarVectores(); 
        
        private void button1_Click(object sender, EventArgs e)
        {          
                switch (cbTipo.SelectedIndex)
            {
               
                case 0:
                    {
                        double[] resultado = new double[5];
                        resultado=vectores.BusquedaByte(Convert.ToInt32(cbTamaño.Items[cbTamaño.SelectedIndex]));
                        ListViewItem lista = new ListViewItem("Byte");
                        lista.SubItems.Add(cbTamaño.Text);
                        for (int i = 0; i < 5; i++)
                            lista.SubItems.Add(resultado[i].ToString());
                        lv.Items.Add(lista);
                    }
                    break;
                case 1:
                    {
                        double[] resultado = new double[5];
                        resultado = vectores.BusquedaInt(Convert.ToInt32(cbTamaño.Items[cbTamaño.SelectedIndex]));
                        ListViewItem lista = new ListViewItem("Int32");
                        lista.SubItems.Add(cbTamaño.Text);
                        for (int i = 0; i < 5; i++)
                        {
                            lista.SubItems.Add(resultado[i].ToString());
                        }
                        lv.Items.Add(lista);

                    }
                    break;
                case 2:
                    {
                        double[] resultado = new double[5];
                        resultado = vectores.BusquedaFloat(Convert.ToInt32(cbTamaño.Items[cbTamaño.SelectedIndex]));
                        ListViewItem lista = new ListViewItem("Float");
                        lista.SubItems.Add(cbTamaño.Text);
                        for (int i = 0; i < 5; i++)
                        {
                            lista.SubItems.Add(resultado[i].ToString());
                        }
                        lv.Items.Add(lista);

                        
                    }
                    break;
                case 3:
                    {
                        double[] resultado = new double[5];
                        resultado = vectores.BusquedaDecimal(Convert.ToInt32(cbTamaño.Items[cbTamaño.SelectedIndex]));
                        ListViewItem lista = new ListViewItem("Decimal");
                        lista.SubItems.Add(cbTamaño.Text);
                        for (int i = 0; i < 5; i++)
                        {
                            lista.SubItems.Add(resultado[i].ToString());
                        }
                        lv.Items.Add(lista);
                    }
                    break;
                case 4:
                    {
                        double[] resultado = new double[5];
                        resultado = vectores.BusquedaString(Convert.ToInt32(cbTamaño.Items[cbTamaño.SelectedIndex]));
                        ListViewItem lista = new ListViewItem("String");
                        lista.SubItems.Add(cbTamaño.Text);
                        for (int i = 0; i < 5; i++)
                        {
                            lista.SubItems.Add(resultado[i].ToString());
                        }
                        lv.Items.Add(lista);
                    }
                    break;
            }
            
        }


    }
}
