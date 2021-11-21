using System;
using System.Linq;

namespace CheckDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarations
            string userEntry;
            int accountNumber;
            int remainder;

            // Prompts and accepts user entry as a string
            Console.WriteLine("Please enter a valid 4-digit account number.");
            userEntry = Console.ReadLine();

            // Puts the first 3 numbers of the account into a separate variable
            accountNumber = int.Parse(userEntry.Substring(0,3));
            // Puts the last digit of the account which should be equal to the remainder into its own variable
            remainder = int.Parse(userEntry.Substring(3));

            // Tests to see if the account is valid
            if (accountNumber % 7 == remainder)
            {
                Console.WriteLine("Your account is valid!");
            }
            else
            {
                Console.WriteLine("Your account was invalid!");
            }
        }
    }
}
