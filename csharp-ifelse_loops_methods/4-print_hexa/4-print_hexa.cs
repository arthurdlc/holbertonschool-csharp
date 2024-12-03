using System;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 99; i++) // Parcourt les nombres de 0 à 98
        {
            Console.WriteLine($"{i} = 0x{i:x}");
        }
    }
}
