﻿using System;

class VectorMath
{
    ///<summary>multiplies a vector by a scalar, 2d or 3d</summary>
    public static double[] Multiply(double[] vector, double scalar)
    {
        if (vector.Length == 2)
        {
            return new double[] { vector[0] * scalar, vector[1] * scalar };
        }
        else if (vector.Length == 3)
        {
            return new double[] { vector[0] * scalar, vector[1] * scalar, vector[2] * scalar };
        }
        else
        {
            return new double[] {-1};
        }
    }
}
