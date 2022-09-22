using System;

namespace Guia8
{
    class Program
    {
        static void Main(string[] args)
        {
            Datos loqueteguste = new Datos();

            for (int i = 1; i < 11; ++i)
            {
                Console.WriteLine("ingrese valores");
                loqueteguste.Agregar(Convert.ToInt32(Console.ReadLine()));
            }

            Console.WriteLine("{0:P}",loqueteguste.PorcentajeError());
            Console.WriteLine(loqueteguste.Total);

            Console.ReadKey();


        }
    }
}
