using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FabricaDeMuebles
{
    public partial class FormDatosdelProducto : Form
    {
        public FormDatosdelProducto()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != "Silla")
                numericUpDown1.Enabled = true;
            else
            {
                numericUpDown1.Enabled = false;
                numericUpDown1.Value = 0;
            }
        }
    }
}
