using System;

class MatrixMath
{
    ///<summary>rotates a 2D matrix</summary>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        double[,] rotation = new double[,] { { Math.Cos(angle), -Math.Sin(angle) }, { Math.Sin(angle), Math.Cos(angle) } };
        return Multiply(matrix, rotation);
    }

    ///<summary>multiplies 2 matricies</summary>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        int M1row = matrix1.GetLength(0);
        int M1col = matrix1.GetLength(1);
        int M2row = matrix2.GetLength(0);
        int M2col = matrix2.GetLength(1);
        double[,] output = new double[M1row, M2col];
        double total = 0;
        if (M1col != M2row) {
            return new double[,] {{-1}};
        } else {
            for (int i = 0; i < M1row; i++) {
                for (int j = 0; j < M2col; j++) {
                    total = 0;
                    for (int k = 0; k < M1col; k++) {
                        total += matrix1[i, k] * matrix2[k, j];
                    }
                    output[i, j] = Math.Round(total, 1);
                }
            }
        }
        return output;
    }
}
