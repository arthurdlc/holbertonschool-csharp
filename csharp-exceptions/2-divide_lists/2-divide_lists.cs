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
                if (i >= list1.Count || i >= list2.Count)
                {
                    throw new IndexOutOfRangeException("Out of range");
                }

                if (list2[i] == 0)
                {
                    throw new DivideByZeroException("Cannot divide by zero");
                }

                result.Add(list1[i] / list2[i]);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
                result.Add(0); // Ajouter 0 en cas de division par zéro
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Out of range");
                result.Add(0); // Ajouter 0 si une des listes est trop courte
            }
        }

        return result;
    }
}
