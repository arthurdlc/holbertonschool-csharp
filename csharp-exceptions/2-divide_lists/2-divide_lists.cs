using System;

public class Int
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        if (listLength <= 0)
        {
            throw new ArgumentException("List length must be greater than 0.");
        }

        if (list1.Count != listLength || list2.Count != listLength)
        {
            throw new ArgumentException("List lengths must be equal to listLength.");
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
