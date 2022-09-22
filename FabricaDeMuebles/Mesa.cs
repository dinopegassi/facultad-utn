using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaDeMuebles
{
    class Mesa : Producto
    {
        double largo;
        public Mesa(double precioBase,
        string descripcion) : base(descripcion)
        {
            this.precioBase = precioBase;
        }
        public void Detalle(double largo, int material)
        {
            this.largo = largo;
            this.material = material;
        }
        override public double Precio()
        {
            return (precioBase * largo) * (1 + material * 0.33);
        }
    }
}
