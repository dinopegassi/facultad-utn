using System;
using System.Collections.Generic;
using System.Text;

namespace Guia8Ejercicio2
{
    class Pista
    {
        private int cantidadVueltas;
        private double distancia;
        private double totalHoras;
        private double menorTiempo;

        public double MenorTiempo
        {
            get
            {
                return menorTiempo;
            }
            private set
            {
                menorTiempo = value;
            }
        }

        public Pista(double distancia)
        {
            this.distancia = distancia;
            cantidadVueltas = 0;
            totalHoras = 0;
        }

        public void AgregarVuelta(int minutos, int segundos)
        {
            cantidadVueltas++;
            double tiempo = (minutos / 60) + (segundos / 3600);
            totalHoras += tiempo;
            if (cantidadVueltas == 1 || tiempo < MenorTiempo)
            {
                MenorTiempo = tiempo;
            }
        }

        public double VelocidadPromedio()
        {
            return ((1.0) * distancia * cantidadVueltas / totalHoras);
        }

        public double VelocidadMenor()
        {
            return ((1.0) * distancia / menorTiempo);
        }
    }
}
