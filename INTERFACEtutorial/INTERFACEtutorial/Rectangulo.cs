using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INTERFACEtutorial
{
    internal class Rectangulo : Figura
    {
        public double Ancho { get; set; }
        public double Alto { get; set; }

        public double CalcularArea()
        {
            return Ancho * Alto;
        }
    }
}
