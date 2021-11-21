using System;
using System.Linq;

namespace ArrayDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarations
            double[] storage = new double[10];
            int counter = 1;

            Console.WriteLine("Welcome! Please enter a series of numbers to add to the array");
            // Loops through element positions to add to the array
            for(int x = 0 ; x<10 ; x++) {
                try {
                    // Adds to the array
                    Console.Write("{0}: ", counter);
                    storage[x] = double.Parse(Console.ReadLine());
                }
                catch {
                    // Resets to make the user try entering the value again
                    Console.WriteLine("You entered an invalid value please try again");
                    counter--;
                    x--;
                }
                // Increment the counter to display
                counter++;
            }

            Console.WriteLine("Displaying numbers in the array... Press enter to continue.");
            Console.ReadKey();
            // Displays all numbers in the array
            foreach(double x in storage){
                Console.Write("{0}, ", x);
            }

            // Adds counter variable to array element and displays the new value
            Console.WriteLine("\nDisplaying new values after increment process... Press enter to continue.");
            Console.ReadKey();
            for (int x = 0 ; x < 10 ; x++) {
                storage[x] += x;
                Console.Write("{0}, ", storage[x]);
            }
        }
    }
}
