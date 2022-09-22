using System;

namespace Prog2GuiaEstudio2Ej7
{
    internal class Busqueda
    {
        
        bool aparecio = false;
        public void BubbleSort(int[][] arreglo, int numero)
        {
            


            


            for (int i = 0; i < arreglo.Length; i++)
            {
                for (int j = 0; j < arreglo[i].Length; j++)
                {
                    if (arreglo[i][j] == numero && !aparecio)
                    {
                        aparecio = true;
                        PosicionExterna = i;
                        PosicionInterna = j;
                    }
                }
            }
        }
        public int PosicionExterna { get; private set; }
        public int PosicionInterna { get; private set; }





        
    }
}
