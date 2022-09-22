using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2TP1
{
    abstract internal class Animal:IComparable
    {
        protected int columnaF, renglonF;
        public int[] Posicion { get; set; }           // no se guarda la posicion como un arreglo, sino como dos variables
        public bool Vivo { get; set; }
        public int DiasSinComer { get; set;}
        protected int CantidadDeComidasEnElDia { get; set; }

        public Animal(int x, int y)
        {
            columnaF = 999999; //pasar valor
            renglonF = 999999;
            Posicion = new int[2];
            Posicion[0] = x;
            Posicion[1] = y;
            DiasSinComer = 0;
            Vivo = true;
        }
        public int CompareTo(Object o)
        {
            if (o != null)
                return Posicion[0].CompareTo(((Animal)o).Posicion[0]);
            else return 1;
        }
        public abstract bool Mover();
        abstract public string Comer(Object victima);
        public abstract void Morir();
    }
}
