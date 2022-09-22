using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2Guia7Ej1
{
    internal class Juego
    {
        public int CantActores { get; }
        public int Renglones { get; }
        public int Columnas { get; }
        public int Zeldas { get; }
        public static Random Azar { get; private set; }
        ArrayList actores;
        public Juego(int cantActores, int renglones, int columnas)
        {
            actores = new ArrayList();
            Azar = new Random();
            CantActores = cantActores;
            for (int i = 0; i < cantActores; i++)
            {
                actores.Add(new Personaje());
            }
            Renglones = renglones;
            Columnas = columnas;
            Zeldas = columnas * renglones;
        }
        public void MoverTodos()
        {

        }
        public Personaje LeerActor(int posicion)
        {
            return null;
        }
        public int ToCeldaIndice(int renglon, int columna)
        {
            return (renglon - 1) * this.Columnas + columna;
        }
        public void ToRenglonColumna(int celda,out int renglon, out int columna)
        {
            renglon = (int)(celda / this.Columnas);
            columna = (int)(celda % this.Columnas);
        }
    }
}
