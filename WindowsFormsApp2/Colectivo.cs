using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class Colectivo
    {
        double kilometrosRecorridos=0;
        int diaMenorRecorrido;
        int diaMayorRecorrido;
        int cantViajes = 0;
        public int NumeroUnidad
        {
            get;
            private set;
        }
        public int DiaMayorKm
        {
            get
            {
                return diaMayorRecorrido;
            }
        }
        public int DiaMenorKm
        {
            get
            {
                return diaMenorRecorrido;
            }
        }
        public Colectivo(int unidad)
        {
            NumeroUnidad = unidad;
        }
        double menor;
        double mayor;
        public void AgregarViaje(int dia, double km)
        {
            cantViajes++;
            kilometrosRecorridos += km;
            if (kilometrosRecorridos == 0)
            {
                menor = km;
                mayor = km;
                diaMayorRecorrido = dia;
                diaMenorRecorrido = dia;
            }
            else if (km < menor)
            {
                menor = km;
                diaMenorRecorrido = dia;
            }
            else if (km > mayor)
            {
                mayor = km;
                diaMayorRecorrido = dia;
            }
        }
        public double Promedio()
        {
            return kilometrosRecorridos / cantViajes;
        }
        public double VerKmTotal()
        {
            return kilometrosRecorridos;
        }
        public double VerCantViajesTotal()
        {
            return cantViajes;
        }
    }
}
