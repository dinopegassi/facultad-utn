using System;
using System.Collections.Generic;
using System.Text;

namespace Guia8Ejercicio2
{
    class Pista2
    {
        private int cantidadVueltas;
        private int distancia;
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

        public Pista2(int distancia)
        {
            this.distancia = distancia;
            cantidadVueltas = 0;
            totalHoras = 0;
        }

        public void AgregarVuelta(int minutos, int segundos)
        {
            do
            {
                if (segundos < 60)
                {
                    totalHoras += (minutos / 60);
                    cantidadVueltas++;
                }
                else
                {
                    Console.WriteLine("escribi bien forro");
                }
            } while (segundos < 60);
        }

        public double VelocidadPromedio()
        {
            return
        }

        public double VelocidadMenor()
        {
            return
        }
    }
}