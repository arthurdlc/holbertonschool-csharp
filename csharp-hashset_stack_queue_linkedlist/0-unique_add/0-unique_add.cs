using System;
using System.Collections.Generic;

class List
{
    // Méthode qui calcule la somme des entiers uniques
    public static int Sum(List<int> myList)
    {
        // Utiliser un HashSet pour stocker les valeurs uniques, donc pas de doubles 
        HashSet<int> uniqueNumbers = new HashSet<int>();

        // Ajouter chaque élément de la liste au HashSet
        foreach (int number in myList)
        {
            uniqueNumbers.Add(number);
        }

        // Retourner la somme des éléments uniques
        int sum = 0;
        foreach (int number in uniqueNumbers)
        {
            sum += number;
        }

        return sum;
    }
}
