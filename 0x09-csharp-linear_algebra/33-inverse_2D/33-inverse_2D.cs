using System;

class MatrixMath
{
    public static double[,] Inverse2D(double[,] matrix)
    {
        if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2) {
            double[,] flipped = new double[2, 2] {{matrix[1, 1], -matrix[0, 1]}, {-matrix[1, 0], matrix[0, 0]}};
            double determinant = (matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0]);
            if (determinant == 0) {
                return new double[,] {{-1}};
            }
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    flipped[i, j] = Math.Round(flipped[i, j] * (1 / determinant), 2);
            return flipped;
        } else {
            return new double[,] {{-1}};
        }
    }
}
