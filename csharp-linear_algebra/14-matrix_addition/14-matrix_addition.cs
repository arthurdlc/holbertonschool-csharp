using System;

/// <summary>
/// Class for vector math
/// </summary>
public class VectorMath
{
    /// <summary>
    /// Multiplies two matrices together if dimensions are compatible.
    /// </summary>
    /// <param name="matrix1">First matrix (m x n)</param>
    /// <param name="matrix2">Second matrix (n x p)</param>
    /// <returns>Resulting matrix (m x p) or {{-1}} if dimensions are invalid</returns>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        int rowsA = matrix1.GetLength(0);
        int colsA = matrix1.GetLength(1);
        int rowsB = matrix2.GetLength(0);
        int colsB = matrix2.GetLength(1);

        // Vérifier si la multiplication est possible
        if (colsA != rowsB)
            return new double[,] { { -1 } }; // Indique une erreur de dimension

        double[,] result = new double[rowsA, colsB];

        for (int i = 0; i < rowsA; i++)  // Parcourt les lignes de A
        {
            for (int j = 0; j < colsB; j++)  // Parcourt les colonnes de B
            {
                double sum = 0;
                for (int k = 0; k < colsA; k++)  // Somme des produits élémentaires
                {
                    sum += matrix1[i, k] * matrix2[k, j];
                }
                result[i, j] = sum;
            }
        }
        return result;
    }
}
