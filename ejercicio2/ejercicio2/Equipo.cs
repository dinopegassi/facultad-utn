using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ejercicio2
{
    class Equipo
    {
        string[] lista = new string[10];
        int cantidad = 0;
        
        public void Agregar(int n, string nombre)
        {
            if (n <= 10 && n >= 1)
            {
                lista[n - 1] = nombre;
                cantidad++;
            }
        }
        public string Ver(int n)
        {
          string ret = "no definido";
          if (lista[n - 1] != null ) ret = lista[n - 1];
            return ret;
        }
        public int BuscarNro(string nombre)
        {
            int ubicacion = -1;
            for (int i = 0; i < cantidad; i++)
            {
                if (lista[i] == nombre)
                {
                    ubicacion = i + 1;
                }
            }
            return ubicacion;
        }
    }
}
