using System;
using System.Collections.Generic;
using System.Text;

namespace LaboratorioTP3Ejercicio2
{
    public class Equipo
    {
        public int FaltasEquipo
        {
            get; private set;
        }
        public int SimplesEquipo
        {
            get; private set;
        }
        public int DoblesEquipo
        {
            get; private set;
        }
        public int TriplesEquipo
        {
            get; private set;
        }
        public string NombreEquipo              //propiedad
        {
            get; private set; 
        }
        public int TantosTotalesEquipo
        {
            get; private set;
        }
        //-------------------------------------------------------------------------------------------//
        public Equipo(string nombre)        //constructor
        {
            NombreEquipo = nombre;
            FaltasEquipo = 0;
            SimplesEquipo = 0;
            DoblesEquipo = 0;
            TriplesEquipo = 0;
            TantosTotalesEquipo = 0;
        }
        //metodos
        //public void Tanto(int punto)
        //{
        //    switch (punto)
        //    {
        //        case 1:
        //            simples++;
        //            break;
        //        case 2:
        //            dobles++;
        //            break;
        //        case 3:
        //            triples++;
        //            break;
        //    }
        //    tantos = simples + dobles + triples;
        //}
        public int VerPuntosEquipo(int puntos)
        {
            return (SimplesEquipo + DoblesEquipo * 2 + TriplesEquipo * 3);
        }
        public void CometerFaltaEquipo()
        {
            this.FaltasEquipo++;
        }
        public double VerPorcentajeSimples()
        {
            return ((double)SimplesEquipo / VerTantosEquipo());
        }
        public double VerPorcentajeDobles()
        {
            return ((double)DoblesEquipo / VerTantosEquipo());
        }
        public double VerPorcentajeTriples()
        {
            return ((double)TriplesEquipo / VerTantosEquipo());
        }
        public int VerTantosEquipo()
        {
            return (SimplesEquipo + DoblesEquipo + TriplesEquipo);
        }
    }
}
