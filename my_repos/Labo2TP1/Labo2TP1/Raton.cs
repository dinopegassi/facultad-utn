using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2TP1
{
    internal class Raton:Animal
    {
        static int genericID;
        int id;
        int contadorParaParir;
        public bool SexoMacho { get; private set; }
        public bool Embarazada { get; private set; }
        public int PasosSinComer { get; private set; }
        public Raton(int x, int y, bool sexo) : base(x, y)
        {
            this.Embarazada = false;
            this.SexoMacho = sexo;
            this.PasosSinComer = 0;
            id=genericID++;
            contadorParaParir = 0;        //este contador es para saber si esta encinta
            Vivo = true;
        }
        public void Embarazar(Raton raton)
        {
            if (this.SexoMacho != raton.SexoMacho && !this.SexoMacho && !this.Embarazada)
            {
                this.Embarazada = true;
            }
            contadorParaParir = 2;
        }
        public override bool Mover()
        {
            Random rand = new Random();
            int posiciones_a_mover = rand.Next(0, 4); //cant de posiciones a moverse
            for (int i = 0; i < posiciones_a_mover; i++) //direccion a moverse esa cant
            { 
                int direccion = rand.Next(1, 5); //1-4 es izq,der,arrib,abajo
                switch (direccion)
                {
                    case 1: Posicion[0] ++; break; //izq
                    case 2: Posicion[0] --; break; //der
                    case 3: Posicion[1] ++; break; //arriba
                    case 4: Posicion[1] --; break; //abajo
                }
                //pero si choca con los limites(agua) devolver falso a mover y matarlo
                if (Posicion[0] == 0 || Posicion[0] == renglonF)
                    return false;
                if (Posicion[1] == 0 || Posicion[1] == columnaF)
                    return false;
            }
            if (this.Embarazada) { contadorParaParir--; }
            PasosSinComer++;
            return true;
        }
        public override string Comer(Object queso)
        {
            if (((Queso)queso).Porcion!= 0)
            {
                ((Queso)queso).NerfearRacion();
                DiasSinComer = 0;
                return ToString() + " se comio el " + ((Queso)queso).ToString();
            }
            else return ToString() + " no pudo comer " + ((Queso)queso).ToString();
        }
        public override void Morir()
        {
            this.Vivo = false;
            //disposear
        }
        public override string ToString()
        {
            if(SexoMacho) return "Raton" + id;
            else return "Ratona" + id;
        }
    }
}
