using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2GuiaEj1
{
    internal class Cadena
    {
        string[] arrayString;

        //Constructor
        public Cadena(int valores, bool corto)
        {
            arrayString = new string[valores];                          //Crea una cantidad de "valores" espacios en el arreglo
            if (corto)                                                  //Caso de que vector sea de 8 caracteres
            {
                for (int i = 0; i < arrayString.Length; i++)
                {
                    arrayString[i] = "";
                    Random random = new Random();
                    arrayString[i] = String.Format("{0}",random.Next(10000000,99999999));        //Convierte un numero aleatorio entre 10M y 100M en un string y lo guarda en la posicion "i"
                }
            }
            else                                                        //Caso que sea de 32 caracteres
            {
                for (int i = 0; i < arrayString.Length; i++)
                {
                    arrayString[i] = "";
                    Random random = new Random();
                    float a = Convert.ToSingle(random.Next()/random.NextDouble());
                    arrayString[i] = String.Format("{0}");
                }
            }
        }
    }
}
