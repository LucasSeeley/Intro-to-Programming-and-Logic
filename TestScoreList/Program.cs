using System;

namespace TestScoreList
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarations
            int[] testScores = new int[8];
            int average = 0;
            int counter = 1;

            // Prompts user for 8 numbers to add to the array
            Console.WriteLine("Please enter 8 test score integers");

            // Loops through array positions to insert values of the users entry
            for (int x = 0; x < 8; x++, counter++) {
                try {
                    // Try statement adds user entered value to the array
                    Console.Write("{0}: ", counter);
                    testScores[x] = int.Parse(Console.ReadLine());
                    average += testScores[x];
                }
                catch {
                    // Catch statement prevents user from entering invalid value and makes them enter it again
                    Console.WriteLine("You entered an invalid value, please try again.");
                    x--;
                    counter--;
                }
            }

            // Calculates the final average
            average /= 8;

            // Waits for user to press enter to continue
            Console.WriteLine("Processing...Press enter to view all values and how far they are from the average.");
            Console.ReadKey();

            // Lists the items in the array and how far they are from the average
            foreach(int x in testScores){
                if (x > average) {
                    Console.WriteLine("{0} is {1} points above the average of {2}", x, Math.Abs(average - x), average);
                }
                else if (x < average) {
                    Console.WriteLine("{0} is {1} points below the average of {2}", x, Math.Abs(average - x), average);
                }
                else {
                    Console.WriteLine("{0} is {1} points from the average of {2}", x, Math.Abs(average - x), average);
                }
            }

            // End of Program prompt
            Console.WriteLine("End of Program");
            Console.ReadKey();
        }
    }
}
