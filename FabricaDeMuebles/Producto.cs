using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaDeMuebles
{
    abstract class Producto : IComparable
    {
        string descripcion;
        protected double precioBase;
        protected int material;
        public Producto(string descripcion)
        {
            this.descripcion = descripcion;
        }
        abstract public double Precio();
        public int CompareTo(object obj)
        {
            Producto prod = (Producto)obj;
            return descripcion.CompareTo(prod.descripcion);
        }
        override public string ToString()
        {
            return descripcion;
        }
    }
}
