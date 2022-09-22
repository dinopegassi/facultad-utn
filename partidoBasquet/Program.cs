//PROGRAM
using System;
namespace Borrador
{
    class Program
    {
        static void Main(string[] args)
        {
            bool jugar = true;
            Console.Write("Equipo Local: ");        // Team A
            string l = Console.ReadLine();
            Console.Write("Equipo Visitante: ");    //Team B
            string v = Console.ReadLine();
            Partido p = new Partido(l, v);      //Creo clase PARTIDO
                                                //Gameplay
            do
            {
                Console.Write("\n-1 pa salir\nSimple, doble o triple (1,2,3): ");
                int tanto = Convert.ToInt32(Console.ReadLine());
                if (tanto != -1)
                {
                    Console.Write("Punto para(L o V): ");
                    string equipo = Console.ReadLine();
                    p.PuntoEquipo(equipo, tanto);
                }
                else
                    jugar = false;
            }
            while (jugar);
            //Stats
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Ganador: {0}", p.Ganador()); //ganador

            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\nPuntaje L: {0}", p.Local()); // local

            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\nPuntaje L: {0}", p.Visitante()); // visitante

            Console.ReadKey();
        }
    }
}
