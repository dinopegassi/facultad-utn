using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursitoD_Elorto
{
    class CursoPrueba
    {
        private int notaCurso;
        private int cantidad;
        private int sumaNotas;
        private double promedio;
        private int max;
        private int min;

        public CursoPrueba()
        {
            cantidad = 0;
            sumaNotas = 0;
            promedio = 0;
        }


        public void IngresarNota(int nota)
        {
            notaCurso = nota;
            cantidad++;
            SumaNotas(nota);
            if (max < nota)
            {
                GetMaximo();
            }
        }
        public int Cantidad
        {
            get
            {
                return cantidad;
            }
        }
        public int SumaNotas(int notaAcum)
        {
            sumaNotas += notaAcum;
            return sumaNotas;
        }
        public double CalcularPromedio()
        {
            promedio = (1.0) * SumaNotas() / cantidad;
            return promedio;
        }
        public int GetMaximo()
        {
            return max;
        }
        public int GetMinimo()
        {
            return min;
        }
    }
}
