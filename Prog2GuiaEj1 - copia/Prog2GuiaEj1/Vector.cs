using System;

namespace Prog2GuiaEj1
{
    internal class Vector
    {
        private ushort[] arrayShort;
        private ulong[] arrayLong;
        private string[] arrayString;
        private float[] arrayFloat;
        private decimal[] arrayDecimal;

        public Vector(int valores, bool corto, double valor)
        {
            //Crea una cantidad de "valores" espacios en el arreglo
            if (corto)
            {
                float[] arrayFloat = new float[valores];
                for (int i = 0; i < arrayFloat.Length; i++)
                {
                    arrayFloat[i] = 0;
                    Random random = new Random();
                    arrayFloat[i] = Convert.ToSingle(random.NextDouble() * random.Next());
                }
            }
            else
            {
                decimal[] arrayDecimal = new decimal[valores];
                for (int i = 0; i < arrayDecimal.Length; i++)
                {
                    arrayDecimal[i] = 0;
                    Random random = new Random();
                    arrayDecimal[i] = Convert.ToDecimal(random.NextDouble() * random.NextDouble() * random.Next());
                }
            }
        }
        public Vector(int valores, bool corto, int valor)
        {
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
                    arrayLong[i] = Convert.ToUInt64(random.Next() * random.Next());
                }
            }
        }
        public Vector(int valores, bool corto, string valor)
        {
            string[] arrayString = new string[valores];                          //Crea una cantidad de "valores" espacios en el arreglo
            if (corto)                                                  //Caso de que vector sea de 8 caracteres
            {
                for (int i = 0; i < arrayString.Length; i++)
                {
                    arrayString[i] = "";
                    Random random = new Random();
                    arrayString[i] = String.Format("{0}", random.Next(10000000, 99999999));        //Convierte un numero aleatorio entre 10M y 100M en un string y lo guarda en la posicion "i"
                }
            }
            else                                                        //Caso que sea de 32 caracteres
            {
                for (int i = 0; i < arrayString.Length; i++)
                {
                    arrayString[i] = "";
                    Random random = new Random();
                    float a = Convert.ToSingle(random.Next() / random.NextDouble());
                    arrayString[i] = String.Format("{0}");
                }
            }
        }
        public ushort[] getUShort()
        {
            return arrayShort;
        }
        public ulong[] getULong()
        {
            return arrayLong;
        }
        public string[] getString()
        {
            return arrayString;
        }
        public float[] getFloat()
        {
            return arrayFloat;
        }
        public decimal[] getDecimal()
        {
            return arrayDecimal;
        }
    }
}
