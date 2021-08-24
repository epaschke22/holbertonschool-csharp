using System;

class VectorMath
{
    ///<summary>gets the cross product of 2 3D vectors</summary>
    public static double[] CrossProduct(double[] vector1, double[] vector2)
    {
        if (vector1.GetLength(0) == 3 && vector2.GetLength(0) == 3) {
            return new double[3] {vector1[1] * vector2[2] - vector1[2] * vector2[1], vector1[2] * vector2[0] - vector1[0] * vector2[2], vector1[0] * vector2[1] - vector1[1] * vector2[0]};
        } else {
            return new double[] {-1};
        }
    }
}
