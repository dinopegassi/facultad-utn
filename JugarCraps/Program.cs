using System;

public class Craps
{
	private Random numerosAleatorios = new Random();
	private enum Estado { CONTINUA, GANO, PERDIO }
	private enum NombresDados
	{
		DOS_UNOS = 2,
		TRES = 3,
		SIETE = 7,
		ONCE = 11,
		DOCE = 12
	}
	public void Jugar()
	{
		Estado estadoJuego = Estado.CONTINUA;


		int miPunto = 0; // punto si no gana ni pierde en el primer tiro
		int sumaDeDados = TirarDados(); // primer tiro de los dados


		switch ((NombresDados)sumaDeDados)
		{
			case NombresDados.SIETE: // gana con 7 en el primer tiro			tambien es importante entender que dos
			case NombresDados.ONCE: // gana con 11 en el primer tiro			casos con el mismo proceder se pueden
				estadoJuego = Estado.GANO;                                      //escribir seguidos
				break;
			case NombresDados.DOS_UNOS: // pierde con 2 en el primer tiro
			case NombresDados.TRES: // pierde con 3 en el primer tiro
			case NombresDados.DOCE: // pierde con 12 en el primer tiro
				estadoJuego = Estado.PERDIO;
				break;
			default: // no ganó ni perdió, entonces hay que recordar el punto
				estadoJuego = Estado.CONTINUA; // el juego no ha terminado
				miPunto = sumaDeDados; // recuerda el punto
				Console.WriteLine("El punto es {0}", miPunto);
				break;
		} // fin de switch


		while (estadoJuego == Estado.CONTINUA) // no GANO ni PERDIO el juego
		{
			sumaDeDados = TirarDados(); // tira los dados otra vez
			if (sumaDeDados == miPunto) // gana haciendo punto
				estadoJuego = Estado.GANO;
			else if (sumaDeDados == (int)NombresDados.SIETE)
				estadoJuego = Estado.PERDIO;
		} // fin de while




		if (estadoJuego == Estado.GANO)
			Console.WriteLine("El jugador gana");
		else
			Console.WriteLine("El jugador pierde");
	} // fin del método Jugar

	// tira los dados, calcula la suma y muestra los resultados
	public int TirarDados()
	{
		int dado1 = numerosAleatorios.Next(1, 7); // tiro del primer dado
		int dado2 = numerosAleatorios.Next(1, 7); // tiro del segundo dado
		int suma = dado1 + dado2; // suma de los valores de cada dado
		Console.WriteLine("El jugador tiró {0} + {1} = {2}", dado1, dado2, suma);
		return suma; // devuelve la suma de los dados
	} // fin del método TirarDados
} // fin de la clase Craps