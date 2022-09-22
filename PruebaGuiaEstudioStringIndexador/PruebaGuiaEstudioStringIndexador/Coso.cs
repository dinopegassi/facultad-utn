using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaGuiaEstudioStringIndexador
{
    internal class Coso
    {
        string a = "hola QUE tal";
        int indice;

        public int Metodo()
        {
            indice = a.Length;
            return indice;
        }
        public int MetodoVocales()
        {
            int c=0;
            int total = 0;
            while (c < a.Length)
            {
                if (a[c] == Convert.ToChar("a") || a[c] == Convert.ToChar("e") ||
                    a[c] == Convert.ToChar("i") || a[c] == Convert.ToChar("o") ||
                    a[c] == Convert.ToChar("u") || a[c] == Convert.ToChar("A") || 
                    a[c] == Convert.ToChar("E") || a[c] == Convert.ToChar("I") || 
                    a[c] == Convert.ToChar("O") || a[c] == Convert.ToChar("U"))
                {
                    total++;
                }
                c++;
            }
            return total;

            //foreach (char c in a)
            //{
            //    indice = a[c];

            //}
        }
    }
}
