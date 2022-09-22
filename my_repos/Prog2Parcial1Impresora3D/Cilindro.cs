using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impresora3D
{
    class Cilindro : Figura
    {
        double radio;
        public Cilindro(double radio, double alto) : base(alto, "Pisma de " + alto + " cm")
        {
            this.radio = radio;
        }
        public override double Volumen()
        {
            return Math.PI * (radio * radio) * alto;
        }
        public override double Perimetro()
        {
            return (2 * Math.PI * radio) * alto;
        }
    }
}
