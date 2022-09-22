using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARCIAL
{
    class Control
    {
        private int[] tiempos;
        private int menorTiempo;
        private int menorVuelta;
        private int vueltasMayores;
        private double promedio;
        public int Vueltas
        {
            get
            {
                return tiempos.Length;
            }
        }
        public int VueltaMenor
        {
            get
            {
                return menorVuelta;
            }
        }
        public int VueltasMayor
        {
            get
            {
                return vueltasMayores;
            }
            private set
            {
                vueltasMayores = value;
            }
        }

        public Control(int totalVueltas)
        {
            int[] tiempos = new int[totalVueltas];
        }
        public void AgregarTiempo(int seg)
        {
            XXXXX = seg;
        }
        public void ContarVueltasMayores()
        {

        }
        public double VerPromedio()
        {
            return this.promedio;
        }
    }
}
