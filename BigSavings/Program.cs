using System;

namespace BigSavings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarations
            int balance = 1000;
            int userEntry = 0;

            // Repeatedly asks user to enter a deposit amount until userEntry = 1111 or balance reaches 10000
            while(userEntry != 1111 && balance < 10000)
            {
                Console.WriteLine("Enter an amount to deposit or enter 1111 to quit");
                userEntry = int.Parse(Console.ReadLine());

                balance += userEntry;

                Console.WriteLine("Your current balance: {0}", balance);
            }

            Console.WriteLine("End of Program");
        }
    }
}
