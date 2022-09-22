using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2TP1
{
    internal class Queso:IComparable
    {
        public int CompareTo(Object o)
        {
            if (o != null)
                return Posicion[0].CompareTo(((Queso)o).Posicion[0]);
            else return 1;
        }
        static int genericID;
        int id;
        public int Porcion { get; private set; }
        public int[] Posicion { get; private set; }           // no se guarda la posicion como un arreglo, sino como dos variables
        public Queso(int x, int y)
        {
            id = genericID++;
            Posicion = new int[2];
            Posicion[0] = x;
            Posicion[1] = y;
            Porcion = 2;
        }
        public void AgregarRaciones()            // agregarRaciones() añade el doble de porciones
        {                                               // porque una racion son dos porciones
            this.Porcion += 2;
        }
        public void NerfearRacion()
        {
            this.Porcion--;
            if (Porcion == 0)
            { /*disposearlo();*/}
        }
        override public string ToString()
        { return "Queso" + id; }

    }
}
