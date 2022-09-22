using System;

namespace GuiaLabo2ParaEntregar1
{
    internal class Escalera : Elemento
    {
        //static Random rand1 = new Random(); //rand para la semilla
        //static int seed = rand1.Next();
        //public Escalera() : base()
        //{
        //    Random rand2 = new Random(); //rand para incrementar semilla
        //    seed += rand2.Next();
        //    Random rand3 = new Random(seed); // rand para el valor inicial
        //    this.PosInit = rand3.Next(12, 55);
        //    this.PosFinal = rand3.Next(this.PosInit + 10, this.PosInit + 30);
        //}




        /*
         * 
         * 
         * 
         * */





        public override void Evaluar(Jugador jugador)
        {
            jugador.PorQuienFueAfectado = null;
            if (jugador.Posicion == this.PosInit)
            {
                jugador.Posicion = this.PosFinal;
                jugador.PorQuienFueAfectado = this;
            }
        }
        public override string ToString()
        {
            return "Escalera";
        }
    }
}
