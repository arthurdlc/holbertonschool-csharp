using System;

/// <summary>
/// class for matrix math
/// </summary>
class MatrixMath
{
    /// <summary>
    /// rotate a 2d matrix given an angle in radians
    /// </summary>
    /// <param name="matrix"></param>
    /// <param name="angle"></param>
    /// <returns></returns>
   public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        // Check if the matrix is square.
        if (rows != cols)
        {
            return new double[,] { { -1 } };
        }

        // Check if the direction is valid.
        if (direction != 'x' && direction != 'y')
        {
            return new double[,] { { -1 } };
        }

        // Create the shear matrix.
        double[,] shearMatrix;
        if (direction == 'x')
        {
            shearMatrix = new double[,] { { 1, factor }, { 0, 1 } };
        }
        else
        {
            shearMatrix = new double[,] { { 1, 0 }, { factor, 1 } };
        }

        // Create the result matrix.
        double[,] result = new double[rows, cols];

        // Multiply the shear matrix by the original matrix.
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = 0;
                for (int k = 0; k < cols; k++)
                {
                    result[i, j] += shearMatrix[i, k] * matrix[k, j];
                }
            }
        }

        return result;
    }
}