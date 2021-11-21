using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // This block of code declares and generates a random number between 1(inclusive) and 11(exclusive) meaning a number between 1 and 10
            Random randomNumberGenerator = new Random();
            int randomNumber = randomNumberGenerator.Next(1, 11);

            // Declarations
            int tries = 10;
            int userNumber;
            int previousGuess = 0;
            // This will test if the user already guessed to high or too low
            bool isHighAgain = false;
            bool isLowAgain = false;
            
            
            // I used a do while loop because the user will need to enter a guess at least once and this loop will then execute until the user guesses correctly
            do
            {
                // This tells the user how many guesses are left
                Console.WriteLine("You have {0} guesses", tries);
                // The following block asks the user to guess a number and then converts the users input to an integer
                Console.WriteLine("Please guess a number between 1 and 10");
                userNumber = Convert.ToInt32(Console.ReadLine());

                // The following if statements test to see if the number the user guessed was above, below, or exactly the same as the random number and displays the results
                if (userNumber > randomNumber)
                {
                    // Tests if user made a "dumb" answer and discriminates them for it
                    if (previousGuess < userNumber && isHighAgain == true)
                    {
                        Console.WriteLine("Now I just told you {0} was too high, why would you guess {1}?", previousGuess, userNumber);
                    }
                    else
                    {
                        Console.WriteLine("Your guess was too high!");
                        // This will prevent being discriminated at the wrong time
                        isHighAgain = true;
                        isLowAgain = false;
                    }
                }
                else if (userNumber < randomNumber)
                {
                    // Tests if user made a "dumb" answer and discriminates them for it
                    if (previousGuess > userNumber && isLowAgain == true)
                    {
                        Console.WriteLine("Now I just told you {0} was too low, why would you guess {1}?", previousGuess, userNumber);
                    }
                    else
                    {
                        Console.WriteLine("Your guess was too low!");
                        // This will prevent being discriminated at the wrong time
                        isLowAgain = true;
                        isHighAgain = false;
                    }
                }
                else
                    Console.WriteLine("Great job! You guessed the number!");

                tries--;
                previousGuess = userNumber;
            } while (userNumber != randomNumber && tries != 0);
            // Displays the number of tries made
            Console.WriteLine("You made {0} attempts.", 10 - tries);
        }
    }
}
