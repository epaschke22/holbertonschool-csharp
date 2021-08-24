using System;

class MatrixMath
{
    ///<summary>rotates a 2D matrix</summary>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2) {
            return new double[,] {{-1}};
        }
        double[,] rotation = new double[,] { { Math.Cos(angle), Math.Sin(angle) }, { -Math.Sin(angle), Math.Cos(angle) } };
        double[,] output = new double[2, 2];
        double total = 0;
        for (int i = 0; i < 2; i++) {
            for (int j = 0; j < 2; j++) {
                total = 0;
                for (int k = 0; k < 2; k++) {
                    total += Math.Round(matrix[i, k] * rotation[k, j], 2);
                }
                output[i, j] = total;
            }
        }
        return output;
    }
}
