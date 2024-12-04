using System;

class Number
{
    public static int PrintLastDigit(int number)
    {
        int last_digit = Math.Abs(number % 10); // Dernier chiffre (valeur absolue pour éviter les signes négatifs)
        Console.Write(last_digit); // Affiche le dernier chiffre
        return last_digit; // Retourne le dernier chiffre
    }
}
