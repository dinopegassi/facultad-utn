using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labo2TP1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Isla isla;
        int[] grilla = new int[2];
        int paso = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            while(MessageBox.Show("Sos trolo?","Pregunta seria",
                MessageBoxButtons.YesNo)==DialogResult.No)
            grilla[0] = 50;
            grilla[1] = 50;
            FormCargaDatos ventana = new FormCargaDatos();
            int machos = 0, hembras = 0, quesos = 0, gatos = 0;

            DialogResult r = MessageBox.Show("Por defecto se haran mitad y mitad.",
                "Desea elegir machos y hembras?",
                MessageBoxButtons.YesNo);
            if(r == DialogResult.No)
            {
                ventana.label1.Text = "Cantidad de Ratones";
                ventana.label2.Hide();
                ventana.numericUpDown2.Hide();
            } //esconde llenar macho/hembra

            if (radioButton1.Checked)
            {   
                ventana.Text = "Isla Normal";
                ventana.label3.Text = "Cantidad de Quesos";
            } //esconde llenar gatos
            if (radioButton2.Checked) ventana.Text = "Isla con Gatos";
            
            if (ventana.ShowDialog()==DialogResult.OK)
            {
                machos = (int)ventana.numericUpDown1.Value;
                hembras = (int)ventana.numericUpDown2.Value;
                gatos = (int)ventana.numericUpDown3.Value;

                // o creas el vector de animales y los tiras por ref
                // o le tiras cuantos crear

                if (radioButton1.Checked)
                {
                    if (r == DialogResult.No) isla = new Isla(machos, gatos, grilla); //gatos es cantQueso aca
                    else isla = new Isla(machos, hembras, gatos, grilla);
                    this.Text = "Isla Normal";
                } //isla sin gatos
                if (radioButton2.Checked)
                {
                    if (r == DialogResult.No) isla = new IslaConGatos(machos, gatos, grilla);
                    else isla = new IslaConGatos(machos, hembras, gatos, grilla);
                    this.Text = "Isla con Gatos";
                } //isla con gatos

            } //ventana modal

            if (isla != null) groupBox1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ArrayList informe = isla.HacerUnPaso();
            listBox1.Items.Insert(0, "");
            listBox1.Items.Insert(0, "Paso nro: " + paso++);
            for (int i = 0; i < informe.Count; i++)
                listBox1.Items.Insert(1,informe[i]);
            
        }
    }
}
