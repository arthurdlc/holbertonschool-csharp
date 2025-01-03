using System;

public class Int
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {

        if (list1.Count != listLength || list2.Count != listLength)
        {
            throw new ArgumentException("Out of range");
        }
        
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
        }
        }
    }
}
