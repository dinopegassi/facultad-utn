using System;

namespace MARQUINHOS
{
    class Marcos
    {
        static void Main(string[] args)
        {
            /*
            for (int y = 1; y < 22; y++)
            {
                Console.CursorLeft = 10;
                Console.CursorTop = y;
                Console.Write("▓");
                Console.CursorLeft = 70;
                Console.Write("▓");

            }
            for (int x = 10; x < 70; x++)
            {

                Console.CursorLeft = x;
                Console.CursorTop = 1;
                Console.Write("▓");
                Console.CursorTop = 22;
                Console.Write("▓");
            }
            */
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.BackgroundColor = ConsoleColor.DarkRed;
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
        }
    }
}
