﻿using System;

namespace _6_print_comb2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int j;
            for (i = 0; i < 9; i++) {
                for (j = i + 1; j < 10; j++) {
                    Console.Write("{0}{1}", i, j);
                    if (i < 8) {
                        Console.Write(", ");
                    }
                }
            }
        }
    }
}
