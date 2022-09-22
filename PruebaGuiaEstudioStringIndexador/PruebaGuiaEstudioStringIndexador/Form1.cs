using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaGuiaEstudioStringIndexador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Coso coso = new Coso();
            coso.Metodo();
            dataGridView1.BackgroundColor = Color.Tomato;
            dataGridView1.ColumnCount = 4;
            dataGridView1.RowCount = 5;
            dataGridView1[3, 3].Value = coso.Metodo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Coso coso = new Coso();
            dataGridView1.BackgroundColor = Color.Tomato;
            dataGridView1.ColumnCount = 4;
            dataGridView1.RowCount = 5;
            dataGridView1[1, 3].Value = coso.MetodoVocales();

        }
    }
}
