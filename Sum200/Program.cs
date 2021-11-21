using System;

namespace Sum200
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarations
            int total = 0;

            // For loop will go through each number 1 through 200
            for (int x = 1; x <= 200; x++)
            {
                // This will accumulate the running total of all numbers 1 through 200
                total += x;
                
                // The if statements tests to see if it is halfway(100) through the numbers and display the current total
                if(x == 100)
                {
                    Console.WriteLine("The current total after adding the first 100 numbers is {0}", total);
                }
            }

            // This will display the final sum of the 200 numbers
            Console.WriteLine("The final sum of the first 200 numbers is {0}", total);
        }
    }
}
