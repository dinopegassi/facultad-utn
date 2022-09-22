using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Jugador jug = new Jugador( , , , );

        private void button1_Click(object sender, EventArgs e)
        {
            jug.SumaTanto(3);
        }
    }
}
