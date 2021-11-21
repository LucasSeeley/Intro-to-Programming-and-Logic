using System;
using System.Collections.Generic;

namespace CheckMonth2
{
    class Program
    {
        static void Main(string[] args)
        {
            int userBirthMonth;
            int userBirthDay;

            // Prompt user for birth month and day and converts to an int
            Console.WriteLine("Hello, please enter your birth month. (1-12)");
            userBirthMonth = int.Parse(Console.ReadLine());
            Console.WriteLine("Now please enter your birth day.");
            userBirthDay = int.Parse(Console.ReadLine());

            // Passes the two values to the module to be validated
            ValidateBirth(userBirthMonth, userBirthDay);

            // This is just meant to keep that jumble of words at the end from popping up until a button is hit
            Console.ReadKey();
        }

        // The enum organizes the months in correspondant with their number to make it easy to identify how many days are in the month
        enum Months
        {
            JANUARY = 1,
            FEBRUARY,
            MARCH,
            APRIL,
            MAY,
            JUNE,
            JULY,
            AUGUST,
            SEPTEMBER,
            OCTOBER,
            NOVEMBER,
            DECEMBER
        }

        static void ValidateBirth(int userBirthMonth, int userBirthDay)
        {
            string month;
            // The lists determine which months have how many days in them except for february whom is a special case
            List<string> _30DayList = new List<string>()
            {
                "APRIL", "JUNE", "SEPTEMBER", "NOVEMBERR"
            };
            List<string> _31DayList = new List<string>()
            {
                "JANUARY", "MARCH", "MAY", "JULY", "AUGUST", "OCTOBER", "DECEMBER"
            };

            // This if statement determines if the month value entered is valid
            if (userBirthMonth >= 1 && userBirthMonth <= 12)
            {
                // This will turn the number the user entered into the corresponding month
                month = Enum.GetName(typeof(Months), userBirthMonth);

                // This if block determines how many days are in the month and if the userBirthDay var is valid
                if (_30DayList.Contains(month) && userBirthDay >= 1 && userBirthDay <= 30)
                {
                    Console.WriteLine("Your birthday is {0} {1}. Cool!", month, userBirthDay);
                }
                else if (_31DayList.Contains(month) && userBirthDay >= 1 && userBirthDay <= 31)
                {
                    Console.WriteLine("Your birthday is {0} {1}. Cool!", month, userBirthDay);
                }
                else if (month == "FEBRUARY" && userBirthDay >= 1 && userBirthDay <= 29)
                {
                    Console.WriteLine("Your birthday is {0} {1}. Cool!", month, userBirthDay);
                }
                else
                    Console.WriteLine("You entered an invalid birth day.");
            }
            else
                Console.WriteLine("You entered an invalid birth month");
        }
    }
}
