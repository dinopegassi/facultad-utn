using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Prog2GuiaEj1
{
    internal class Vector
    {
        private ushort[] arrayShort;
        private ulong[] arrayLong;
        private string[] arrayString;
        private float[] arrayFloat;
        private decimal[] arrayDecimal;
        
        public ushort[] arrayShortCOPIA1 { get; private set; }
        public ushort[] arrayShortCOPIA2 { get; private set; }
        public ushort[] arrayShortCOPIA3 { get; private set; }
        public ushort[] arrayShortCOPIA4 { get; private set; }
        public ushort[] arrayShortCOPIA5 { get; private set; }

        
        public ulong[] arrayLongCOPIA1 { get; private set; }
        public ulong[] arrayLongCOPIA2 { get; private set; }
        public ulong[] arrayLongCOPIA3 { get; private set; }
        public ulong[] arrayLongCOPIA4 { get; private set; }
        public ulong[] arrayLongCOPIA5 { get; private set; }


        public float[] arrayFloatCOPIA1 { get; private set; }
        public float[] arrayFloatCOPIA2 { get; private set; }
        public float[] arrayFloatCOPIA3 { get; private set; }
        public float[] arrayFloatCOPIA4 { get; private set; }
        public float[] arrayFloatCOPIA5 { get; private set; }


        public decimal[] arrayDecimalCOPIA1 { get; private set; }
        public decimal[] arrayDecimalCOPIA2 { get; private set; }
        public decimal[] arrayDecimalCOPIA3 { get; private set; }
        public decimal[] arrayDecimalCOPIA4 { get; private set; }
        public decimal[] arrayDecimalCOPIA5 { get; private set; }


        public string[] arrayStringCOPIA1 { get; private set; }
        public string[] arrayStringCOPIA2 { get; private set; }
        public string[] arrayStringCOPIA3 { get; private set; }
        public string[] arrayStringCOPIA4 { get; private set; }
        public string[] arrayStringCOPIA5 { get; private set; }

        // SEMILLA ---
        Random rand = new Random();

        public Vector(int tamaño)
        {   // SHORT ---
            arrayShort = new ushort[tamaño];
            for (int i = 0; i < tamaño; i++)
            {
                arrayShort[i] = (ushort)rand.Next(0, ushort.MaxValue);
            }
            arrayShortCOPIA1 = (ushort[])arrayShort.Clone();
            arrayShortCOPIA2 = (ushort[])arrayShort.Clone();
            arrayShortCOPIA3 = (ushort[])arrayShort.Clone();
            arrayShortCOPIA4 = (ushort[])arrayShort.Clone();
            arrayShortCOPIA5 = (ushort[])arrayShort.Clone();
            // LONG ---
            arrayLong = new ulong[tamaño];
            for (int i = 0; i < tamaño; i++)
            {
                arrayLong[i] = (ulong)(rand.Next(0, Int32.MaxValue));
            }
            arrayLongCOPIA1 = (ulong[])arrayLong.Clone();
            arrayLongCOPIA2 = (ulong[])arrayLong.Clone();
            arrayLongCOPIA3 = (ulong[])arrayLong.Clone();
            arrayLongCOPIA4 = (ulong[])arrayLong.Clone();
            arrayLongCOPIA5 = (ulong[])arrayLong.Clone();
            // FLOAT ---
            arrayFloat = new float[tamaño];
            for (int i = 0; i < tamaño; i++)
            {
                arrayFloat[i] = (float)rand.Next(0, Int32.MaxValue);
            }
            arrayFloatCOPIA1 = (float[])arrayFloat.Clone();
            arrayFloatCOPIA2 = (float[])arrayFloat.Clone();
            arrayFloatCOPIA3 = (float[])arrayFloat.Clone();
            arrayFloatCOPIA4 = (float[])arrayFloat.Clone();
            arrayFloatCOPIA5 = (float[])arrayFloat.Clone();
            // DECIMAL ---
            arrayDecimal = new decimal[tamaño];
            for (int i = 0; i < tamaño; i++)
            {
                arrayDecimal[i] = (decimal)rand.Next(0, Int32.MaxValue);
            }
            arrayDecimalCOPIA1 = (decimal[])arrayDecimal.Clone();
            arrayDecimalCOPIA2 = (decimal[])arrayDecimal.Clone();
            arrayDecimalCOPIA3 = (decimal[])arrayDecimal.Clone();
            arrayDecimalCOPIA4 = (decimal[])arrayDecimal.Clone();
            arrayDecimalCOPIA5 = (decimal[])arrayDecimal.Clone();
            // STRING ---
            arrayString = new string[tamaño];
            for (int i = 0; i < tamaño; i++)
            {
                arrayString[i] = (rand.Next(0, Int32.MaxValue)).ToString();
            }
            arrayStringCOPIA1 = (string[])arrayString.Clone();
            arrayStringCOPIA1 = (string[])arrayString.Clone();
            arrayStringCOPIA1 = (string[])arrayString.Clone();
            arrayStringCOPIA1 = (string[])arrayString.Clone();
            arrayStringCOPIA1 = (string[])arrayString.Clone();

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


        //public Vector(int valores, bool corto, double valor)
        //{
        //    //Crea una cantidad de "valores" espacios en el arreglo
        //    if (corto)
        //    {
        //        float[] arrayFloat = new float[valores];
        //        for (int i = 0; i < arrayFloat.Length; i++)
        //        {
        //            arrayFloat[i] = 0;
        //            Random random = new Random();
        //            arrayFloat[i] = Convert.ToSingle(random.NextDouble() + random.Next());
        //        }
        //    }
        //    else
        //    {
        //        decimal[] arrayDecimal = new decimal[valores];
        //        for (int i = 0; i < arrayDecimal.Length; i++)
        //        {
        //            arrayDecimal[i] = 0;
        //            Random random = new Random();
        //            arrayDecimal[i] = Convert.ToDecimal(random.NextDouble() * random.NextDouble() + random.Next());
        //        }
        //    }
        //}
        //public Vector(int valores, bool corto, int valor)
        //{
        //    if (corto)
        //    {
        //        ushort[] arrayShort = new ushort[valores];
        //        for (int i = 0; i < arrayShort.Length; i++)
        //        {
        //            arrayShort[i] = 0;
        //            Random random = new Random();
        //            arrayShort[i] = Convert.ToUInt16(random.Next(0, 65535));
        //        }
        //    }
        //    else
        //    {
        //        ulong[] arrayLong = new ulong[valores];
        //        for (int i = 0; i < arrayLong.Length; i++)
        //        {
        //            arrayLong[i] = 0;
        //            Random random = new Random();
        //            arrayLong[i] = Convert.ToUInt64(random.Next() * random.Next());
        //        }
        //    }
        //}
        //public Vector(int valores, bool corto, string valor)
        //{
        //    string[] arrayString = new string[valores];                          //Crea una cantidad de "valores" espacios en el arreglo
        //    if (corto)                                                  //Caso de que vector sea de 8 caracteres
        //    {
        //        for (int i = 0; i < arrayString.Length; i++)
        //        {
        //            arrayString[i] = "";
        //            Random random = new Random();
        //            arrayString[i] = String.Format("{0}", random.Next(10000000, 99999999));        //Convierte un numero aleatorio entre 10M y 100M en un string y lo guarda en la posicion "i"
        //        }
        //    }
        //    else                                                        //Caso que sea de 32 caracteres
        //    {
        //        for (int i = 0; i < arrayString.Length; i++)
        //        {
        //            arrayString[i] = "";
        //            Random random = new Random();
        //            float a = Convert.ToSingle(random.Next() / random.NextDouble());
        //            arrayString[i] = String.Format("{0}");
        //        }
        //    }
        //}

    }
}
