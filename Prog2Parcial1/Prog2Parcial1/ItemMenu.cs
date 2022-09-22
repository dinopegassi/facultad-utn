using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2Parcial1
{
    internal class ItemMenu
    {
        string descripcion;
        public double Precio { get; private set; }
        public ItemMenu(string descripcion, double precio)         // y el precio donde carajo lo pongo??
        {                                                          // aca es cualquiera, dice el uml que 
            this.descripcion = descripcion;                        // solo toma "descripcion" como argumento
            Precio = precio;
        }
        public string Descripcion()
        {
            return descripcion;
        }
    }
}
