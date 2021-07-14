using System;

class Matrix
{
    public static int[,] Square(int[,] myMatrix)
    {
        for (int row = 0; row < myMatrix.GetLength(0); row++) {
            for (int col = 0; col < myMatrix.GetLength(1); col++) {
                myMatrix[row,col] = myMatrix[row,col] * myMatrix[row,col];
            }
        }
        return myMatrix;
    }
}

