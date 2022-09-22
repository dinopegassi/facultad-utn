using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Guia1Ej1
{
    internal class Alumno
    {
        public int Resultado
        {
            get;
            private set;
        }
        public int Anio
        {
            get;
            private set;
        }
        public string Carrera
        {
            get;
            private set;
        }
        public string Nombre
        {
            get;
            private set;
        }

        public Alumno(string nombre, string carrera, int anio)
        {
            Nombre = nombre;
            Anio = anio;
            Carrera = carrera;
        }
        
        public void ConsultaSobreA(int respuesta)
        {

        }
        public void ConsultaSobreB(int respuesta)
        {

        }
        public void ConsultaSobreC(int respuesta)
        {

        }
        public void ConsultaSobreD(int respuesta)
        {

        }
    }
}
