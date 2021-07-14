using System;

class Array
{
    public static int elementAt(int[] array, int index)
    {
        try {
            return array[index];
        } catch {
            Console.WriteLine("Index out of range");
        }
        return -1;
    }
}
