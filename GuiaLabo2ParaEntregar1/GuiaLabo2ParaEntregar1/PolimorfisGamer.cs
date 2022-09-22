using System.Collections;
using System.Collections.Generic;

namespace GuiaLabo2ParaEntregar1
{
    internal class PolimorfisGamer
    {
        protected ArrayList jugadores = new ArrayList();
        public bool HaFinalizado { get; protected set; }
        public PolimorfisGamer(string jugador, int cantJugadores)
        {
            HaFinalizado = false;
            jugadores.Add(new Jugador(jugador));
            for (int n = 1; n < cantJugadores; n++)
            {
                jugadores.Add(new Jugador("Maquina " + n.ToString()));
            }
        }
        
        public virtual bool JugarRonda()
        {

            if (HaFinalizado == false)
            {
                foreach (Jugador j in jugadores)
                {
                    j.Mover();
                    HaFinalizado |= j.HaLlegado;
                }
            }
            
            return HaFinalizado;
        }
        public ArrayList ListarJugadores()
        {
            return (ArrayList)jugadores.Clone();
        }
    }
}