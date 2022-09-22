using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaLabo2ParaEntregar1
{
    
    internal class RealPolimorfisGamer : PolimorfisGamer
    {
        ArrayList elementos = new ArrayList();
        public RealPolimorfisGamer(string jugador, int cantJugadores) : base(jugador, cantJugadores)
        {
            
            elementos.Add(new Serpiente());
            elementos.Add(new Serpiente());
            elementos.Add(new Serpiente());
            elementos.Add(new Escalera());
            elementos.Add(new Escalera());
            elementos.Add(new Escalera());
        }
        

        //protected override void EjecutarRegla(Jugador j)
        //{
        //    foreach (Elemento w in elementos)
        //    {
        //        w.Evaluar(j);
        //    }
        //}
        public override bool JugarRonda()
        {
            base.JugarRonda();
            if (HaFinalizado == false)
            {
                foreach (Jugador j in jugadores)
                {
                    //j.Mover();
                    foreach (Elemento w in elementos)
                    {
                        w.Evaluar(j);
                    }
                    //for (int i=0;i<elementos.Count;i++)
                    //{
                    //    if (elementos[i] is Escalera)
                    //    {
                    //        ((Escalera)elementos[i]).Evaluar(j);
                    //    }
                    //    else if (elementos[i] is Serpiente)
                    //    {
                    //        ((Serpiente)elementos[i]).Evaluar(j);
                    //    }
                    //}

                    HaFinalizado |= j.HaLlegado;
                }
            }

            return HaFinalizado;
        }
        public ArrayList ListarElementos()
        {
            return (ArrayList)elementos.Clone();
        }
    }
}
