using System;
using System.Linq;

namespace CheckZips
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarations
            int[] validZips = { 16801, 16802, 16803, 16804, 16805, 17063, 17084, 17004, 17044, 17009 };
            int userZip;

            // Prompts user for zip code and stores it to a variable
            Console.WriteLine("Hello, please enter your zip code to see if you are serviceable.");
            userZip = int.Parse(Console.ReadLine());

            // Tests if the user's zip is in the array and displays the corresponding message
            if (validZips.Contains(userZip)) {
                Console.WriteLine("Congrats, you are in the delivery area!");
            }
            else {
                Console.WriteLine("You are not in the delivery area");
            }

            // End of Program
            Console.ReadKey();
            Console.WriteLine("End of Program");
        }
    }
}
