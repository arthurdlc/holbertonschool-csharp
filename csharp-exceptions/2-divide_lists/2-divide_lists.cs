using System;
using System.Collections.Generic;

public class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> result = new List<int>();

        for (int i = 0; i < listLength; i++)
        {
            try
            {
                result.Add(list1[i] / list2[i]);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
                result.Add(0); // Ajoute 0 si la division par zéro est détectée
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Out of range");
                result.Add(0); // Ajoute 0 si l'index dépasse la taille d'une des listes
            }
        }

        return result;
    }
}
