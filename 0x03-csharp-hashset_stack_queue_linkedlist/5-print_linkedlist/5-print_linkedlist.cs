using System;
using System.Collections.Generic;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        var output = new LinkedList<int>();
        for (int i = 0; i < size; i++) {
            output.AddLast(i);
            Console.WriteLine(i);
        }
        return output;
    }
}
