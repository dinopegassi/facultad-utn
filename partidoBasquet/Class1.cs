using System;
using System.Collections.Generic;
using System.Text;

namespace Borrador
{
    class Partido
    {
        Equipo l, v;
        public string Local()                //propiedad para ver stats
        {
            return (+l.PuntajeTotal() + " %" + l.PorcentajeSimples() * 100 + " %" +
                l.PorcentajeDobles() * 100 + " %" + l.PorcentajeTriples() * 100);
        }
        public string Visitante()                //propiedad para ver stats
        {
            return (+v.PuntajeTotal() + " %" + v.PorcentajeSimples() * 100 + " %" +
                v.PorcentajeDobles() * 100 + " %" + v.PorcentajeTriples() * 100);
        }

        public Partido(string l, string v)       //constructor
        {
            this.l = new Equipo(l);
            this.v = new Equipo(v);
        }

        public void PuntoEquipo(string equipo, int tanto)
        {
            switch (equipo)
            {
                case "L":
                case "l":
                    l.Tanto(tanto);
                    break;

                case "V":
                case "v":
                    v.Tanto(tanto);
                    break;
            }
        }
        public string Ganador()
        {
            if (l.PuntajeTotal() != v.PuntajeTotal())
                if (l.PuntajeTotal() > v.PuntajeTotal())
                    return l.Nombre;
                else
                    return v.Nombre;
            else
                return "Deben seguir jugando";
        }
    }
}
