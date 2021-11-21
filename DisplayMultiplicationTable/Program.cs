using System;

namespace DisplayMultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            // Loops through the first number up through 10
            for(int first = 1; first <= 10; first++)
            {
                // Nested loop will loop up through 10
                for (int second = 1; second <= 10; second++)
                {
                    // for each number of the two loops they will be multiplied then displayed
                    int product = first * second;
                    Console.WriteLine("Product of {0} and {1} is {2}", first, second, product);
                }
            }
        }
    }
}
