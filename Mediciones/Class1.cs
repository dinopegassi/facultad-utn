using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediciones
{
    internal class Class1
    {
        private int cantidadDatos;
        private double[] valores;

        public int CantidadDatos
        {
            get
            {
                return cantidadDatos;
            }
            private set
            {
                cantidadDatos = value;
            }
        }
        public int Valores
        {
            get
            {
                return valores;
            }
            private set
            {
                valores = value;
            }
        }

        public int Medicion (int cantidad)
        {
            valores = new double[cantidad];
            cantidadDatos = 0;
        }

        public void Valor(int posicion, double dato);
        {
            
        }

        public double Promedio()
        {
            for(int i = 0; i < cantidadDatos; ++i)
            {

            }
        }

        public double Dato(int posicion)
        {
            if (posicion-1
        }

        public Menor
        public Mayor
    }
}
