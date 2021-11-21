using System;

namespace ResortPrices
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarations
            int[] numOfNights = { 0, 1, 3, 5, 8 };
            int[] prices = { 0, 200, 180, 160, 145 };
            int userNights;
            int index = 0;

            // Prompts user for number of nights they will stay at the resort and stores it
            Console.WriteLine("Please enter the number of nights you plan to stay at the resort.");
            userNights = int.Parse(Console.ReadLine());

            // Loops through each int in numOfNights array to test for what the cost will be, default is set to $0
            foreach(int x in numOfNights)
            {
                if (userNights >= x)
                {
                    // Assigns corresponding index value for nights and price
                    index = Array.IndexOf(numOfNights, x);
                }
            }

            // Writes out the total cost and cost per night
            Console.WriteLine("Your stay will cost ${0} at ${1} per night for {2} nights", prices[index] * userNights, prices[index], userNights);

            // End of program
            Console.ReadKey();
            Console.WriteLine("End of Program");
        }
    }
}
