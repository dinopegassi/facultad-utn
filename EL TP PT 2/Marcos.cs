using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
	public class Marcos
	{
		public static void MarcoMenu()
        {
			Console.ForegroundColor = ConsoleColor.DarkGreen;
			Console.BackgroundColor = ConsoleColor.Black;
			for (int y = 5; y < 26; y++)
			{
				Console.CursorTop = y;
				Console.CursorLeft = 5;
				Console.Write("¾");
				Console.CursorLeft = 75;
				Console.Write("¾");
			}
			for (int x = 5; x < 75; x++)
			{
				Console.CursorLeft = x;
				Console.CursorTop = 5;
				Console.Write("¾");
				Console.CursorTop = 25;
				Console.Write("¾");
			}
			//Console.SetCursorPosition(xx, yy);
		}
	}
}
