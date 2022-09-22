using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2GuiaEstudio3Ej8
{
    internal class Identificador
    {
        /*Implemente una aplicación que le permita identificar los países y tipo de sitio, 
         * a los que corresponde una lista de diferentes sitios del MERCOSUR ingresados por el usuario.
         * Al finalizar informe cuántos sitios de cada tipo se han ingresado por cada país. 
         */

        public ArrayList Lista { get; private set; }
        string arg = ".ar/";
        StringComparison comparison = StringComparison.CurrentCultureIgnoreCase;
        private int contarg = 0;
        public int Contarg { get; private set; }
        private int cont = 0;
        public int Cont { get; private set; }


        public Identificador()
        {
            this.Lista = new ArrayList();
        }

        public void Busqueda(ArrayList lista)
        {
            foreach (string link in lista)
            {
                if (link.IndexOf(arg, 0, link.Length, comparison) >= 0)
                {
                    Contarg++;
                }
            }
        }
        public void AgregarString(string link)
        {
            Lista.Add(link);

        }
    }
}
