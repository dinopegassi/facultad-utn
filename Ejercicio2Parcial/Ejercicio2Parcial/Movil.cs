using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Parcial
{
    internal class Movil
    {
        double[] unidades;
        double precioKm;
        double menorD;
        public double MenorDistancia
        {
            get { return menorD; }
            set { menorD = value; }
        }
        bool viajes = true;
        public Movil(double precio)
        {
            unidades = new double[5];
            precioKm = precio;
        }
        public void AgregarViaje(int unidad, double km)
        {
            if (unidad<unidades.Length)
            { 
                unidades[unidad] += km;
                if (viajes)
                {
                    MenorDistancia = km;
                    viajes = false;
                }
                else if (km < MenorDistancia)
                {
                    MenorDistancia = km;
                }
            }
        }
        public double VerPromedio()
        {
            double promedio = 0;
            for (int i = 0; i < unidades.Length; i++)
            {
                promedio += unidades[i];
            }
            return promedio / unidades.Length;

        }
        public double VerComision()
        {
            double recaudacion = 0;
            for (int i = 0; i < unidades.Length; i++)
                recaudacion += unidades[i];
            recaudacion *= precioKm;
            return recaudacion * 13 / 100;
        }
        public int VerMovilMenor()
        {
            double menor = unidades[0];
            int unidadNro = 0;
            for (int i = 1; i < unidades.Length; i++)
            {
                if(unidades[i] < menor)
                {
                    menor = unidades[i];
                    unidadNro = i;
                }
            }
            return unidadNro;
        }
        public double BuscarMovil(int n)
        {
            return unidades[n];
        }
    }
}
