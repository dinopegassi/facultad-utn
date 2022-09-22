using System;

namespace GuiaLabo2ParaEntregar1
{
    internal class Jugador
    {
        static Random dado = new Random();
        public string Nombre { get; private set; }
        int posicion;
        public int Posicion
        {
            get
            {
                return posicion;
            }
            set
            {
                if (value <= 100)
                {
                    posicion = value;
                }
                else
                    posicion = 100;
            }
        }
        public int PosicionAnt { get; private set; }
        public int Avance { get; private set; }
        bool haLlegado;
        public bool HaLlegado
        {
            get
            {
                return (posicion >= 100);
            }
            private set
            {
                haLlegado = value;
            }
        }
        public Jugador(string nombre)
        {
            Nombre = nombre;
            Posicion = 0;
            HaLlegado = false;
        }
        public void Mover()
        {

            Avance = dado.Next(1, 7);
            PosicionAnt = Posicion;
            Posicion += Avance;

        }
        public Elemento PorQuienFueAfectado { get;
            set; }
    }
}