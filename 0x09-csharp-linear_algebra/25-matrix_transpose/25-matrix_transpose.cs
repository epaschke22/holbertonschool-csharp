using System;

class MatrixMath
{
    ///<summary>transpose a matrix</summary>
    public static double[,] Transpose(double[,] matrix)
    {
        double[,] output = new double[matrix.GetLength(1), matrix.GetLength(0)];
        for (int i = 0; i < matrix.GetLength(0); i++)
            for (int j = 0; j < matrix.GetLength(1); j++)
                output[j, i] = matrix[i, j];
        return output;
    }
}
