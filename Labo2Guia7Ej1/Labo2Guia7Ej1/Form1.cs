using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labo2Guia7Ej1
{
    public partial class Form1 : Form, IObservador
    {
        Juego juego;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            juego = new Juego((int)numericUpDown1.Value, (int)numericUpDown2.Value, (int)numericUpDown3.Value);
            
            //esto hace que puedas elegir una celda en el datagrid
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;

            //esto son giladas para enchetecer el dGv
            dataGridView1.BackgroundColor = Color.Aquamarine;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            
            //aca esta lo jugoso... numero de columnas y filas que hay que colocar en el dGv
            dataGridView1.ColumnCount = (int)numericUpDown3.Value;
            dataGridView1.RowCount = (int)numericUpDown2.Value;

            



            //esta chingada hace que el ancho y alto de celdas se rellene perfectamente al tamanio del form
            //foreach ()



            for (int i = 0; i < juego.CantActores; i++)
            {
                juego.LeerActor(i).AgregarObservador(this);
            }
        }
        public void NotificarPosicion(IObservable sender)
        {
            Personaje jug = (Personaje)sender;

            int i, j;
            string descripcion = jug.ToString();
            /*
             el formulario consigue del sujeto (el personaje) su posición anterior, 
            luego la toma y la convierte en (i,j). Con esta posición (i,j) puede 
            quitar la marca de esa celda para indicar al usuario que ya no está ahí.
             */
            juego.ToRenglonColumna(jug.PosicionAnterior,out i,out j);

            juego.ToRenglonColumna(jug.PosicionActual, out i, out j);
        }
    }
}
