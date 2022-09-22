using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2Guia5Ej1
{
    internal abstract class Producto:IComparable
    {
        string descripcion;
        protected double precioBase;
        protected int material;

        public Producto(string descripcion)
        {
            this.descripcion=descripcion;
        }
        public abstract double Precio();

        public int CompareTo(object objeto)
        {
            return this.descripcion.CompareTo(((Producto)objeto).descripcion);
        }
    }
}
