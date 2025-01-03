using System;

public class Int
{
    public static void divide(int a, int b)
    {
        int result = 0;

        try
        {
            result = a / b; // Tente de diviser a par b
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero");
        }
        finally
        {
            // Affiche le résultat, même si une exception s'est produite
            Console.WriteLine($"{a} / {b} = {result}");
        }
    }
}
