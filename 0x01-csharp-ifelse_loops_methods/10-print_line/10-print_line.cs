using System;

class Line
{
    public static void PrintLine(int length)
    {
        int i;
        for (i = length; i > 0; i--) {
            Console.Write("_");
        }
        Console.WriteLine("");
    }
}
