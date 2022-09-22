using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2GuiaEstudio2Ej7
{
    internal class Constructor
    {
        static Random random = new Random();
        int[][] cosito;

        public int[][] Cosito { get { return cosito; } private set { cosito = value; } }
        public Constructor()
        {
            //aux.CrearVector();
            cosito = this.CrearVector();
        }

        public int[][] CrearVector()
        {
            
            Random valor = new Random();
            int[][] datos = new int[5][];
            datos[0] = new int[valor.Next(5, 16)];
            datos[1] = new int[valor.Next(5, 16)];
            datos[2] = new int[valor.Next(5, 16)];
            datos[3] = new int[valor.Next(5, 16)];
            datos[4] = new int[valor.Next(5, 16)];
            for (int i = 0; i < datos.Length; i++)
            {
                for (int j = 0; j < datos[i].Length; j++)
                {
                    datos[i][j] = random.Next(50,100);
                }
            }

            return datos;
        }
        public int[][] GetCosito()
        {
            return Cosito;
        }
    }
}
