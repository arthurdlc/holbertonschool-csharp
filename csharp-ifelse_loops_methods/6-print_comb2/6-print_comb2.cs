using System;

class Program
{
    static void Main(string[] args)
    {
        // Boucle extérieure pour le premier chiffre (i)
        // Parcourt les chiffres de 0 à 9
        for (int i = 0; i < 10; i++)
        {
            // Boucle intérieure pour le deuxième chiffre (j)
            // Parcourt les chiffres de i+1 à 9 pour éviter les doublons (par ex., 12 et 21)
            for (int j = i + 1; j < 10; j++)
            {
                // Vérifie si c'est la dernière combinaison (i = 8, j = 9)
                if (!(i == 8 && j == 9))
                {
                    // Si ce n'est pas la dernière combinaison, affiche avec ", " à la fin
                    Console.Write($"{i}{j:D1}, ");
                }
                else
                {
                    // Si c'est la dernière combinaison, affiche sans la virgule et ajoute un saut de ligne
                    Console.Write($"{i}{j:D1}\n");
                }
            }
        }
    }
}
