using System;

namespace _100_jagged_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jagged = new int[3][]
            {
                new int[] {0, 1, 2, 3},
                new int[] {0, 1, 2, 3, 4, 5, 6},
                new int[] {0, 1}
            };
            for (int row = 0; row < jagged.Length; row++) {
                for (int col = 0; col < jagged[row].Length; col++) {
                    Console.Write("{0}{1}", jagged[row][col], col == (jagged[row].Length - 1) ? "" : " ");
                }
                Console.WriteLine("");
            }
        }
    }
}
