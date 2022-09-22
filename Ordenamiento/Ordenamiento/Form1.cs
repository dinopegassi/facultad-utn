using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace Ordenamiento
{
        public partial class Form1 : Form
        {
            public Form1()
            {
                InitializeComponent();


            }
        Enteros entero1;
        private void button1_Click(object sender, EventArgs e)
        {

            if (!(checkBox1.Checked || checkBox2.Checked || checkBox3.Checked || checkBox4.Checked) || listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un metodo de ordenamiento!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                entero1 = new Enteros();
                textBox1.Text = "RESULTADOS:";
                if (btnInt64.Checked)
                {
                    statusTxt.Text = "Creando vector de enteros de 64bits";
                    textBox1.Text += "\r\nVector " + btnInt64.Text + " de " + Convert.ToString(listBox1.SelectedItem) + " elementos.";
                    long[] vector1 = entero1.Crearvector64(Convert.ToInt32(listBox1.SelectedItem));
                    if (checkBox1.Checked)
                    {
                        long[] vectorQS = (long[])vector1.Clone();
                        statusTxt.Text = "Ordenando vector por modo " + checkBox1.Text;
                        Process proc = Process.GetCurrentProcess();
                        DateTime start = DateTime.Now;
                        entero1.QuickSort(vectorQS, 0, vectorQS.Length-1);
                        DateTime end = DateTime.Now;
                        TimeSpan finaltime = (end - start);
                        double nrooo = proc.PrivateMemorySize64;
                        textBox1.Text += "\r\nEl ordenamiento rapido ordenó en: " + finaltime.TotalMilliseconds + " ms";
                        textBox1.Text += "process: " + nrooo;
                    }
                    if (checkBox2.Checked)
                    {
                        long[] vectorBurbuja = (long[])vector1.Clone();
                        statusTxt.Text = "Ordenando vector por modo " + checkBox2.Text;
                        DateTime start = DateTime.Now;
                        entero1.BubbleSort(vectorBurbuja);
                        DateTime end = DateTime.Now;
                        TimeSpan finaltime = (end - start);
                        textBox1.Text += "\r\nEl metodo burbuja ordenó en: " + finaltime.TotalMilliseconds + " ms";
                    }
                    if (checkBox3.Checked)
                    {
                        long[] vectorMerge = (long[])vector1.Clone();
                        statusTxt.Text = "Ordenando vector por modo " + checkBox2.Text;
                        DateTime start = DateTime.Now;
                        entero1.mergeSort(vectorMerge, 0, vectorMerge.Length - 1);
                        DateTime end = DateTime.Now;
                        TimeSpan finaltime = (end - start);
                        textBox1.Text += "\r\nEl metodo Merge ordenó en: " + finaltime.TotalMilliseconds + " ms";
                    }
                    if (checkBox4.Checked)
                    {
                        long[] vectorSelec = (long[])vector1.Clone();
                        statusTxt.Text = "Ordenando vector por modo " + checkBox4.Text;
                        DateTime startQ = DateTime.Now;
                        entero1.selectionSort(vectorSelec, vectorSelec.Length);
                        DateTime endQ = DateTime.Now;
                        TimeSpan finaltime = (endQ - startQ);
                        textBox1.Text += "\r\nEl metodo seleccion ordenó en: " + finaltime.TotalMilliseconds + " ms";
                    }

                }

                if (btnInt16.Checked)
                {
                    textBox1.Text += "\r\nVector " + btnInt16.Text + " de " + Convert.ToString(listBox1.SelectedItem) + " elementos.";
                    short[] vector1 = entero1.Crearvector16(Convert.ToInt32(listBox1.SelectedItem));
                    if (checkBox1.Checked)
                    {
                        short[] vectorQS = (short[])vector1.Clone();
                        DateTime start = DateTime.Now;
                        entero1.QuickSort(vectorQS, 0, vectorQS.Length - 1);
                        DateTime end = DateTime.Now;
                        TimeSpan finaltime = end - start;
                        textBox1.Text += "\r\nEl ordenamiento rapido ordenó en: " + finaltime.TotalMilliseconds + " ms";
                    }
                    if (checkBox2.Checked)
                    {
                        short[] vectorBurbuja = (short[])vector1.Clone();
                        DateTime start = DateTime.Now;
                        entero1.BubbleSort(vectorBurbuja);
                        DateTime end = DateTime.Now;
                        TimeSpan finaltime = end - start;
                        textBox1.Text += "\r\nEl metodo burbuja ordenó en: " + finaltime.TotalMilliseconds + " ms";
                    }
                    if (checkBox3.Checked)
                    {
                        short[] vectorMerge = (short[])vector1.Clone();
                        statusTxt.Text = "Ordenando vector por modo " + checkBox2.Text;
                        DateTime start = DateTime.Now;
                        entero1.mergeSort(vectorMerge, 0, vectorMerge.Length - 1);
                        DateTime end = DateTime.Now;
                        TimeSpan finaltime = (end - start);
                        textBox1.Text += "\r\nEl metodo Merge ordenó en: " + finaltime.TotalMilliseconds + " ms";
                    }
                    if (checkBox4.Checked)
                    {
                        short[] vectorSelec = (short[])vector1.Clone();
                        DateTime start = DateTime.Now;
                        entero1.selectionSort(vectorSelec, vectorSelec.Length);
                        DateTime end = DateTime.Now;
                        TimeSpan finaltime = end - start;
                        textBox1.Text += "\r\nEl metodo seleccion ordenó en: " + finaltime.TotalMilliseconds + " ms";
                    }
                }
            }
            textBox1.Text += "\r\nCant. Comparaciones QS:  " + entero1.cantComparacionesQS;
            textBox1.Text += "\r\nCant. Intercambios QS:  " + entero1.cantIntercambiosQS;

            textBox1.Text += "\r\nCant. Comparaciones BS:  " + entero1.cantComparacionesBS;
            textBox1.Text += "\r\nCant. Intercambios BS:  " + entero1.cantIntercambiosBS;

            textBox1.Text += "\r\nCant. Comparaciones MS:  " + entero1.cantComparacionesMS;
            textBox1.Text += "\r\nCant. Intercambios MS:  " + entero1.cantIntercambiosMS;

            textBox1.Text += "\r\nCant. Intercambios SS:  " + entero1.cantComparacionesSS;
            textBox1.Text += "\r\nCant. Comparaciones SS:  " + entero1.cantIntercambiosSS;
            statusTxt.Text = "Listo.";
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (!(checkBox5.Checked || checkBox6.Checked || checkBox7.Checked || checkBox8.Checked) || listBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un metodo de ordenamiento!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                textBox1.Text = "RESULTADOS:";
                Reales reales1 = new Reales();
                if (btnSingle.Checked)
                {
                    textBox1.Text += "\r\nVector " + btnSingle.Text + " de " + Convert.ToString(listBox2.SelectedItem) + " elementos.";
                    statusTxt.Text = "Creando vector de enteros de 64bits";
                    float[] vector1 = reales1.Crearvector32(Convert.ToInt32(listBox2.SelectedItem));
                    if (checkBox8.Checked)
                    {
                        float[] vectorQS = (float[])vector1.Clone();
                        statusTxt.Text = "Ordenando vector por modo " + checkBox1.Text;
                        DateTime start = DateTime.Now;
                        reales1.QuickSort(vectorQS, 0, vectorQS.Length - 1);
                        DateTime end = DateTime.Now;
                        TimeSpan finaltime = (end - start);
                        textBox1.Text += "\r\nEl ordenamiento rapido ordenó en: " + finaltime.TotalMilliseconds + " ms";
                    }
                    if (checkBox7.Checked)
                    {
                        float[] vectorBurbuja = (float[])vector1.Clone();
                        statusTxt.Text = "Ordenando vector por modo " + checkBox2.Text;
                        DateTime start = DateTime.Now;
                        reales1.BubbleSort(vectorBurbuja);
                        DateTime end = DateTime.Now;
                        TimeSpan finaltime = (end - start);
                        textBox1.Text += "\r\nEl metodo burbuja ordenó en: " + finaltime.TotalMilliseconds + " ms";
                    }
                    if (checkBox6.Checked)
                    {
                        float[] vectorMerge = (float[])vector1.Clone();
                        statusTxt.Text = "Ordenando vector por modo " + checkBox2.Text;
                        DateTime start = DateTime.Now;
                        reales1.mergeSort(vectorMerge, 0, vectorMerge.Length - 1);
                        DateTime end = DateTime.Now;
                        TimeSpan finaltime = (end - start);
                        textBox1.Text += "\r\nEl metodo Merge ordenó en: " + finaltime.TotalMilliseconds + " ms";
                    }
                    if (checkBox5.Checked)
                    {
                        float[] vectorSelec = (float[])vector1.Clone();
                        statusTxt.Text = "Ordenando vector por modo " + checkBox4.Text;
                        DateTime startQ = DateTime.Now;
                        reales1.selectionSort(vectorSelec, vectorSelec.Length);
                        DateTime endQ = DateTime.Now;
                        TimeSpan finaltime = (endQ - startQ);
                        textBox1.Text += "\r\nEl metodo seleccion ordenó en: " + finaltime.TotalMilliseconds + " ms";
                    }
                }

                if (btnDecimal.Checked)
                {
                    textBox1.Text += "\r\nVector " + btnDecimal.Text + " de " + Convert.ToString(listBox2.SelectedItem) + " elementos.";
                    Decimal[] vector1 = reales1.Crearvector128(Convert.ToInt32(listBox2.SelectedItem));
                    if (checkBox8.Checked)
                    {
                        Decimal[] vectorQS = (Decimal[])vector1.Clone();
                        DateTime start = DateTime.Now;
                        reales1.QuickSort(vectorQS, 0, vectorQS.Length - 1);
                        DateTime end = DateTime.Now;
                        TimeSpan finaltime = end - start;
                        textBox1.Text += "\r\nEl ordenamiento rapido ordenó en: " + finaltime.TotalMilliseconds + " ms";
                    }
                    if (checkBox7.Checked)
                    {
                        Decimal[] vectorBurbuja = (Decimal[])vector1.Clone();
                        DateTime start = DateTime.Now;
                        reales1.BubbleSort(vectorBurbuja);
                        DateTime end = DateTime.Now;
                        TimeSpan finaltime = end - start;
                        textBox1.Text += "\r\nEl metodo burbuja ordenó en: " + finaltime.TotalMilliseconds + " ms";
                    }
                    if (checkBox6.Checked)
                    {
                        Decimal[] vectorMerge = (Decimal[])vector1.Clone();
                        statusTxt.Text = "Ordenando vector por modo " + checkBox2.Text;
                        DateTime start = DateTime.Now;
                        reales1.mergeSort(vectorMerge, 0, vectorMerge.Length - 1);
                        DateTime end = DateTime.Now;
                        TimeSpan finaltime = (end - start);
                        textBox1.Text += "\r\nEl metodo Merge ordenó en: " + finaltime.TotalMilliseconds + " ms";
                    }
                    if (checkBox5.Checked)
                    {
                        Decimal[] vectorSelec = (Decimal[])vector1.Clone();
                        DateTime start = DateTime.Now;
                        reales1.selectionSort(vectorSelec, vectorSelec.Length);
                        DateTime end = DateTime.Now;
                        TimeSpan finaltime = end - start;
                        textBox1.Text += "\r\nEl metodo seleccion ordenó en: " + finaltime.TotalMilliseconds + " ms";
                    }
                }
                statusTxt.Text = "Listo.";
            }
        }


        private void button3_Click_1(object sender, EventArgs e)
        {
            if (!(checkBox9.Checked || checkBox10.Checked || checkBox11.Checked || checkBox12.Checked) || listBox3.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un metodo de ordenamiento!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                textBox1.Text = "RESULTADOS:";
                Strings strings1 = new Strings();
                if (btn8Caract.Checked)
                {
                    textBox1.Text += "\r\nVector " + btn8Caract.Text + " de " + Convert.ToString(listBox3.SelectedItem) + " elementos.";
                    statusTxt.Text = "Creando vector de strings de 8 caracteres";
                    string[] vector1 = strings1.CrearVector8(Convert.ToInt32(listBox3.SelectedItem));
                    if (checkBox12.Checked)
                    {
                        string[] vectorQS = (string[])vector1.Clone();
                        statusTxt.Text = "Ordenando vector por modo " + checkBox1.Text;
                        DateTime start = DateTime.Now;
                        strings1.QuickSort(vectorQS, 0, vectorQS.Length - 1);
                        DateTime end = DateTime.Now;
                        TimeSpan finaltime = (end - start);
                        textBox1.Text += "\r\nEl ordenamiento rapido ordenó en: " + finaltime.TotalMilliseconds + " ms";
                    }
                    if (checkBox11.Checked)
                    {
                        string[] vectorBurbuja = (string[])vector1.Clone();
                        statusTxt.Text = "Ordenando vector por modo " + checkBox2.Text;
                        DateTime start = DateTime.Now;
                        strings1.BubbleSort(vectorBurbuja);
                        DateTime end = DateTime.Now;
                        TimeSpan finaltime = (end - start);
                        textBox1.Text += "\r\nEl ordenamiento burbuja ordenó en: " + finaltime.TotalMilliseconds + " ms";
                    }
                    if (checkBox10.Checked)
                    {
                        string[] vectorMerge = (string[])vector1.Clone();
                        statusTxt.Text = "Ordenando vector por modo " + checkBox3.Text;
                        DateTime start = DateTime.Now;
                        strings1.mergeSort(vectorMerge, 0, vectorMerge.Length - 1);
                        DateTime end = DateTime.Now;
                        TimeSpan finaltime = (end - start);
                        textBox1.Text += "\r\nEl metodo Merge ordenó en: " + finaltime.TotalMilliseconds + " ms";
                    }
                    if (checkBox9.Checked)
                    {
                        string[] vectorSelection = (string[])vector1.Clone();
                        statusTxt.Text = "Ordenando vector por modo " + checkBox4.Text;
                        DateTime start = DateTime.Now;
                        strings1.selectionSort(vectorSelection, vectorSelection.Length);
                        DateTime end = DateTime.Now;
                        TimeSpan finaltime = (end - start);
                        textBox1.Text += "\r\nEl metodo seleccion ordenó en: " + finaltime.TotalMilliseconds + " ms";
                    }
                }
                if (btn32Caract.Checked)
                {
                    textBox1.Text += "\r\nVector " + btn32Caract.Text + " de " + Convert.ToString(listBox3.SelectedItem) + " elementos.";
                    statusTxt.Text = "Creando vector de strings de 32 caracteres";
                    string[] vector1 = strings1.CrearVector32(Convert.ToInt32(listBox3.SelectedItem));
                    if (checkBox12.Checked)
                    {
                        string[] vectorQS = (string[])vector1.Clone();
                        statusTxt.Text = "Ordenando vector por modo " + checkBox1.Text;
                        DateTime start = DateTime.Now;
                        strings1.QuickSort(vectorQS, 0, vectorQS.Length - 1);
                        DateTime end = DateTime.Now;
                        TimeSpan finaltime = (end - start);
                        textBox1.Text += "\r\nEl ordenamiento rapido ordenó en: " + finaltime.TotalMilliseconds + " ms";
                    }
                    if (checkBox11.Checked)
                    {
                        string[] vectorBurbuja = (string[])vector1.Clone();
                        statusTxt.Text = "Ordenando vector por modo " + checkBox2.Text;
                        DateTime start = DateTime.Now;
                        strings1.BubbleSort(vectorBurbuja);
                        DateTime end = DateTime.Now;
                        TimeSpan finaltime = (end - start);
                        textBox1.Text += "\r\nEl ordenamiento burbuja ordenó en: " + finaltime.TotalMilliseconds + " ms";
                    }
                    if (checkBox10.Checked)
                    {
                        string[] vectorMerge = (string[])vector1.Clone();
                        statusTxt.Text = "Ordenando vector por modo " + checkBox3.Text;
                        DateTime start = DateTime.Now;
                        strings1.mergeSort(vectorMerge, 0, vectorMerge.Length - 1);
                        DateTime end = DateTime.Now;
                        TimeSpan finaltime = (end - start);
                        textBox1.Text += "\r\nEl metodo Merge ordenó en: " + finaltime.TotalMilliseconds + " ms";
                    }
                    if (checkBox9.Checked)
                    {
                        string[] vectorSelection = (string[])vector1.Clone();
                        statusTxt.Text = "Ordenando vector por modo " + checkBox4.Text;
                        DateTime start = DateTime.Now;
                        strings1.selectionSort(vectorSelection, vectorSelection.Length);
                        DateTime end = DateTime.Now;
                        TimeSpan finaltime = (end - start);
                        textBox1.Text += "\r\nEl metodo seleccion ordenó en: " + finaltime.TotalMilliseconds + " ms";
                    }
                }
                statusTxt.Text = "Listo.";
            }
        }
    }


}

