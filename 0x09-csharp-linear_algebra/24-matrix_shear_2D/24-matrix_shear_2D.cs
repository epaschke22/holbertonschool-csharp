using System;

class MatrixMath
{
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        if ((matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2) || (direction != 'x' && direction != 'y')) {
            return new double[,] {{-1}};
        }
        double[,] rotation = new double[2, 2];
        if (direction == 'x'){
            rotation = new double[,] { { 1, 0 }, { factor, 1 } };
        } else {
            rotation = new double[,] { { 1, factor }, { 0, 1 } };
        }
        double[,] output = new double[2, 2];
        for (int i = 0; i < 2; i++) {
            for (int j = 0; j < 2; j++) {
                for (int k = 0; k < 2; k++) {
                    output[i, j] = Math.Round(output[i, j] + matrix[i, k] * rotation[k, j], 2);
                }
            }
        }
        return output;
    }
}
