using System;

namespace Ejercicios
{
	public class EjLibretas
	{
		public static void Main(string[] args)
		{
			int nroA, nroB, nroC;
			string nombreA, nombreB, nombreC;

			Console.WriteLine("ingresa el nombre del estudiante A");
			nombreA = Console.ReadLine();
			Console.WriteLine("ingresa el nombre del estudiante B");
			nombreB = Console.ReadLine();
			Console.WriteLine("ingresa el nombre del estudiante C");
			nombreC = Console.ReadLine();
			Console.WriteLine("ingresa el numero del estudiante A");
			nroA = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("ingresa el numero del estudiante B");
			nroB = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("ingresa el numero del estudiante C");
			nroC = Convert.ToInt32(Console.ReadLine());

			if (nroA < nroB)
			{
				if (nroB < nroC)
				{
					Console.WriteLine("{0}   {1}\n{2}   {3}\n{4}   {5}", nroA, nombreA, nroB, nombreB, nroC, nombreC);
				}
				else
					if (nroA < nroC)
				{
					Console.WriteLine("{0}   {1}\n{4}   {5}\n{2}   {3}", nroA, nombreA, nroB, nombreB, nroC, nombreC);
				}
				else
				{
					Console.WriteLine("{4}   {5}\n{0}   {1}\n{2}   {3}", nroA, nombreA, nroB, nombreB, nroC, nombreC);
				}
			}
			else if (nroB > nroC)
			{
				Console.WriteLine("{4}   {5}\n{2}   {3}\n{0}   {1}", nroA, nombreA, nroB, nombreB, nroC, nombreC);
			}
			else if (nroA < nroC)
			{
				Console.WriteLine("{2}   {3}\n{0}   {1}\n{4}   {5}", nroA, nombreA, nroB, nombreB, nroC, nombreC);
			}
			else
			{
				Console.WriteLine("{2}   {3}\n{4}   {5}\n{0}   {1}", nroA, nombreA, nroB, nombreB, nroC, nombreC);
			}


			Console.ReadKey();
		}
	}
}