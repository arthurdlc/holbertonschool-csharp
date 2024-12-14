using System;
using System.Collections.Generic;

class LList
{
     public static void Delete(LinkedList<int> myLList, int index)
    {
        if (index < 0 || index >= myLList.Count)
        {
            return; // Do nothing if index is out of range
        }

        LinkedListNode<int> current = myLList.First;
        int currentIndex = 0;

        while (current != null)
        {
            if (currentIndex == index)
            {
                myLList.Remove(current);
                return;
            }
            current = current.Next;
            currentIndex++;
        }
    }
}