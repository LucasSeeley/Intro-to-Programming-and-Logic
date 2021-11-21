using System;
using static System.Console;

namespace ShadyRestHotel
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarations
            string userEntry = null;
            int userChoice = 0;
            int totalPrice = 0;

            // Allows the user to buy multiple rooms until they enter n or N
            while (userEntry != "n" && userEntry != "N")
            {


                // Asks the user to choose an option for their room
                WriteLine("Please choose one of the corresponding numbers for your room options:\n1: Queen Bed - $125\n2: King Bed - $139\n3: Suite with a King Bed and Pullout Sofa - $165");
                // Converts the user's selection to an int
                userChoice = int.Parse(ReadLine());

                /* Goes through what the user's choice was and displays the corresponding message. 
                 * If it was an invalid choice it will tell the user and set the price to zero. */
                switch (userChoice)
                {
                    case 1:
                        WriteLine("You chose a Queen Bed\nYour price is: $125");
                        totalPrice += 125;
                        break;
                    case 2:
                        WriteLine("You chose a King Bed\nYour price is: $139");
                        totalPrice += 139;
                        break;
                    case 3:
                        WriteLine("You chose a Suite with a King Bed and Pullout Sofa\nYour price is: $165");
                        totalPrice += 165;
                        break;
                    default:
                        WriteLine("You entered an invalid value!\nYour price is 0$");
                        break;
                }

                // Write the users current total and asks if they'd like to add another room
                WriteLine("Your current total is {0}", totalPrice);
                WriteLine("If you would like to continue and add another room hit enter, otherwise type 'N' or 'n'");
                userEntry = ReadLine();

            }

            // Finsihing line just says thank you and displays the final price
            WriteLine("Thank you for shopping with us today! Your total is ${0}", totalPrice);
            ReadKey();
        }
    }
}
