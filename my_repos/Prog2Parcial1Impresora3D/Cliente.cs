using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impresora3D
{
    class Cliente
    {
        string nombre;
        long cuit;
        public Cliente(string n, long cuit)
        {
            nombre = n;
            this.cuit = cuit;
        }
        public string ToString()
        { return "Nombre: " + nombre + " Cuit: " + cuit; }
    }
}
