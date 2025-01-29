using System;

/// <summary>
/// Class for vector math
/// </summary>
class VectorMath
{
    /// <summary>
    /// Multiplies a 2D or 3D vector by a scalar.
    /// </summary>
    /// <param name="vector">The input vector (2D or 3D).</param>
    /// <param name="scalar">The scalar value.</param>
    /// <returns>The resulting vector, or null if the input is invalid.</returns>
    public static double[] Multiply(double[] vector, double scalar)
    {
        if (vector.Length < 2 || vector.Length > 3)
            return null; // Return null to indicate an invalid input.

        double[] result = new double[vector.Length];
        for (int i = 0; i < vector.Length; i++)
            result[i] = vector[i] * scalar;

        return result;
    }
}
