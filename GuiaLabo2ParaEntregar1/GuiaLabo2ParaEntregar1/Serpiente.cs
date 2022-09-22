using System;

namespace GuiaLabo2ParaEntregar1
{
    internal class Serpiente : Elemento
    {
       /* static Random rand1 = new Random(); //rand para la semilla
        static int seed = rand1.Next();
        public Serpiente() : base()
        {
            Random rand2 = new Random(); //rand para incrementar semilla
            seed += rand2.Next();
            Random rnd = new Random(seed++); //crear valor inicial
            this.PosInit = rnd.Next(35, 90);
            this.PosFinal = rnd.Next(this.PosInit - 30, this.PosInit - 10);
        }*/
        public override void Evaluar(Jugador jugador)
        {
            jugador.PorQuienFueAfectado = null;
            if (jugador.Posicion == this.PosFinal)
            {
                jugador.Posicion = this.PosInit;
                jugador.PorQuienFueAfectado = this;
            }
        }
        public override string ToString()
        {
            return "Serpiente";
        }
    }
}
