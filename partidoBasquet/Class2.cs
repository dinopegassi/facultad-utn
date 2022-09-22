using System;
using System.Collections.Generic;
using System.Text;

namespace Borrador
{
    class Equipo
    {
        private readonly string nombre;     //atributos
        private int simples = 0;
        private int dobles = 0;
        private int triples = 0;
        private int tantos = 0;

        public string Nombre                //propiedad
        {
            get { return nombre; }
        }
        //-------------------------------------------------------------------------------------------//
        public Equipo(string nombre)        //constructor
        {
            this.nombre = nombre;
        }
        //metodos
        public void Tanto(int punto)
        {
            switch (punto)
            {
                case 1:
                    simples++;
                    break;
                case 2:
                    dobles++;
                    break;
                case 3:
                    triples++;
                    break;
            }
            tantos = simples + dobles + triples;
        }
        public double PorcentajeSimples()
        {
            return ((double)simples / tantos);
        }
        public double PorcentajeDobles()
        {
            return ((double)dobles / tantos);
        }
        public double PorcentajeTriples()
        {
            return ((double)triples / tantos);
        }
        public int PuntajeTotal()
        {
            return (simples + dobles * 2 + triples * 3);
        }
    }
}
