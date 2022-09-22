using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Control nuevoCorredor; 

        private void bNuevo_Click(object sender, EventArgs e)
        {
            nuevoCorredor = new Control(Convert.ToInt16(tBvueltas.Text));
            lTiempo.Text = "Tiempo 1:";
            bCargar.Enabled = true;
        }

        private void bCargar_Click(object sender, EventArgs e)
        {
            nuevoCorredor.AgregarTiempo(Convert.ToInt16(tBtiempo.Text));
            lTiempo.Text = "Tiempo " + (nuevoCorredor.Vueltas+1).ToString() +": ";
            if (nuevoCorredor.Vueltas>= Convert.ToInt16(tBvueltas.Text))
                   bCargar.Enabled=false;
        }

        private void bResumen_Click(object sender, EventArgs e)
        {
            
            listBox1.Items.Add("Vueltas: "+nuevoCorredor.Vueltas.ToString());
            listBox1.Items.Add("Promedio: " + nuevoCorredor.VerPromedio().ToString("0.00"));
            listBox1.Items.Add("Menor vuelta: " + nuevoCorredor.VueltaMenor.ToString());
            nuevoCorredor.ContarVueltasMayores();
            listBox1.Items.Add("Vueltas sobre el promedio: " + nuevoCorredor.VueltasMayor.ToString());
        }

     
    }
}
