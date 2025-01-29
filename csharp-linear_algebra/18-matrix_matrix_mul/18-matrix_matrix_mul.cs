using System; 

/// <summary>
/// Class for matrix math
/// </summary>
/// 
public static class MatrixMath
{
    /// <summary>
    /// Multiply two matrices
    /// </summary>
    /// <param name="matrix1"></param>
    /// <param name="matrix2"></param>
    /// <returns></returns>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        int rowsA = matrix1.GetLength(0);
        int colsA = matrix1.GetLength(1);
        int rowsB = matrix2.GetLength(0);
        int colsB = matrix2.GetLength(1);

        // Vérifier si la multiplication est possible
        if (colsA != rowsB)
            return new double[,] { { -1 } }; // Retourne une matrice d'erreur si dimensions incompatibles

        double[,] result = new double[rowsA, colsB];

        for (int i = 0; i < rowsA; i++)      // Parcourt les lignes de A
            for (int j = 0; j < colsB; j++)  // Parcourt les colonnes de B
                for (int k = 0; k < colsA; k++)  // Effectue la somme des produits
                    result[i, j] += matrix1[i, k] * matrix2[k, j];

        return result;
    }
}