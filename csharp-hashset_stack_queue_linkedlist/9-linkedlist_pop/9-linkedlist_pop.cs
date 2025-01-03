using System;
using System.Collections.Generic;

class LList
{
    public static int Pop(LinkedList<int> myLList)
    {
        int index = 0;
        foreach (int item in myLList)
        {
            if (item == value)
            {
                return index;
            }
            index++;
        }
        return -1; // Return -1 if the value is not found
    }
}