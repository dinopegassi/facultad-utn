using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaAnto_
{
    internal class Class1
    {
        public string Nombre { get; private set; }

        public string Saludo()
        {
            return "hola Anto";
        }
        public Class1(string nombre)
        {
            Nombre = nombre;
        }
    }
}
