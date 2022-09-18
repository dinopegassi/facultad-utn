using System;
using System.Windows.Forms;

namespace Clase25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ClaseImportante objeto;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            switch (cbTipo.SelectedIndex)
            {
                case 0:
                    objeto = new ClaseImportante(Convert.ToInt32(tbTamanio.Text), Convert.ToByte(0));
                    break;
                case 1:
                    objeto = new ClaseImportante(Convert.ToInt32(tbTamanio.Text), Convert.ToInt32(0));
                    break;
                case 2:
                    objeto = new ClaseImportante(Convert.ToInt32(tbTamanio.Text), Convert.ToSingle(0));
                    break;
                case 3:
                    objeto = new ClaseImportante(Convert.ToInt32(tbTamanio.Text), Convert.ToDecimal(0));
                    break;
                case 4:
                    objeto = new ClaseImportante(Convert.ToInt32(tbTamanio.Text), Convert.ToString(0));
                    break;
            }
            btnCrear.Enabled = false;
            btnBuscar.Enabled = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            if (objeto.VerByteLength() != 1)
            {
                byte buscado= Convert.ToByte(random.Next(256));
                double[] resultado = new double[5];
                resultado = objeto.BuscarIndiceArray(buscado);
                ListViewItem lista = new ListViewItem("Byte");
                lista.SubItems.Add(tbTamanio.Text);
                for (int i = 0; i < 5; i++)
                    lista.SubItems.Add(resultado[i].ToString());
                lvVisualizacion.Items.Add(lista);
            }
            else if (objeto.VerStringLength() != 1)
            {
                string buscado = String.Format("{0}",random.Next(50));
                double[] resultado = new double[5];
                resultado = objeto.BuscarIndiceArray(buscado);
                ListViewItem lista = new ListViewItem("String");
                lista.SubItems.Add(tbTamanio.Text);
                for (int i = 0; i < 5; i++)
                    lista.SubItems.Add(resultado[i].ToString());
                lvVisualizacion.Items.Add(lista);
            }
            else if (objeto.VerIntLength() != 1)
            {
                int buscado = Convert.ToInt32(random.Next(50));
                double[] resultado = new double[5];
                resultado = objeto.BuscarIndiceArray(buscado);
                ListViewItem lista = new ListViewItem("Int32");
                lista.SubItems.Add(tbTamanio.Text);
                for (int i = 0; i < 5; i++)
                    lista.SubItems.Add(resultado[i].ToString());
                lvVisualizacion.Items.Add(lista);
            }
            else if (objeto.VerFloatLength() != 1)
            {
                float buscado = Convert.ToSingle(random.NextDouble()*random.Next(50));
                double[] resultado = new double[5];
                resultado = objeto.BuscarIndiceArray(buscado);
                ListViewItem lista = new ListViewItem("Float/Single");
                lista.SubItems.Add(tbTamanio.Text);
                for (int i = 0; i < 5; i++)
                    lista.SubItems.Add(resultado[i].ToString());
                lvVisualizacion.Items.Add(lista);
            }
            else if (objeto.VerDecimalLength() != 1)
            {
                decimal buscado = Convert.ToDecimal(random.NextDouble()*random.Next(50));
                double[] resultado = new double[5];
                resultado = objeto.BuscarIndiceArray(buscado);
                ListViewItem lista = new ListViewItem("Decimal");
                lista.SubItems.Add(tbTamanio.Text);
                for (int i = 0; i < 5; i++)
                    lista.SubItems.Add(resultado[i].ToString());
                lvVisualizacion.Items.Add(lista);
            }
            btnCrear.Enabled = true;
            btnBuscar.Enabled = false;
        }
    }
}
