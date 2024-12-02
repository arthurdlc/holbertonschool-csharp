using System;

class Program
{
    static void Main(string[] args)
    {
        double percent = .7553;
        double currency = 98765.4321;
        Console.WriteLine("Percent: {0:F2}%", percent * 100);  // On multiplie par 100 pour obtenir le pourcentage
        Console.WriteLine("Currency: {0:N2}", currency);  // Format standard pour la monnaie avec séparateurs de milliers
    }
}
