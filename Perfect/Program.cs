using System;

namespace Perfect
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarations
            int maxNumber = 10000;
            int lowNumber = 1;

            // Welcome statement, says what the program does
            Console.WriteLine("Welcome! The following program will list all perfect numbers 1 to 10,000");

            // Loops through the potential perfect numbers
            for (int i = lowNumber; i <= maxNumber; i++)
            {
                int sum = 0;

                // Loops through numbers to check if a number is perfect
                for (int j = 1; j < i; j++)
                {
                    // Tests if a number's modulus is equal to 0
                    if (i % j == 0)
                    {
                        sum += j;
                    }
                }
                // Tests if sum is equal to the potential perfect number
                if (sum == i)
                {
                    // Writes out all the perfect numbers
                    Console.Write("\t" + i);
                }
            }
        }
    }
}
