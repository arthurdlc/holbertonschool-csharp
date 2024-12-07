using System;

class Array
{
    public static int[] ReplaceElement(int[] array, int index, int n)
    {
        // Check if the index is out of range
        if (index < 0 || index >= array.Length)
        {
            Console.WriteLine("Index out of range");
            return array; // Return the unchanged array
        }

        // Replace the element at the specified index
        array[index] = n;

        // Return the updated array
        return array;
    }
}