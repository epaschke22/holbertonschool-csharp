using System;

class VectorMath
{
    ///<summary>adds 2 vectors together, 2d or 3d</summary>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        if (vector1.Length == 2 && vector2.Length == 2)
        {
            double[] output = new double[] { vector1[0] + vector2[0], vector1[1] + vector2[1] };
            return output;
        }
        else if (vector1.Length == 3 && vector2.Length == 3)
        {
            double[] output = new double[] { vector1[0] + vector2[0], vector1[1] + vector2[1], vector1[2] + vector2[2] };
            return output;
        }
        else
        {
            double[] output = new double[] {-1};
            return output;
        }
    }
}
