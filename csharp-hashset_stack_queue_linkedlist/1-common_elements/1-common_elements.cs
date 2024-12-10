using System;
using System.Collections.Generic;

class List
{
    // Méthode pour trouver les éléments communs entre deux listes
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        // Utiliser un HashSet pour stocker les éléments de la première liste
        HashSet<int> elementsSet = new HashSet<int>(list1);
        List<int> commonElements = new List<int>();

        // Parcourir la deuxième liste pour trouver les éléments communs
        foreach (int number in list2)
        {
            if (elementsSet.Contains(number))
            {
                commonElements.Add(number);
            }
        }

        // Trier la liste des éléments communs
        commonElements.Sort();

        return commonElements;
    }
}
