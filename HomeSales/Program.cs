using System;

namespace HomeSales
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarations
            string[,] salespeople = { { "Danielle", "d" }, { "Edward", "e" }, { "Francis", "f" } };
            float[] sales = { 0, 0, 0, 0 };
            int userIndex = 0;
            float highestTotal = 0;

            // Calls method to find correct index
            userIndex = IndexCheck(salespeople);

            // Loop runs till user enters an incorrect initial
            while (userIndex != 3)
            {
                // Asks for a sale amount and converts it to a float accumulating it to its respective position in the array
                Console.Write("Please enter the amount of your sale: ");
                sales[userIndex] += float.Parse(Console.ReadLine());

                // Waits to to clear console to continue with next process
                Console.WriteLine("Thank you for your entry, press any button to continue.");
                Console.ReadKey();
                Console.Clear();

                // Calls method to find correct index
                userIndex = IndexCheck(salespeople);

                // End of while loop
            }

            // Loops through to display the final totals and accumulates the grand total as well as calculates the highest total
            for(int i = 0; i < 3; i++)
            {
                // Writes out each total
                Console.WriteLine("{0} had a total of ${1} in sales", salespeople[i, 0], sales[i]);

                // Finds the highest total
                if (sales[i] > highestTotal)
                {
                    userIndex = i;
                    highestTotal = sales[i];
                }

                // Accumulates grand total
                sales[3] += sales[i];
            }

            // Displays grand total and highest total
            Console.WriteLine("The grand total was ${0}", sales[3]);
            Console.WriteLine("{0} had the highest total of ${1}", salespeople[userIndex, 0], highestTotal);

            // This will wait till the user presses a key to end the program
            Console.WriteLine("End of Program");
            Console.ReadKey();
        }


        public static int IndexCheck(string[,] salespeople)
        {
            // Declarations
            int userIndex = 99;
            bool isGood = false;

            // Prompts user for first initial and converts it to a lower case string
            Console.Write("Please enter your first initial: ");
            string userInitial = Console.ReadLine().ToLower();

            // Loops through to find the correct index of the sales person
            for (int i = 0; i < 3; i++)
            {
                if (userInitial == salespeople[i, 1])
                {
                    userIndex = i;
                    isGood = true;
                }
            }
            if (isGood)
                return userIndex;
            else
                return 3;
        }
    }
}