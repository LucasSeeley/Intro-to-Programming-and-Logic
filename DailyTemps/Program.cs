using System;

namespace DailyTemps
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarations
            const int HIGH = 130;
            const int LOW = -20;
            int counter = 0;
            int sumOfTemps = 0;
            int userEntry = 0;

            // The loop will ask the user for a daily high temp and will continue to execute until an invalid temp is entered
            do
            {
                Console.WriteLine("Please enter a daily high temperature in Fahrenheit");
                userEntry = Convert.ToInt32(Console.ReadLine());
                counter++;
                sumOfTemps += userEntry;
            } while (userEntry > LOW && userEntry < HIGH);

            // Displays an error msg
            Console.WriteLine("Error, you entered an invalid number\n");

            // Displays the number of temps entered and the avg of them
            Console.WriteLine("You entered {0} recorded tempratures. \nThe average of the entered temperatures is {1}.", counter, sumOfTemps / counter);
        }
    }
}
