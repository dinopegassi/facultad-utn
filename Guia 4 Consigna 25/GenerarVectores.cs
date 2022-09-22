using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Guia_4_Consigna_25
{
    internal class GenerarVectores
    {
        
        private Random random = new Random();
        /*                                          Metodos de Busqueda                                 */
        private double Busqueda(int rI, int rS,byte[] vec,bool error)
        {
            int cont = rI;
            byte n;
            int aciertos=0;
            bool fs1 = true;
            Stopwatch sw =  new Stopwatch();
            sw.Start();
            while (aciertos<5)
            {
                if (error)
                    n = Convert.ToByte(random.Next(0, 50));
                else
                    n = 51;
                
                cont = rI;
                do
                {              
                    if (n == vec[cont])
                    {
                        
                        fs1 = false; 
                        aciertos++;
                    }
                    cont++;
                } while (cont < rS && fs1);
                if (!error)
                    aciertos++;
            }
            sw.Stop();
            return sw.Elapsed.TotalMilliseconds; ;
        }
        private double Busqueda(int rI, int rS, int[] vec, bool error)
        {           
            int cont;
            int n;
            int aciertos = 0;
            bool fs1 = true;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            while (aciertos < 5)
            {
                if (error)
                    n = random.Next(0, 50);
                else
                    n = 51;
                
                cont = rI;
                do
                {
                    if (n == vec[cont])
                    {
                       
                        fs1 = false;
                        aciertos++;
                    }
                    cont++;
                } while (cont < rS && fs1);
                if (!error)
                    aciertos++;
            }
            sw.Stop();
            return sw.Elapsed.TotalMilliseconds;
        }
        private double Busqueda(int rI, int rS, float[] vec, bool error)
        {         
            int cont;
            float n;
            int aciertos = 0;
            bool fs1 = true;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            while (aciertos < 5)
            {
                if (error)
                    n = Convert.ToSingle(random.NextDouble());
                else
                    n = 51;                
                cont = rI;
                do
                {
                    if (n == vec[cont])
                    {   
                        fs1 = false;
                        aciertos++;
                    }
                    cont++;
                } while (cont < rS && fs1);
                if (!error)
                    aciertos++;
            }
            sw.Stop();
            return sw.Elapsed.TotalMilliseconds;
        }
        private double Busqueda(int rI, int rS, decimal[] vec, bool error)
        {
            int cont;
            decimal n;
            int aciertos = 0;
            bool fs1 = true;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            while (aciertos < 5)
            {
                if (error)
                    n = Math.Round(Convert.ToDecimal(random.NextDouble()), 10);
                else
                    n = 51;
                cont = rI;
                do
                {
                    if (n == vec[cont])
                    {
                        fs1 = false;
                        aciertos++;
                    }
                    cont++;
                } while (cont < rS && fs1);
                if (!error)
                    aciertos++;
            }
            sw.Stop();
            return sw.Elapsed.TotalMilliseconds;
        }
        private double Busqueda(int rI, int rS, string[] vec, bool error)
        {
            int cont;
            string n;
            int aciertos = 0;
            bool fs1 = true;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            while (aciertos < 5)
            {
                if (error)
                    n = Convert.ToString(random.Next(0, 50));
                else
                    n = 51.ToString();
                cont = rI;
                do
                {
                    if (n == vec[cont])
                    {
                        fs1 = false;
                        aciertos++;
                    }
                    cont++;
                } while (cont < rS && fs1);
                if (!error)
                    aciertos++;
            }
            sw.Stop();
            return sw.Elapsed.TotalMilliseconds;
        }

        /*                                          Tipos de Busqueda                                 */
        public double[] BusquedaByte(int tamaño)
        {
            double[] retorno = new double[5];
            byte[] vector = new byte[tamaño];            
            for (int i = 0; i < tamaño; i++)
                vector[i] = Convert.ToByte(random.Next(0, 50));

           // Busqueda1
           retorno[0] = Busqueda(0, (tamaño/4)-1, vector,true);
           //Busqueda2
           retorno[1] = Busqueda(tamaño / 4, (tamaño / 2) - 1, vector, true);
           //Busqueda3
           retorno[2] = Busqueda(tamaño*(1/4), tamaño-1, vector, true);
           //Busqueda4
           retorno[3] = Busqueda(tamaño / 2, (tamaño*(1/4))-1, vector, false);
            //Promedio
            for (int i = 0; i < 4; i++)
                retorno[4] += retorno[i];
            retorno[4] /= (1.0 *4);           
            return retorno;
        }
        public double[] BusquedaInt(int tamaño)
        {
            double[] retorno = new double[5];
            int[] vector = new int[tamaño];
            for (int i = 0; i < tamaño; i++)
                vector[i] = random.Next(0, 50);

            // Busqueda1
            retorno[0] = Busqueda(0, (tamaño / 4) - 1, vector, true);
            //Busqueda2
            retorno[1] = Busqueda(tamaño / 4, (tamaño / 2) - 1, vector, true);
            //Busqueda3
            retorno[2] = Busqueda(tamaño * (1 / 4), tamaño - 1, vector, true);
            //Busqueda4
            retorno[3] = Busqueda(tamaño / 2, (tamaño * (1 / 4)) - 1, vector, false);
            //Promedio
            for (int i = 0; i < 4; i++)
                retorno[4] += retorno[i];
            retorno[4] /= (1.0 * 4);
            return retorno;
        }
        public double[] BusquedaFloat(int tamaño)
        {
            double[] retorno = new double[5];
            float[] vector = new float[tamaño];
            for (int i = 0; i < tamaño; i++)
                vector[i] = Convert.ToSingle(random.NextDouble());

            // Busqueda1
            retorno[0] = Busqueda(0, (tamaño / 4) - 1, vector, true);
            //Busqueda2
            retorno[1] = Busqueda(tamaño / 4, (tamaño / 2) - 1, vector, true);
            //Busqueda3
            retorno[2] = Busqueda(tamaño * (1 / 4), tamaño - 1, vector, true);
            //Busqueda4
            retorno[3] = Busqueda(tamaño / 2, (tamaño * (1 / 4)) - 1, vector, false);
            //Promedio
            for (int i = 0; i < 4; i++)
                retorno[4] += retorno[i];
            retorno[4] /= (1.0 * 4);
            return retorno;
        }
        public double[] BusquedaDecimal(int tamaño)
        {
            double[] retorno = new double[5];
            decimal[] vector = new decimal[tamaño];
            for (int i = 0; i < tamaño; i++)
                vector[i] = Math.Round(Convert.ToDecimal(random.NextDouble()),10);

            // Busqueda1
            retorno[0] = Busqueda(0, (tamaño / 4) - 1, vector, true);
            //Busqueda2
            retorno[1] = Busqueda(tamaño / 4, (tamaño / 2) - 1, vector, true);
            //Busqueda3
            retorno[2] = Busqueda(tamaño * (1 / 4), tamaño - 1, vector, true);
            //Busqueda4
            retorno[3] = Busqueda(tamaño / 2, (tamaño * (1 / 4)) - 1, vector, false);
            //Promedio
            for (int i = 0; i < 4; i++)
                retorno[4] += retorno[i];
            retorno[4] /= (1.0 * 4);
            return retorno;
        }
        public double[] BusquedaString(int tamaño)
        {
            double[] retorno = new double[5];
            string[] vector = new string[tamaño];
            for (int i = 0; i < tamaño; i++)
                vector[i] = Convert.ToString(random.Next(0, 50));

            // Busqueda1
            retorno[0] = Busqueda(0, (tamaño / 4) - 1, vector, true);
            //Busqueda2
            retorno[1] = Busqueda(tamaño / 4, (tamaño / 2) - 1, vector, true);
            //Busqueda3
            retorno[2] = Busqueda(tamaño * (1 / 4), tamaño - 1, vector, true);
            //Busqueda4
            retorno[3] = Busqueda(tamaño / 2, (tamaño * (1 / 4)) - 1, vector, false);
            //Promedio
            for (int i = 0; i < 4; i++)
                retorno[4] += retorno[i];
            retorno[4] /= (1.0 * 4);
            return retorno;
        }
       
    }
}
