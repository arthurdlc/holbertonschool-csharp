using System;

class Number
{
    public static void PrintLine(int length)
    {
        if (length < 0)
        {
            length = 0;
        }
        for (int i = 0; i < length; i++) // Initialisation, condition, et incrémentation correctes
        {
            Console.Write("_");
        }
        Console.WriteLine("$"); // Ajoute un symbole `$` à la fin de la ligne
    }
}