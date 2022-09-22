using System;

public class Program
{
	static void Main(string[] args)
	{
		int i,j;

		for (j = 0; j < 5; j++)
		{
			
			for (i = 0; i < 5; i++)
			{
				Console.Write("{0}  ", i + 1);



			}
			Console.WriteLine("");
		}

		Console.ReadKey();


	}
}