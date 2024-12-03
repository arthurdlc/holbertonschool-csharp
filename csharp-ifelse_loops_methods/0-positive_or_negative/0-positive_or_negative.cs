using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10, 10);

        // Déterminer si le nombre est positif, négatif ou zéro
        if (number > 0)
        {
            Console.WriteLine($"{number} is positive"); // Format attendu
        }
        else if (number < 0)
        {
            Console.WriteLine($"{number} is negative"); // Format attendu
        }
        else
        {
            Console.WriteLine($"{number} is zero"); // Format attendu
        }
    }
}