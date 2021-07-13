using System;

class Line
{
    public static void PrintDiagonal(int length)
    {
        if (length <= 0){
            Console.WriteLine("");
            return;
        }
        int rows;
        int spaces;
        for (rows = 0; rows < length; rows++){
            for (spaces = 0; spaces < rows; spaces++){
                Console.Write(" ");
            }
            Console.WriteLine("\\");
        }
        Console.WriteLine("");
    }
}
