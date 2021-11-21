using System;
using System.Collections.Generic;
using System.Linq;

namespace Lottery
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Title = "Lottery";
            Console.WriteLine("Welcome to Caribbean Lucas' Lottery Game!\n");
            bool playGame;
            // This creates a loop for the user to play as long as they'd like. It has to go through at least once so I made it a do while loop.
            do
            {
                // Calls the PickLottery and GenerateLottery methods and assigns their values accordingly
                List<int> usersNumbers = PickLottery();
                List<int> winningNumbers = GenerateLottery();

                // Writes the user's guess and winning numbers
                Console.Write("\nYour guess was: ");
                foreach (int number in usersNumbers)
                {
                    Console.Write(number);
                }
                Console.Write("\nThe jackpot number was: ");
                foreach (int number in winningNumbers)
                {
                    Console.Write(number);
                }

                // Calls the RewardAmount method and then displays the reward
                int reward = RewardAmount(usersNumbers, winningNumbers);
                Console.WriteLine("\nCongratulations! Your reward is: $" + reward);

                // Asks the user if they want to continue playing and uses a switch method to determine whether to play again or not
                Console.WriteLine("\nWould you like to play again? (Yes/No)");
                string playAgain = Console.ReadLine().ToLower();
                switch (playAgain)
                {
                    case "yes":
                        playGame = true;
                        break;
                    case "no":
                        playGame = false;
                        break;
                    default:
                        playGame = false;
                        break;
                }

                Console.Clear();
            } while (playGame);

            Console.WriteLine("Hit any key to exit");
            Console.ReadKey();
        }


        // This method generates 3 winning lottery numbers adds them to a list, and then returns that list when called
        static List<int> GenerateLottery()
        {
            Random randomNumberGenerator = new Random();
            List<int> winningNumbers = new List<int>();

            for (int generate = 0; generate < 3; generate++)
            {
                winningNumbers.Add(randomNumberGenerator.Next(1, 5));
            }

            return winningNumbers;
        }



        // This method asks the user to pick 3 numbers and adds those numbers to a list which is then returned when called
        static List<int> PickLottery()
        {
            List<int> userNumbers = new List<int>();

            for (int pick = 1; pick <= 3; pick++)
            {
                Console.Write(pick + ": Please choose a number 1 to 4: ");
                userNumbers.Add(Convert.ToInt32(Console.ReadLine()));
            }


            return userNumbers;
        }



        // This method compares the user's guess with the winning numbers and returns the winning value accordingly
        static int RewardAmount(List<int> userNumbers, List<int> winningNumbers)
        {
            /* The reason that these are tested first is because once the numbers are removed from the list 
             * it would be impossible for them to be set equal to each other.   */
            if (userNumbers.SequenceEqual(winningNumbers))
            {
                return 10000;
            }


            int matches = 0;

            /* This for each loop will loop through each user number and 
             * if it is in the winning number list it will remove that number
             * from the winning number list to prevent duplicates.
             * It will then add to the matches count to account for
             * the amount of matches.   */
            foreach (int userNum in userNumbers)
            {
                if (winningNumbers.Contains(userNum))
                {
                    winningNumbers.Remove(userNum);
                    
                    matches++;
                }
            }

            // The switch method checks for the amount of matches and will return the value accordingly
            switch (matches)
            {
                case 1:
                    return 10;
                case 2:
                    return 100;
                case 3:
                    return 1000;
                default:
                    return 0;
            }
        }
    }
}
