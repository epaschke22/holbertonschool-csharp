using System;

namespace _14_rectangular_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] grid = new int[5,5];
            grid[2,2] = 1;
            for (int row = 0; row < grid.GetLength(0); row++) {
                for (int col = 0; col < grid.GetLength(1); col++) {
                    Console.Write("{0} ", grid[row,col]);
                }
                Console.WriteLine("");
            }
        }
    }
}
