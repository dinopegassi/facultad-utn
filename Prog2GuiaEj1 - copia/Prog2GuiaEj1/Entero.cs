using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2GuiaEj1
{
    internal class Entero
    {
        //Constructor
        public Entero(int valores,bool corto)
        {
                                 //Crea una cantidad de "valores" espacios en el arreglo
            if (corto)                                                 
            {
                ushort[] arrayShort = new ushort[valores];
                for (int i = 0; i < arrayShort.Length; i++)
                {
                    arrayShort[i] = 0;
                    Random random = new Random();
                    arrayShort[i] = Convert.ToUInt16(random.Next(0, 65535));       
                }
            }
            else                                         
            {
                ulong[] arrayLong = new ulong[valores];
                for (int i = 0; i < arrayLong.Length; i++)
                {
                    arrayLong[i] = 0;
                    Random random = new Random();
                    arrayLong[i] = Convert.ToUInt64(random.Next()*random.Next());
                }
            }
        }
    }
}
