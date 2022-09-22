using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ejercicio2
{
    public partial class Form1 : Form
    {
        Equipo nuevo = new Equipo(); 
        public Form1()
        {
            InitializeComponent();
        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt16(tBnumero.Text);
            string nombre = tBnombre.Text;
            nuevo.Agregar(n, nombre); 
        }

        private void bVer_Click(object sender, EventArgs e)
        {
            if (tBnumero.Text != "")
            {
                int n = Convert.ToInt16(tBnumero.Text);
                string nombre = nuevo.Ver(n);
                MessageBox.Show(nombre);
            }
            else
            {
                string nombre = tBnombre.Text;
                int numero = nuevo.BuscarNro(nombre);
                if ( numero== -1)
                {
                    MessageBox.Show("No encontrado");
                }
                else 
                {
                    MessageBox.Show("Numero de camiseta: "+ numero);
                }

            }

        }
    }
}
