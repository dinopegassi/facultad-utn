using System;
using System.Collections.Generic;
using System.Text;

namespace Guia8
{
    class Datos
    {
        private int cantidad=0;
        private double total=0;
        private int error=0;

        public double Total
        {
            get
            {
                return total;
            }
            set
            {
                total = value;
            }
        }

        public void Agregar(int valor)
        {
            cantidad++;
            if (valor >= 0 && valor % 2 == 0)
            {
                Total += Convert.ToDouble(valor);
            }
            else
            {
                error++;
            }
        }
        public double PorcentajeError()
        {
            return ((1.0)*error / cantidad);
        }
    }
}
