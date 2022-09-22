using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog2Guia1Ej1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        formNros obj;
        int numero = 0;
        int[] vector;


        private void btnGenerar_Click(object sender, EventArgs e)
        {
            obj = new formNros();
            obj.ShowDialog();
            if (obj.DialogResult == DialogResult.OK)
            {
                vector = new int[numero];

                numero = Convert.ToInt32(obj.tbNro.Text);
                int z = 0;
                for (int i = 0; i < numero; i++)
                {
                    
                    z = i + 1;
                    lbNros.Items.Add(z.ToString());
                    
                    vector[i-1] = z;
                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            vector = new int[numero];


            if (rbAscendente.Checked)
            {
                int aux, i, j;
                for (i = 0; i < numero - 1; i++)
                {
                    for (j = i + 1; j < numero; j++)
                    {
                        //z = Convert.ToInt32(lbNros.Text);
                        if (vector[i] < vector[j])
                        {
                            aux = vector[j];
                            vector[i] = vector[j];
                            vector[j] = aux;
                        }
                    }
                }
                lbNros.Items.Clear();
                for (i=0; i < numero; i++)
                {
                    lbNros.Items.Add(vector[i]);
                }
                

            }

            else
             if (rbDescendente.Checked)
            {
                int aux, i, j;
                for (i = 0; i < numero - 1; i++)
                {
                    for (j = i + 1; j < numero; j++)
                    {
                        //z = Convert.ToInt32(lbNros.Text);
                        if (vector[i] > vector[j])
                        {
                            aux = vector[j];
                            vector[i] = vector[j];
                            vector[j] = aux;
                        }
                    }
                }
                lbNros.Items.Add(vector);
            }
        }
    }
}

