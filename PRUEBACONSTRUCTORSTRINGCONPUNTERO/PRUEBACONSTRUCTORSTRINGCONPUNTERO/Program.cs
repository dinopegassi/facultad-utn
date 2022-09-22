using System;

public class Example
{
    public static unsafe void Main()
    {
        char[] characters = { 'H', 'e', 'l', 'l', 'o', ' ',
                            'w', 'o', 'r', 'l', 'd', '!', '\u0000' };
        String value;

        fixed (char* charPtr = characters)
        {
            int length = 0;
            Char* iterator = charPtr;

            while (*iterator != '\x0000')
            {
                if (*iterator == '!' || *iterator == '.')
                    break;
                iterator++;
                length++;
            }
            value = new String(charPtr, 4, 5);
        }
        Console.WriteLine(value);
    }
}