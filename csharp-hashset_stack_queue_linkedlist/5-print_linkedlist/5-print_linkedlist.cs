using System;
using System.Collections.Generic;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> linkedList = new LinkedList<int>();
        if(size <  0)
        {
            return linkedList; // on renvoie une liste vide
        }
        for (int i = 0; i < size; i++)
        {
            linkedList.AddLast(i);
            Console.WWriteLine(;);
        }

        return linkedList;
    }
}