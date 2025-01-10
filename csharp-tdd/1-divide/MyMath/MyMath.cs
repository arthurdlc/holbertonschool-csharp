using System;

namespace MyMath
{
    public class Matrix
    {
        /// <summary>
        /// Divides all elements of a matrix by a number.
        /// </summary>
        /// <param name="matrix">2D array of integers (the matrix)</param>
        /// <param name="num">The divisor</param>
        /// <returns>A new matrix with divided elements, or null on error</returns>
        public static int[,] Divide(int[,] matrix, int num)
        {
            if (matrix == null)
                return null;

            if (num == 0)
            {
                Console.WriteLine("Num cannot be 0");
                return null;
            }

            try
            {
                int rows = matrix.GetLength(0);
                int cols = matrix.GetLength(1);
                int[,] result = new int[rows, cols];

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        result[i, j] = matrix[i, j] / num;
                    }
                }

                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return null;
            }
        }
    }
}
