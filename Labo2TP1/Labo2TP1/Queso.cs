using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2TP1
{
    internal class Queso
    {
        public int Porcion { get; private set; }
        public int[] Posicion { get; private set; }
        public Queso()
        {
            Porcion = 2;
        }
        public void AgregarPorciones(int nro)
        {
            this.Porcion += nro;
        }
    }
}
