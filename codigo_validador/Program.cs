using System;
using codigo_validador;

class Program
{
	static public void Main(string[] args)
	{
		Console.WriteLine("ingresa el numero que queres validar");
		Validador verif = new Validador();

		verif.codigo = Convert.ToInt32(Console.ReadLine());

		if (verif.Validar())
			Console.WriteLine("Es válido");
		else
			Console.WriteLine("No es válido");

		Console.WriteLine("Digito verificador ingresado: {0}", verif.d5);
		Console.WriteLine("Digito verificador calculado: {0}", verif.verif);

		Console.ReadKey();
	}
}