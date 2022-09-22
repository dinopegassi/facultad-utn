using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2Guia5Ej1
{
    internal class Silla : Producto
    {
        public Silla(double precio, string descripcion, int material) : base(descripcion)
        {
            this.material = material;
            this.precioBase = precio;
        }

        public override double Precio()
        {
            return precioBase * (1 + material * 0.25);
        }
    }
}
