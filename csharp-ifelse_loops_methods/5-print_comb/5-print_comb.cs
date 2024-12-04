using System;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 100; i++) // Parcourt les nombres de 0 à 98
        {
            if (i==99){
                Console.Write($"{i:D2}");
            }
            else{
                Console.Write($"{i:D2}, ");
            }
        }
    }
}