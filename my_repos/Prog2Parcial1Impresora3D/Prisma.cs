using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impresora3D
{
    class Prisma:Figura
    {
        double largo, ancho;
        public Prisma(double largo, double ancho, double alto) :base(alto,"Pisma de "+alto+" cm")
        {
            this.largo = largo;
            this.ancho = ancho;
        }
        public override double Volumen()
        {
            return largo * ancho * alto;
        }
        public override double Perimetro()
        {
            return (2 * largo + 2 * ancho) * alto;
        }
    }
}
