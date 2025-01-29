using System;

/// <summary>
/// class for matrix math
/// </summary>
    class MatrixMath
    {
        /// <summary>
        /// add two matrices
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public static double[,] MultiplyScalar(double[,] matrix, double scalar)
        {
            int matrixRowLength = matrix.GetLength(0);
            int matrixColLength = matrix.GetLength(1);
            if ((matrixRowLength != 2 && matrixRowLength != 3))
                return new double[,] { {-1}};
            
            double[,] result = new double[matrixRowLength, matrixColLength];
            for (int i = 0; i < matrixRowLength; i++)
                for (int y = 0; y < matrixColLength; y++)
                    result[i, y] = matrix[i, y] * scalar;
            return result;
        }
    }
