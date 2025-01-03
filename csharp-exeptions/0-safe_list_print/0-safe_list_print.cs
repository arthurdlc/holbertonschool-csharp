using System;
using System.Collections.Generic;

public class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        int count = 0; // Nombre d'éléments imprimés

        try
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(myList[i]);
                count++;
            }
        }
        catch (ArgumentOutOfRangeException)
        {
        }

        return count; // Retourne le nombre d'éléments réellement imprimés
    }
}
