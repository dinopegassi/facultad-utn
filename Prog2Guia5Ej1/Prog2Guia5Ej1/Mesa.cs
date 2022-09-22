using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2Guia5Ej1
{
    internal class Mesa:Producto
    {
        double largo;

        public Mesa(double precio, string descripcion, int material) :base (descripcion)
        {
            this.precioBase = precio;
            this.material = material;
        }

        public void Detalle(double largo)
        {
            this.largo = largo;
        }

        public override double Precio()
        {
            return (this.precioBase * largo) * (1 + material * 0.33);
        }
    }
}
