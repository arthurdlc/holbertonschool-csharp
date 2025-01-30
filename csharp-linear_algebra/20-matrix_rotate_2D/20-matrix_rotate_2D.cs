using System;

public class MatrixMath
{
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        // Check if the matrix is square (required for valid rotation)
        if (rows != cols)
        {
            return new double[,] { { -1 } };
        }

        double[,] rotationMatrix = new double[,] 
        {
            { Math.Cos(angle), Math.Sin(angle) },
            { -1 * Math.Sin(angle), Math.Cos(angle) }
        };

        double[,] result = new double[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = matrix[i, 0] * rotationMatrix[0, j] + matrix[i, 1] * rotationMatrix[1, j];
            }
        }
        
        return result;
    }
}
