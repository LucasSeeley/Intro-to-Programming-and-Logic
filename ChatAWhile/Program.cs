using System;
using System.Linq;

namespace ChatAWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarations
            int[] areaCode = { 262, 414, 608, 715, 815, 920 };
            double[] costPerMin = { .07, .10, .05, .16, .24, .14 };
            int userMins;
            int userCode;
            double userRate;
            int index;


            // Prompt user for area code and stores it
            Console.WriteLine("Please enter your area code.");
            userCode = int.Parse(Console.ReadLine());

            //  Tests if the user's areacode is valid
            if (areaCode.Contains(userCode))
            {
                // Prompts user for how many mins they were on the phone and stores it to var
                Console.WriteLine("How many minutes were you on the phone for?");
                userMins = int.Parse(Console.ReadLine());
                // Finds the index of the user's area code and stores it to a var and then uses that index to find the corresponding rate
                index = Array.IndexOf(areaCode, userCode);
                userRate = costPerMin[index];
                // Outputs the total cost repeats the area code and tells them what the rate was
                Console.WriteLine("Your cost is ${0} in the area code {1} at ${2} per minute.", userRate * userMins, userCode, userRate);
            }
            else
            {
                Console.WriteLine("You entered an invalid area code. Goodbye.");
            }

            // End of Program
            Console.ReadKey();
            Console.WriteLine("End of Program");
        }
    }
}
