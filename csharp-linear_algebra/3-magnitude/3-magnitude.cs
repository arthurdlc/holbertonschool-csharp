using System;

class VectorMath
{
    /// <summary>
    /// Calculate the magnitude of a 2d or 3d vector.
    /// </summary>
    /// <param name="vector">double[] vector</param>
    /// <returns>double</returns>
    public static double Magnitude(double[] vector)
    {
        // Calculate the magnitude
        if (vector == null || vector.Length == 0)
        {
            double sum = 0;
            for (int i = 0; i < vector.Length; i++)
            {
                sum += Math.Pow(vector[i], 2);
            }
            return Math.Sqrt(sum);
        }
    }
}
