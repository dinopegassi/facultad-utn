//EJERCICI5
using System;

namespace ejercicios
{
	public class ejer5
	{
		public static void Main(string[] args)
		{
			string nombreA, nombreB, nombreC;
			int nroLibA, nroLibB, nroLibC;
			Console.WriteLine("pone el nombre de los 3 flacos");
			nombreA = Convert.ToString(Console.ReadLine());
			nombreB = Convert.ToString(Console.ReadLine());
			nombreC = Convert.ToString(Console.ReadLine());
			Console.WriteLine("pone el numero de libreta de los 3 flacos");
			nroLibA = Convert.ToInt32(Console.ReadLine());
			nroLibB = Convert.ToInt32(Console.ReadLine());
			nroLibC = Convert.ToInt32(Console.ReadLine());
			if (nroLibA <= nroLibB)
			{
				if (nroLibA <= nroLibC)
				{
					if (nroLibB <= nroLibC)
					{
						Console.WriteLine("{0}  {1}\n{2}  {3}\n{4}  {5}", nroLibA, nombreA, nroLibB, nombreB, nroLibC, nombreC);
						Console.ReadKey();
					}
					else
					{
						Console.WriteLine("{0}  {1}\n{2}  {3}\n{4}  {5}", nroLibA, nombreA, nroLibC, nombreC, nroLibB, nombreB);
						Console.ReadKey();
					}
				}
				else
				{
					Console.WriteLine("{0}  {1}\n{2}  {3}\n{4}  {5}", nroLibC, nombreC, nroLibA, nombreA, nroLibB, nombreB);
					Console.ReadKey();
				}
			}
			else
			{
				if (nroLibA <= nroLibC)
				{
					Console.WriteLine("{0}  {1}\n{2}  {3}\n{4}  {5}", nroLibB, nombreB, nroLibA, nombreA, nroLibC, nombreC);
					Console.ReadKey();
				}
				else
				{
					if (nroLibB <= nroLibC)
					{
						Console.WriteLine("{0}  {1}\n{2}  {3}\n{4}  {5}", nroLibB, nombreB, nroLibC, nombreC, nroLibA, nombreA);
						Console.ReadKey();
					}
					else
					{
						Console.WriteLine("{0}  {1}\n{2}  {3}\n{4}  {5}", nroLibC, nombreC, nroLibB, nombreB, nroLibA, nombreA);
						Console.ReadKey();
					}
				}
			}
		}
	}
}
