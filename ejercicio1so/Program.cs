
using System;

namespace ejercicios
{
	public class ejercicio1
	{
		public static void Main(string[] args)
		{
			int num, x, suma;
			x = 0;
			suma = 0;
			Console.WriteLine("Meté el numero hasta\nel que queres sumar");
			num = Convert.ToInt32(Console.ReadLine());
			for (x = num; x >= 0; x-- )
			{
				suma = suma + x;
			}
			Console.WriteLine("La suma de los {0} primeros numeros es {1}", num, suma);
			Console.ReadKey();
		}
	}
}