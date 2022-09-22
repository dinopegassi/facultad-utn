using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2TP1
{
    abstract internal class Animal
    {
        protected int[] Posicion {get; set;}
        protected int DiasSinComer { get; set;}
        public Animal(int[] posicion)
        {
            Posicion = new int[2];
            Posicion = posicion;
            DiasSinComer = 0;
        }
        public abstract void Mover();
        public abstract void Comer();
        public abstract void Vivir();
    }
}
