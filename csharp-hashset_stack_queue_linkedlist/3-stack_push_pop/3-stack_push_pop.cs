using System;
using System.Collections.Generic;

public class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        // Afficher le nombre d'éléments dans le stack
        Console.WriteLine($"Number of items: {aStack.Count}");

        // Vérifier si c'est vide
        if (aStack.Count == 0)
        {
            // Si la pile est vide,on envoie ce message 
            Console.WriteLine("Stack is empty");
        }
        else
        {
            // sinon on affiche le premier element, et on ne le supprime pas 
            Console.WriteLine($"Top item: {aStack.Peek()}");
        }

        // Vérifier si la pile contient l'élément "search" et si il y est on met pque on l'a trouvé et tt
        bool containsSearch = aStack.Contains(search);
        Console.WriteLine($"Stack contains \"{search}\": {containsSearch}");

        // ducp psi il est on strike tt 
        if (containsSearch)
        {
            // Créer une pile temporaire pour stocker les éléments retirés
            Stack<string> tempStack = new Stack<string>();

            // Retirer les éléments de "aStack" jusqu'à trouver "search"
            while (aStack.Count > 0)
            {
                // Utiliser .Pop() pour retirer le sommet de la pile
                string item = aStack.Pop();

                // Si l'élément actuel est "search", on arrête
                if (item == search)
                {
                    break;
                }

                // Ajouter les éléments retirés à la pile temporaire
                tempStack.Push(item);
            }

            // Remettre les éléments de la pile temporaire dans "aStack" si nécessaire
            while (tempStack.Count > 0)
            {
                aStack.Push(tempStack.Pop());
            }
        }

        // Ajouter le nouvel élément à la pile
        aStack.Push(newItem);

        // Retourner la pile modifiée
        return aStack;
    }
}
