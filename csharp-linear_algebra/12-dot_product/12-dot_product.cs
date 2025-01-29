using System;

/// <summary>
/// Class for vector math
/// </summary>  
public class VectorMath
{
    /// <summary>
    /// Multiply a 2d / 3d vector by a scalar
    /// </summary>
    /// 
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        if (vector1.Length != vector2.Length || vector1.Length < 2 || vector1.Length > 3
        || vector2.Length < 2 || vector2.Length > 3)
            return -1;

        double result = 0;
        for (int i = 0; i < vector1.Length; i++)
            result += vector1[i] * vector2[i];
        return result;
    }
}