using System;
using System.Collections.Generic;
using System.Text;

namespace otro_tp
{
    public class Auxiliares
    {
        private string nombre;

        public Auxiliares(string elnombre)
        {
            nombre = elnombre;
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public static void Marco()
        {
            Console.SetWindowSize(80, 30);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            int rI = 2; //renglon inicial
            int rF = 25;//renglon final
            int cI = 2; //columna inicial
            int cF = 75;//columna final
                        // Llena filas
            for (int x = cI; x < cF; x++)
            {
                Console.SetCursorPosition(x, rI);
                Console.Write("═");
                Console.SetCursorPosition(x, rI + 2);
                Console.Write("═");
                Console.SetCursorPosition(x, rF);
                Console.Write("═");
            }
            // Llena columnas
            for (int y = rI; y < rF + 1; y++)
            {
                Console.SetCursorPosition(cI, y);
                if (y == rI)
                    Console.Write("╔");
                else
                {
                    if (y == rF)
                        Console.Write("╚");
                    else
                        if (y == 4)
                        Console.Write("╠");
                    else
                        Console.Write("║");
                }
                Console.SetCursorPosition(cF, y);
                if (y == rI)
                    Console.Write("╗");
                else
                {
                    if (y == rF)
                        Console.Write("╝");
                    else
                        if (y == 4)
                        Console.Write("╣");
                    else
                        Console.Write("║");
                }
            }
            //Console.SetCursorPosition(3, 5); // Posicion para empezar a escribir
            //Console.SetCursorPosition(3, 3); // titulo
            //Console.SetCursorPosition(xx, yy);
        }

        public static void Feriado()
        {
            Console.SetCursorPosition(3, 5);
            Console.WriteLine("Hoy es dia feriado? (Y/N)");
            Console.SetCursorPosition(3, 6);
        }

        public static void Menu1()
        {
            Marco();
            Console.SetCursorPosition(3, 3);
            Console.Write("\t\t\t Menu principal");
            Console.SetCursorPosition(3, 5);
            Console.Write("Que operacion desea?\n");
            Console.SetCursorPosition(3, 6);
            Console.Write("1- Ticket/s individual/es   (Deben ser mayores a 16)");
            Console.SetCursorPosition(3, 7);
            Console.Write("2- Pasaportes   (Pueden ingresar menores*)");
            Console.SetCursorPosition(3, 8);
            Console.Write("3- Salir");
            Console.SetCursorPosition(3, 11);
            Console.Write("NumPad -> ");
        }

        

    }
}
