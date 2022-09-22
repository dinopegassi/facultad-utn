using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog2GuiaEstudio3Ej8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Identificador cosito = new Identificador();
        private void button1_Click(object sender, EventArgs e)
        {
            cosito.AgregarString(textBox1.Text);
            cosito.Busqueda(cosito.Lista);
            MessageBox.Show(cosito.Contarg.ToString());
        }
    }
}
