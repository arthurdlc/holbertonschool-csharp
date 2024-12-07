using System;

class Array
{
    public static int elementAt(int[] array, int index)
    {
        // Check if the index is out of range
        if (index < 0 || index >= array.Length)
        {
            Console.WriteLine("Index out of range");
            return -1;
        }

        // Return the element at the given index
        return array[index];
    }
}