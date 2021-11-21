using System;

namespace SumFiveInts
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarations, total would be your accumulator and counter the counter
            int counter = 1;
            int total = 0;
            
            // While loop asks the user to enter a number 5 times and then adds it to the current total
            while(counter != 6)
            {
                Console.WriteLine("{0}: Please enter a number to add", counter);
                total += int.Parse(Console.ReadLine());

                counter++;
            }

            // Writes out the sum of the five numbers
            Console.WriteLine("The total value is {0}", total);
        }
    }
}
