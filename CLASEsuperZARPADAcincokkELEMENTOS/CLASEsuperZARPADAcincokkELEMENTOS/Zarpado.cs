using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASEsuperZARPADAcincokkELEMENTOS
{
    internal class Zarpado
    {
        string[]? cosoString;
        byte[]? cosoByte;
        int[]? cosoInt;
        float[]? cosoFloat;
        decimal[]? cosoDecimal;

        //Constructores:
        public Zarpado(int valores, string cosito)    //string[] cosito
        {
            cosoString = new string[valores];
            //int lugar;
            for (int i = 0; i < valores; i++)
            {
                cosoString[i] = "";
                Random azar = new Random();
                cosoString[i] = azar.Next().ToString();
                //lugar = azar.Next(cosito.Length);
                //cosoString[i]=cosito[lugar];
            }
        }
        public Zarpado(int valores, int cosito)
        {
            cosoInt = new int[valores];
            for (int i = 0; i < valores; i++)
            {
                Random azar = new Random();
                cosoInt[i] = azar.Next();
            }
        }
        public Zarpado(int valores, byte cosito)
        {
            cosoByte = new byte[valores];
            Random azar = new Random();
            azar.NextBytes(cosoByte);
        }
        public Zarpado(int valores, float cosito)
        {
            cosoFloat = new float[valores];
            for (int i = 0; i < valores; i++)
            {
                Random azar = new Random();
                cosoFloat[i] = (float)azar.NextDouble() * azar.Next();
            }
        }
        public Zarpado(int valores, decimal cosito)
        {
            cosoDecimal = new decimal[valores];
            for (int i = 0; i < valores; i++)
            {
                Random azar = new Random();
                cosoDecimal[i] = (decimal)azar.NextDouble() * azar.Next();
            }
        }

        //Busqueda:
        public int BuscarIndiceArray(string valorBuscado)
        {
            int i= 0;
            while (valorBuscado != cosoString[i])
            {

                i++;
            }
            return i;
        }
        public int BuscarIndiceArray(byte valorBuscado)
        {
            int i = 0;
            while (valorBuscado != cosoByte[i])
            {

                i++;
            }
            return i;
        }
        public int BuscarIndiceArray(int valorBuscado)
        {
            int i = 0;
            while (valorBuscado != cosoInt[i])
            {

                i++;
            }
            return i;
        }
        public int BuscarIndiceArray(float valorBuscado)
        {
            int i = 0;
            while (valorBuscado != cosoFloat[i])
            {

                i++;
            }
            return i;
        }
        public int BuscarIndiceArray(decimal valorBuscado)
        {
            int i = 0;
            while (valorBuscado != cosoDecimal[i])
            {

                i++;
            }
            return i;
        }
        






    }
}
/*sbyte byte1 = 127;
convert.tosbyte
convert.toint16
convert.toint32

 
 

valores/2
 
 */