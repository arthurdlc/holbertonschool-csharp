using System;

class Program
{
    static void Main(string[] args)
    {
        // Ne pas modifier cette ligne
        Random rndm = new Random();
        int number = rndm.Next(-10, 10); // Génère un nombre aléatoire entre -10 et 10

        // Vérification et affichage des résultats
        if (number > 0):
        {
            Console.WriteLine("{0} is positive", number);
        }
        else if (number < 0):
        {
            Console.WriteLine("{0} is negative", number);
        }
        else:
        {
            Console.WriteLine("{0} is zero", number);
        }
    }
}
