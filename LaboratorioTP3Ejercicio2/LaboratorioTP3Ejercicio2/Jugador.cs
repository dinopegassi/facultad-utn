using System;
using System.Collections.Generic;
using System.Text;

namespace BorradLaboratorioTP3Ejercicio2or
{
    public class Jugador
    {
        public int Faltas
        {
            get;private set;
        }
        public int Simples
        {
            get; private set;
        }
        public int Dobles
        {
            get; private set;
        }
        public int Triples
        {
            get; private set;
        }
        public int Camiseta
        {
            get; private set;
        }
        public string Nombre
        {
            get; private set;
        }
        public bool Juega
        {
            get; private set;
        }
        public Jugador(string nombre,int camiseta)
        {
            Nombre = nombre;
            Camiseta = camiseta;
            Faltas = 0;
            Simples = 0;
            Dobles = 0;
            Triples = 0;
            Juega = false;
        }
        public void AgregarPuntos(int puntos)
        {
            switch (puntos)
            {
                case 1:
                    this.Simples++;
                    break;
                case 2:
                    this.Dobles++;
                    break;
                case 3:
                    this.Triples++;
                    break;
            }
        }
        public void CometerFalta()
        {
            this.Faltas++;
            //en el forms hay que poner un jugador.enabled=false cuando las faltas son 5
        }
        public int TantosTotales()
        {
            return (Simples + Dobles + Triples);
        }
        public int VerPuntosEquipo(int puntos)
        {
            return (Simples + Dobles * 2 + Triples * 3);
        }
        public void CambiarEstado(bool estado)
        {
            this.Juega = estado;
        }


        //Equipo l, v;
        //public string Local()                //propiedad para ver stats
        //{
        //    return (+l.PuntajeTotal() + " %" + l.PorcentajeSimples() * 100 + " %" +
        //        l.PorcentajeDobles() * 100 + " %" + l.PorcentajeTriples() * 100);
        //}
        //public string Visitante()                //propiedad para ver stats
        //{
        //    return (+v.PuntajeTotal() + " %" + v.PorcentajeSimples() * 100 + " %" +
        //        v.PorcentajeDobles() * 100 + " %" + v.PorcentajeTriples() * 100);
        //}

        //public Partido(string l, string v)       //constructor
        //{
        //    this.l = new Equipo(l);
        //    this.v = new Equipo(v);
        //}

        //public void PuntoEquipo(string equipo, int tanto)
        //{
        //    switch (equipo)
        //    {
        //        case "L":
        //        case "l":
        //            l.Tanto(tanto);
        //            break;

        //        case "V":
        //        case "v":
        //            v.Tanto(tanto);
        //            break;
        //    }
        //}
        //public string Ganador()
        //{
        //    if (l.PuntajeTotal() != v.PuntajeTotal())
        //        if (l.PuntajeTotal() > v.PuntajeTotal())
        //            return l.Nombre;
        //        else
        //            return v.Nombre;
        //    else
        //        return "Deben seguir jugando";
        //}
    }
}
