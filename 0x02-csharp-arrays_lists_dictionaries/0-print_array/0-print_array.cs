using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size < 0) {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        int[] numbers = new int[size];
        for (int i = 0; i < size; i++) {
            numbers[i] = i;
            Console.Write(numbers[i]);
            if (i < size - 1) {
                Console.Write(" ");
            }
        }
        Console.WriteLine("");
        return numbers;
    }
}
