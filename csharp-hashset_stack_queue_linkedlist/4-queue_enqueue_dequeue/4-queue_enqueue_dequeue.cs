using System;
using System.Collections.Generic;

class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)    
    {
        int Nitems = aQueue.Count; // un integer ou on stock le count de la stack
        Console.WriteLine("Number of items: {0}", Nitems); // on le writreline
        if (Nitems <= 0)
            Console.WriteLine("Queue is empty"); // c'est vide on le dit
        else  
            Console.WriteLine("Top item: {0}", aQueue.Peek());//  sinon on print le premier item
        if (!aQueue.Contains(search))
            Console.WriteLine("Stack contains \"{0}\": False", search);// si il n'y a pas l'element search
        else
        {
            Console.WriteLine("Stack contains \"{0}\": True", search);
            while (aQueue.Contains(search))
                aQueue.Dequeue(); //  si il y est on degage tt jusqu'a l'element
        }
        aQueue.Enqueue(newItem);
        return (aQueue); // et on retourne la stack
    }
}