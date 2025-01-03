using System;
using System.Collections.Generic;

public class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> result = new List<int>();
        int i= 0;

        while(i < listLength)
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
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Out of range");
                result.Add(0); // Ajoute 0 si l'index dépasse la taille d'une des listes
            }
            i++
        }

        return result;
    }
}
