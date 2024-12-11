using System;
using System.Collections.Generic;

public class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        // Créer un HashSet pour suivre les éléments uniques de la première liste
        HashSet<int> set1 = new HashSet<int>(list1);
        // Créer un HashSet pour suivre les éléments uniques de la deuxième liste
        HashSet<int> set2 = new HashSet<int>(list2);

        // Créer une liste pour stocker les éléments qui sont dans une liste mais pas dans les deux
        List<int> result = new List<int>();

        // Parcourir le premier ensemble et ajouter les éléments absents du second ensemble
        foreach (int num in set1)
        {
            // Vérifier si le nombre actuel est absent du second ensemble
            if (!set2.Contains(num))
            {
                // Ajouter le nombre à la liste résultante
                result.Add(num);
            }
        }

        // Parcourir le second ensemble et ajouter les éléments absents du premier ensemble
        foreach (int num in set2)
        {
            // Vérifier si le nombre actuel est absent du premier ensemble
            if (!set1.Contains(num))
            {
                // Ajouter le nombre à la liste résultante
                result.Add(num);
            }
        }

        // Trier la liste résultante pour s'assurer qu'elle est en ordre croissant
        result.Sort();

        // Retourner la liste triée des éléments uniques
        return result;
    }
}
