using System;

namespace Guia8Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pista ciclismo = new Pista(3.4);
            int segundos=0, minutos=0;

            Console.WriteLine("escribi los minutos y los segundos gato");
            minutos = Convert.ToInt32(Console.ReadLine());

            while (minutos >= 0)
            {
                segundos = Convert.ToInt32(Console.ReadLine());
                ciclismo.AgregarVuelta(minutos, segundos);
                Console.WriteLine("escribi los minutos y los segundos gato");
                minutos=Convert.ToInt32(Console.ReadLine());
            }

            Console.ReadKey();
        }
    }
}
