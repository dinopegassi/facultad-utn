using System;
using System.Diagnostics;

namespace Clase25
{
    internal class ClaseImportante
    {
        string[] arrayString;
        byte[] arrayByte;
        int[] arrayInt;
        float[] arrayFloat;
        decimal[] arrayDecimal;

        //Constructores:
        public ClaseImportante(int valores, string marcador)    //string[] cosito
        {
            arrayString = new string[valores];
            //int lugar;
            for (int i = 0; i < valores; i++)
            {
                arrayString[i] = "";
                Random azar = new Random(i - Convert.ToInt32(marcador));
                arrayString[i] = azar.Next(0, 50).ToString();
                //lugar = azar.Next(cosito.Length);
                //cosoString[i]=cosito[lugar];
            }
            arrayByte = new byte[] { 0 };
            arrayInt = new int[] { 0 };
            arrayFloat = new float[] { 0 };
            arrayDecimal = new decimal[] { 0 };
        }
        public ClaseImportante(int valores, int marcador)
        {
            arrayInt = new int[valores];
            for (int i = 0; i < valores; i++)
            {
                Random azar = new Random(i - Convert.ToInt32(marcador));
                arrayInt[i] = Convert.ToInt32(azar.Next(0, 50));
            }
            arrayByte = new byte[] { 0 };
            arrayString = new string[] { "" };
            arrayFloat = new float[] { 0 };
            arrayDecimal = new decimal[] { 0 };
        }
        public ClaseImportante(int valores, byte marcador)
        {
            arrayByte = new byte[valores];
            Random azar = new Random();
            azar.NextBytes(arrayByte);
            arrayInt = new int[] { 0 };
            arrayString = new string[] { "" };
            arrayFloat = new float[] { 0 };
            arrayDecimal = new decimal[] { 0 };
        }
        public ClaseImportante(int valores, float marcador)
        {
            arrayFloat = new float[valores];
            for (int i = 0; i < valores; i++)
            {
                Random azar = new Random(i - Convert.ToInt32(marcador));
                arrayFloat[i] = (float)azar.NextDouble() * azar.Next(0, 50);
            }
            arrayByte = new byte[] { 0 };
            arrayString = new string[] { "" };
            arrayInt = new int[] { 0 };
            arrayDecimal = new decimal[] { 0 };
        }
        public ClaseImportante(int valores, decimal marcador)
        {
            arrayDecimal = new decimal[valores];
            for (int i = 0; i < valores; i++)
            {
                Random azar = new Random(i - Convert.ToInt32(marcador));
                arrayDecimal[i] = (decimal)azar.NextDouble() * azar.Next(0, 50);
            }
            arrayByte = new byte[] { 0 };
            arrayString = new string[] { "" };
            arrayFloat = new float[] { 0 };
            arrayInt = new int[] { 0 };
        }

        //rangoInicial=Length/4

        //Busqueda:
        public double[] BuscarIndiceArray(string valorBuscado)
        {
            double[] auxiliar = new double[5];
            int i = 0;
            int contExitos = 0;
            double suma = 0;

            Stopwatch reloj = new Stopwatch();
            reloj.Start();

            while (i < arrayString.Length && contExitos < 6)
            {
                if (valorBuscado == arrayString[i])
                {
                    if (i >= 0 && i < Convert.ToInt32(arrayString.Length / 4))
                    {
                        contExitos++;
                    }
                }
                i++;
            }
            reloj.Stop();
            auxiliar[0] = reloj.Elapsed.TotalMilliseconds;


            i = 0;
            contExitos = 0;
            reloj.Reset();
            reloj.Start();
            while (i < arrayString.Length && contExitos < 6)
            {
                if (valorBuscado == arrayString[i])
                {
                    if (i >= Convert.ToInt32(arrayString.Length / 4) && i < Convert.ToInt32(arrayString.Length / 2))
                    {
                        contExitos++;
                    }
                }
                i++;
            }
            reloj.Stop();
            auxiliar[1] = reloj.Elapsed.TotalMilliseconds;

            i = 0;
            contExitos = 0;
            reloj.Reset();
            reloj.Start();
            while (i < arrayString.Length && contExitos < 6)
            {
                if (valorBuscado == arrayString[i])
                {
                    if (i >= Convert.ToInt32(arrayString.Length * 3 / 4) && i < arrayString.Length)
                    {
                        contExitos++;
                    }
                }
                i++;
            }
            reloj.Stop();
            auxiliar[2] = reloj.Elapsed.TotalMilliseconds;

            i = 0;
            contExitos = 0;
            reloj.Reset();
            reloj.Start();
            while (i < arrayString.Length)
            {
                i++;
            }
            reloj.Stop();
            auxiliar[3] = reloj.Elapsed.TotalMilliseconds;

            i = 0;
            contExitos = 0;
            reloj.Reset();

            foreach (double valor in auxiliar)
            {
                suma += valor;
            }
            auxiliar[4] = suma / 4;

            return auxiliar;
            //reloj.Start();
            //while (i < arrayString.Length)
            //{
            //    i++;
            //}
            //reloj.Stop();
            //auxiliar[3] = reloj.Elapsed.TotalMilliseconds;
        }
        public double[] BuscarIndiceArray(byte valorBuscado)
        {
            //int i = 0;
            //Stopwatch sw = new Stopwatch();
            //sw.Start();
            //while (valorBuscado != arrayByte[i] || i > arrayByte.Length - 1)
            //{
            //    i++;
            //}
            //sw.Stop();
            //return sw.Elapsed.TotalMilliseconds;
            double[] auxiliar = new double[5];
            int i = 0;
            int contExitos = 0;
            double suma = 0;

            Stopwatch reloj = new Stopwatch();
            reloj.Start();

            while (i < arrayByte.Length && contExitos < 6)
            {
                if (valorBuscado == arrayByte[i])
                {
                    if (i >= 0 && i < Convert.ToInt32(arrayByte.Length / 4))
                    {
                        contExitos++;
                    }
                }
                i++;
            }
            reloj.Stop();
            auxiliar[0] = reloj.Elapsed.TotalMilliseconds;


            i = 0;
            contExitos = 0;
            reloj.Reset();
            reloj.Start();
            while (i < arrayByte.Length && contExitos < 6)
            {
                if (valorBuscado == arrayByte[i])
                {
                    if (i >= Convert.ToInt32(arrayByte.Length / 4) && i < Convert.ToInt32(arrayByte.Length / 2))
                    {
                        contExitos++;
                    }
                }
                i++;
            }
            reloj.Stop();
            auxiliar[1] = reloj.Elapsed.TotalMilliseconds;

            i = 0;
            contExitos = 0;
            reloj.Reset();
            reloj.Start();
            while (i < arrayByte.Length && contExitos < 6)
            {
                if (valorBuscado == arrayByte[i])
                {
                    if (i >= Convert.ToInt32(arrayByte.Length * 3 / 4) && i < arrayByte.Length)
                    {
                        contExitos++;
                    }
                }
                i++;
            }
            reloj.Stop();
            auxiliar[2] = reloj.Elapsed.TotalMilliseconds;

            i = 0;
            contExitos = 0;
            reloj.Reset();
            reloj.Start();
            while (i < arrayByte.Length)
            {
                i++;
            }
            reloj.Stop();
            auxiliar[3] = reloj.Elapsed.TotalMilliseconds;

            i = 0;
            contExitos = 0;
            reloj.Reset();

            foreach (double elemento in auxiliar)
            //for (int ind = 0; ind < 4; ind++)
            {
                suma += auxiliar[i];
            }
            auxiliar[4] = suma / 4;

            return auxiliar;
        }
        public double[] BuscarIndiceArray(int valorBuscado)
        {
            //int i = 0;
            //Stopwatch sw = new Stopwatch();
            //sw.Start();
            //while (valorBuscado != arrayInt[i] || i > arrayInt.Length - 1)
            //{
            //    i++;
            //}
            //sw.Stop();
            //return sw.Elapsed.TotalMilliseconds;
            double[] auxiliar = new double[5];
            int i = 0;
            int contExitos = 0;
            double suma = 0;

            Stopwatch reloj = new Stopwatch();
            reloj.Start();

            while (i < arrayInt.Length && contExitos < 6)
            {
                if (valorBuscado == arrayInt[i])
                {
                    if (i >= 0 && i < Convert.ToInt32(arrayInt.Length / 4))
                    {
                        contExitos++;
                    }
                }
                i++;
            }
            reloj.Stop();
            auxiliar[0] = reloj.Elapsed.TotalMilliseconds;


            i = 0;
            contExitos = 0;
            reloj.Reset();
            reloj.Start();
            while (i < arrayInt.Length && contExitos < 6)
            {
                if (valorBuscado == arrayInt[i])
                {
                    if (i >= Convert.ToInt32(arrayInt.Length / 4) && i < Convert.ToInt32(arrayInt.Length / 2))
                    {
                        contExitos++;
                    }
                }
                i++;
            }
            reloj.Stop();
            auxiliar[1] = reloj.Elapsed.TotalMilliseconds;

            i = 0;
            contExitos = 0;
            reloj.Reset();
            reloj.Start();
            while (i < arrayInt.Length && contExitos < 6)
            {
                if (valorBuscado == arrayInt[i])
                {
                    if (i >= Convert.ToInt32(arrayInt.Length * 3 / 4) && i < arrayInt.Length)
                    {
                        contExitos++;
                    }
                }
                i++;
            }
            reloj.Stop();
            auxiliar[2] = reloj.Elapsed.TotalMilliseconds;

            i = 0;
            contExitos = 0;
            reloj.Reset();
            reloj.Start();
            while (i < arrayInt.Length)
            {
                i++;
            }
            reloj.Stop();
            auxiliar[3] = reloj.Elapsed.TotalMilliseconds;

            i = 0;
            contExitos = 0;
            reloj.Reset();

            foreach (double valor in auxiliar)
            {
                suma += valor;
            }
            auxiliar[4] = suma / 4;

            return auxiliar;
        }
        public double[] BuscarIndiceArray(float valorBuscado)
        {
            //int i = 0;
            //Stopwatch sw = new Stopwatch();
            //sw.Start();
            //while (valorBuscado != arrayFloat[i] || i > arrayFloat.Length - 1)
            //{
            //    i++;
            //}
            //sw.Stop();
            //return sw.Elapsed.TotalMilliseconds;
            double[] auxiliar = new double[5];
            int i = 0;
            int contExitos = 0;
            double suma = 0;

            Stopwatch reloj = new Stopwatch();
            reloj.Start();

            while (i < arrayFloat.Length && contExitos < 6)
            {
                if (valorBuscado == arrayFloat[i])
                {
                    if (i >= 0 && i < Convert.ToInt32(arrayFloat.Length / 4))
                    {
                        contExitos++;
                    }
                }
                i++;
            }
            reloj.Stop();
            auxiliar[0] = reloj.Elapsed.TotalMilliseconds;


            i = 0;
            contExitos = 0;
            reloj.Reset();
            reloj.Start();
            while (i < arrayFloat.Length && contExitos < 6)
            {
                if (valorBuscado == arrayFloat[i])
                {
                    if (i >= Convert.ToInt32(arrayFloat.Length / 4) && i < Convert.ToInt32(arrayFloat.Length / 2))
                    {
                        contExitos++;
                    }
                }
                i++;
            }
            reloj.Stop();
            auxiliar[1] = reloj.Elapsed.TotalMilliseconds;

            i = 0;
            contExitos = 0;
            reloj.Reset();
            reloj.Start();
            while (i < arrayFloat.Length && contExitos < 6)
            {
                if (valorBuscado == arrayFloat[i])
                {
                    if (i >= Convert.ToInt32(arrayFloat.Length * 3 / 4) && i < arrayFloat.Length)
                    {
                        contExitos++;
                    }
                }
                i++;
            }
            reloj.Stop();
            auxiliar[2] = reloj.Elapsed.TotalMilliseconds;

            i = 0;
            contExitos = 0;
            reloj.Reset();
            reloj.Start();
            while (i < arrayFloat.Length)
            {
                i++;
            }
            reloj.Stop();
            auxiliar[3] = reloj.Elapsed.TotalMilliseconds;

            i = 0;
            contExitos = 0;
            reloj.Reset();

            foreach (double valor in auxiliar)
            {
                suma += valor;
            }
            auxiliar[4] = suma / 4;

            return auxiliar;
        }
        public double[] BuscarIndiceArray(decimal valorBuscado)
        {
            //int i = 0;
            //Stopwatch sw = new Stopwatch();
            //sw.Start();
            //while (valorBuscado != arrayDecimal[i] || i>arrayDecimal.Length-1)
            //{
            //    i++;
            //}
            //sw.Stop();
            //return sw.Elapsed.TotalMilliseconds;
            double[] auxiliar = new double[5];
            int i = 0;
            int contExitos = 0;
            double suma = 0;

            Stopwatch reloj = new Stopwatch();
            reloj.Start();

            while (i < arrayDecimal.Length && contExitos < 6)
            {
                if (valorBuscado == arrayDecimal[i])
                {
                    if (i >= 0 && i < Convert.ToInt32(arrayDecimal.Length / 4))
                    {
                        contExitos++;
                    }
                }
                i++;
            }
            reloj.Stop();
            auxiliar[0] = reloj.Elapsed.TotalMilliseconds;


            i = 0;
            contExitos = 0;
            reloj.Reset();
            reloj.Start();
            while (i < arrayDecimal.Length && contExitos < 6)
            {
                if (valorBuscado == arrayDecimal[i])
                {
                    if (i >= Convert.ToInt32(arrayDecimal.Length / 4) && i < Convert.ToInt32(arrayDecimal.Length / 2))
                    {
                        contExitos++;
                    }
                }
                i++;
            }
            reloj.Stop();
            auxiliar[1] = reloj.Elapsed.TotalMilliseconds;

            i = 0;
            contExitos = 0;
            reloj.Reset();
            reloj.Start();
            while (i < arrayDecimal.Length && contExitos < 6)
            {
                if (valorBuscado == arrayDecimal[i])
                {
                    if (i >= Convert.ToInt32(arrayDecimal.Length * 3 / 4) && i < arrayDecimal.Length)
                    {
                        contExitos++;
                    }
                }
                i++;
            }
            reloj.Stop();
            auxiliar[2] = reloj.Elapsed.TotalMilliseconds;

            i = 0;
            contExitos = 0;
            reloj.Reset();
            reloj.Start();
            while (i < arrayDecimal.Length)
            {
                i++;
            }
            reloj.Stop();
            auxiliar[3] = reloj.Elapsed.TotalMilliseconds;

            i = 0;
            contExitos = 0;
            reloj.Reset();

            foreach (double valor in auxiliar)
            {
                suma += valor;
            }
            auxiliar[4] = suma / 4;

            return auxiliar;
        }

        public int VerByteLength()
        {
            return arrayByte.Length;
        }
        public int VerStringLength()
        {
            return arrayString.Length;
        }
        public int VerDecimalLength()
        {
            return arrayDecimal.Length;
        }
        public int VerFloatLength()
        {
            return arrayFloat.Length;
        }
        public int VerIntLength()
        {
            return arrayInt.Length;
        }
    }
}
