using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impresora3D
{
    abstract class Figura: IComparable
    {
        protected double alto;
        public string Descripcion { get; private set; }
        public Figura(double alto, string descrip)
        {
            this.alto = alto;
            Descripcion = descrip;
        }
        abstract public double Volumen();
        abstract public double Perimetro();
        public int CompareTo(Object o)
        {
            if (o != null) return Descripcion.CompareTo(((Figura)o).Descripcion);
            else return 1;
        }
    }
}
