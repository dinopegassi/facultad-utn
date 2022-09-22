using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransporteDeCargas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        EmpresaDeTransporte empresa = new EmpresaDeTransporte();
        private void button1_Click(object sender, EventArgs e)
        {                         
            bool expreso = true;
            if (rBfull.Checked)
                expreso = false;
            //agrega y me trae el objeto para el combobox
            Contenedor c = empresa.AgregarContenedor
                               (tBdespachante.Text,                 //nombre
                               expreso,                            //tipo
                               Convert.ToDouble(numCapMax.Value), //Capacidad  
                               Convert.ToInt32(numA.Value),      //cant A
                               Convert.ToInt32(numB.Value),     //cant B
                               Convert.ToInt32(numC.Value));   //cant C

            comboBox1.Items.Add("Contenedor "+ c.Id); //o puede usar el nombre tmb

            //cobrar (ventana modal)
            bool horaComercio = false, noSeTrabaja = false;
            if (checkHora.Checked)
                horaComercio = true;
            if (checkSeTrabaja.Checked)
                noSeTrabaja = true;
            Ticket t= empresa.VerTicket(horaComercio, noSeTrabaja);
            t.ShowDialog();
            t.Dispose();
            //2da forma es traer un vector de string e ir agregando eso al ticket

            //Muestreo (consigna del tp) (se puede poner en un boton propio)
            listBox2.Items.Clear();
            listBox2.Items.Insert(0, "≡ Existencias ≡");
            listBox2.Items.Insert(1, "Cobro total: " + string.Format("{0:C}", empresa.CobroTotal()));
            listBox2.Items.Insert(2, "Contenedores: " + empresa.ContGenerados()); //contenedores creados
            listBox2.Items.Insert(3, "Peso prom: " + empresa.CalcularPesoProm()); //peso promedio
            listBox2.Items.Insert(4, empresa.CajaMasUsada()); //caja mas usada
            listBox2.Items.Insert(5, "");

            //reset de los textos
            tBdespachante.Text = "";
            numCapMax.Value = 0;
            numA.Value = 0;
            numB.Value = 0;
            numC.Value = 0;
        }

        private void bFinalizar_Click(object sender, EventArgs e)
        {
            Ticket t = new Ticket();
            t.listBox1.Items.Clear();
            string[] v = empresa.VerMultas();
            if (empresa.Multas == 0)
                t.listBox1.Items.Add("No hubo multas");
            else
            {
                t.listBox1.Items.Add("Contenedores con multa:");
                for (int i = 0; i < empresa.Multas; i++)
                {
                    t.listBox1.Items.Add(v[i]);
                }
            }
            t.Text = "█ █ █ █ MULTAS █ █ █ █";
            t.ShowDialog();
            t.Dispose();
            MessageBox.Show("╔═════════════════╗\n║\tAdios :)\t\t                ║\n╚═════════════════╝");
            Close();
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSeTrabaja.Checked)
                MessageBox.Show("No jodas, no se labura");
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = comboBox1.SelectedIndex;
            Contenedor c = empresa.VerContenedor(i);
            listBox1.Items.Clear();
            listBox1.Items.Add(string.Format("Id: {0}", c.Id));
            listBox1.Items.Add(string.Format("Despachante: {0}", c.EmpresaDespachante));
            listBox1.Items.Add(string.Format("Capacidad: {0} kg", c.CapacidadMaximaKg));
            if (c.Expreso)
                listBox1.Items.Add("Tipo: expreso");
            else listBox1.Items.Add("Tipo: full");
            listBox1.Items.Add(string.Format("Cantidad A: {0}", c.CantA));
            listBox1.Items.Add(string.Format("Cantidad B: {0}", c.CantB));
            listBox1.Items.Add(string.Format("Cantidad C: {0}", c.CantC));
        }
    }
}
