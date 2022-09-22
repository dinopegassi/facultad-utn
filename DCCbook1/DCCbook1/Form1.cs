using System;
using System.Windows.Forms;

namespace DCCbook1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayPrefijoSufijo arreglo;
        private void btCrear_Click(object sender, EventArgs e)
        {
            arreglo = new ArrayPrefijoSufijo(Convert.ToInt32(tbTamanio.Text));
            for (int i = 0; i < arreglo.VerArregloLength(); ++i)
            {
                lbArreglo.Items.Add(arreglo.VerArregloIndice(i));
            }
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < arreglo.VerArregloLength(); ++i)
            {
                lbArregloNuevo.Items.Add(arreglo.CalcularArregloIndice(i));
            }
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
        }
    }
}
