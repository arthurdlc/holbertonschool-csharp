﻿using System;

class Program
{
    static void Main(string[] args)
    {
        string str = "Holberton School";
        Console.WriteLine($"{str}{str}{str}"); // Affiche la chaîne trois fois
        Console.WriteLine(str.Substring(0, 9)); // Affiche les 9 premiers caractères
    }
}
