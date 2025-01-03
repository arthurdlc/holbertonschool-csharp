using System;

class Line
{
    public static void PrintLine(int length)
    {
        // If length is positive, print underscores
        if (length > 0)
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write("_");
            }
        }
        // Print a new line at the end
        Console.WriteLine();
    }
}