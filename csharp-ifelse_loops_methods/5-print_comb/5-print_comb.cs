using System;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 100; i++) // Parcourt les nombres de 0 à 99
        {
            if (i == 99)
                Console.Write($"{i:D2}\n"); // Dernier élément suivi d'une nouvelle ligne
            else
                Console.Write($"{i:D2}, "); // Autres éléments suivis de ", "
        }
    }
}
