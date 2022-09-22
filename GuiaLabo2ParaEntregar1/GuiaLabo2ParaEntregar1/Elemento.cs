using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaLabo2ParaEntregar1
{
    abstract internal class Elemento
    {
        public int PosInit { get; protected set; }
        public int PosFinal { get; protected set; }
        static Random rand1 = new Random(); //rand para la semilla
        static int seed = rand1.Next();

        public Elemento()
        {
            
                Random rand2 = new Random(); //rand para incrementar semilla
                seed += rand2.Next();
                Random rand3 = new Random(seed); // rand para el valor inicial
                this.PosInit = rand3.Next(12, 80);
                this.PosFinal = rand3.Next(this.PosInit + 10, this.PosInit + 30);
            
        }
        abstract  public void Evaluar(Jugador jugador);
    }
}
