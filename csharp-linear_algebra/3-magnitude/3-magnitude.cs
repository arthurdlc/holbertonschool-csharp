using System;

class VectorMath
{
    public static double Magnitude(double[] vector)
    {
        double sum = 0;
        for (int i = 0; i < vector.Length; i++)
        {
            sum += vector[i] ** 2;
        }
        return Math.Sqrt(sum);
    }
}