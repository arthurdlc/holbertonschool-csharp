using System;

class Line
{
    public static void PrintDiagonal(int length)
    {
        if (length <= 0)
        {
            Console.WriteLine();
            return;
        }

        for (int i = 0; i < length; i++)
        {
            // Ajout d'une gestion stricte des espaces
            Console.Write(new string(' ', i));
            Console.WriteLine("\\");
        }
    }
}
