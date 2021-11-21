using System;
using System.Linq;

namespace DeliveryCharges
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarations
            int[] validZips = { 16801, 16802, 16803, 16804, 16805, 17063, 17084, 17004, 17044, 17009 };
            double[] prices = { .17, .38, .20, 1.01, .08, .82, 2.36, 1.38, .42, .03 };
            int userZip;
            int position;

            // Prompts user for zip code and stores it to variable
            Console.WriteLine("Please enter your zip code for delivery.");
            userZip = int.Parse(Console.ReadLine());

            // Tests if the users zipcode is a part of the array
            if (validZips.Contains(userZip))
            {
                // Gets the position of the corresponding delivery fee
                position = Array.IndexOf(validZips, userZip);
                // Tells the user the zip code they entered and their corresponding fee
                Console.WriteLine("Your zip code, {0}, has a delivery fee of {1}", userZip, prices[position]);
            }
            else{
                // Tells the user their zip is not serviceable
                Console.WriteLine("Your zip code is not serviceable.");
            }

            // End of Program
            Console.ReadKey();
            Console.WriteLine("End of Program");
        }
    }
}
