using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2TP1
{
    internal class Gato:Animal
    {
        static int genericID;
        int id;
        public Gato(int x,int y) : base(x,y) { id=genericID++; }

        //public override string Comer()
        //{
        //    this.DiasSinComer = 0;
        //    return "pt";
        //}
        public override bool Mover()
        {
            Random rand = new Random();
            int posiciones_a_mover = rand.Next(0, 4); //cant de posiciones a moverse
            for (int i = 0; i < posiciones_a_mover; i++) //direccion a moverse esa cant
            {
                int direccion = rand.Next(1, 5); //1-4 es izq,der,arrib,abajo
                switch (direccion)
                {
                    case 1: Posicion[0]++; break; //izq
                    case 2: Posicion[0]--; break; //der
                    case 3: Posicion[1]++; break; //arriba
                    case 4: Posicion[1]--; break; //abajo
                }
                //no puede chocar con las paredes (los devuelve a la orilla)
                if (Posicion[0] == 0)
                    Posicion[0] = 1;
                if (Posicion[0] == renglonF)
                    Posicion[0] = renglonF - 1;
                if (Posicion[1] == 0)
                    Posicion[1] = 1;
                if (Posicion[1] == columnaF)
                    Posicion[1] = columnaF - 1;
            }
            return true;
        }
        public override string Comer(object raton)
        {
            if (((Raton)raton).Vivo)//si vive
            {
                DiasSinComer = 0;
                return ToString() + " se comio a " + ((Raton)raton).ToString();
            }
            else return ToString() + " no pudo comer a " + ((Raton)raton).ToString();
        }
        public override void Morir()
        {
            Vivo = false;
        }
        public override string ToString()
        {
            return "Gato" + id;
        }
    }
}
