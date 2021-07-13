using System;

namespace 0-positive_or_negative
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rndm = new Random();
            int number = rndm.Next(-10, 10);
            if (number > 0) {
                Console.WriteLine("{0} is positive", number);
            } else if (number == 0) {
                Console.WriteLine("{0} is zero", number);
            } else {
                Console.WriteLine("{0} is negative", number);
            }
        }
    }
}
