using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2GUIA2EJ1
{
    internal class Tiempo
    {
        int hora, minuto, segundo;
        public Tiempo(int hora, int minuto, int segundo)
        {
            this.hora = hora;
            this.minuto = minuto;
            this.segundo = segundo;
        }
        public Tiempo(int hora, int minuto) : this(hora, minuto, 0)
        {

        }
        public Tiempo(int hora):this(hora, 0,0)
        {

        }
        public Tiempo():this(1,2,3)
        {

        }

        
    }
}
