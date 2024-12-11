using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        int Nitems = aStack.Count; // un integer ou on stock le count de la stack
        Console.WriteLine("Number of items: {0}", Nitems); // on le writreline
        if (Nitems <= 0)
            Console.WriteLine("Stack is empty"); // c'est vide on le dit
        else  
            Console.WriteLine("Top item: {0}", aStack.Peek());//  sinon on print le premier item
        
        if (!aStack.Contains(search))
            Console.WriteLine("Stack contains \"{0}\": False", search);// si il n'y a pas l'element search
        else
        {
            Console.WriteLine("Stack contains \"{0}\": True", search);
            while (aStack.Contains(search))
                aStack.Pop(); //  si il y est on degage tt jusqu'a l'element
        }
        aStack.Push(newItem);
        return (aStack); // et on retourne la stack
    }
}