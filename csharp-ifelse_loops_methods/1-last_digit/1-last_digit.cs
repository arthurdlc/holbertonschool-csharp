﻿using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10000, 10000); // Génère un nombre entre -10000 et 10000
        int last_digit = number % 10; // Dernier chiffre (conserve le signe)

        Console.Write($"The last digit of {number} is {last_digit} and is ");

        if (last_digit > 5)
        {
            Console.WriteLine("greater than 5");
        }
        else if (last_digit == 0)
        {
            Console.WriteLine("0");
        }
        else
        {
            Console.WriteLine("less than 6 and not 0");
        }
    }
}
