using System;

namespace CheckMonth
{
    class Program
    {
        static void Main(string[] args)
        {
            int userBirthMonth;

            // Prompts user for birth month and converts to int
            Console.WriteLine("Hello, please enter your birth month. (1-12)");
            userBirthMonth = int.Parse(Console.ReadLine());

            // This if block validates the number the user entered
            if (userBirthMonth >= 1 && userBirthMonth <= 12)
            {
                Console.WriteLine("{0} is a valid month", userBirthMonth);
            }
            else
                Console.WriteLine("{0} is not a valid month", userBirthMonth);
        }
    }
}
