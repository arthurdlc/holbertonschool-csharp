using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        // Check for invalid size
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }

        // Create the array
        int[] newArray = new int[size];

        // Populate and print the array
        for (int i = 0; i < size; i++)
        {
            newArray[i] = i;
            Console.Write(i);
            if (i < size - 1)
                Console.Write(" "); // Add a space between numbers
        }

        // Print a blank line if the size is 0 or after printing the array
        Console.WriteLine();

        return newArray;
    }
}