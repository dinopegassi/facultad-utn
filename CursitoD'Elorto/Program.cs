using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursitoD_Elorto
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random azar = new Random();
            CursoPrueba c = new CursoPrueba();
            int nota;

            do
            {
                Console.WriteLine("Ingrese la nota - corte con -1");
                //nota=Convert.ToInt32(Console.ReadLine()); 

                nota = azar.Next(12) - 1;         //descomentar para la depuración
                Console.WriteLine("{0}", nota);//descomentar para la depuración

                if (nota > 0)
                    c.IngresarNota(nota);

            }
            while (nota > 0);

            Console.WriteLine("Cantidad de notas: {0}", c.Cantidad);
            Console.WriteLine("El promedio es: {0:f2}", c.CalcularPromedio());
            Console.WriteLine("El máximo es: {0:f2}", c.GetMaximo());
            Console.WriteLine("El mínimo es: {0:f2}", c.GetMinimo());

            Console.ReadKey();
        }
    }
}
   
