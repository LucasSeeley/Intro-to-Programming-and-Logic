using System;
using System.Text;

namespace GuessAWord
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarations
            string[] words = { "snow", "bye", "hello", "irish", "movie", "funny", "laugh", "snow" };
            int rndIndex;
            string hidden;
            string guess;
            char userGuess;
            int index;
            bool quit = false;

            // Loops to play several times until user says otherwise
            while (!quit)
            {
                // Random Number Generator
                Random rndGen = new Random();
                rndIndex = rndGen.Next(0, 8);

                // Assigns the hidden word
                hidden = words[rndIndex];
                guess = hidden;

                // Replaces each char with an * by looping through
                foreach (char x in guess)
                {
                    guess = guess.Replace(x, '*');
                }

                // Strings are immutable I use a string builder so I can modify the guessing string
                StringBuilder guessStrBdr = new StringBuilder(guess);
                StringBuilder hiddenStrBdr = new StringBuilder(hidden);

                // Loops through till the user guesses the entire string
                while (guess.Contains('*'))
                {
                    // Prompts user for letter
                    Console.WriteLine("Please guess a letter to uncover the word: {0}", guess);
                    // In case of errors I am using a try catch method
                    try
                    {
                        // Assigns the user's guess
                        userGuess = char.Parse(Console.ReadLine());

                        // Tests if the user guessed incorrectly
                        if (!hidden.Contains(userGuess))
                        {
                            Console.WriteLine("Nope that letter is not in the word");
                        }
                        // If the user guessed incorrectly the loop will go through until all the letters are replaced correctly
                        while (hidden.Contains(userGuess))
                        {
                            // Grabs the index of the char
                            index = hidden.IndexOf(userGuess);

                            // Replaces * with correct letter in correct spot
                            guessStrBdr[index] = userGuess;
                            guess = guessStrBdr.ToString();

                            // Replaces letter guess with * to prevent any errors
                            hiddenStrBdr[index] = '*';
                            hidden = hiddenStrBdr.ToString();
                        }
                    }
                    catch
                    {
                        Console.WriteLine("You entered an invalid value, please try again.");
                    }
                }

                // Final congrats message
                Console.WriteLine("Congratulations! You guessed the word {0} correctly!", guess);

                Console.WriteLine("Would you like to continue? (yes/no)");
                if(Console.ReadLine().ToLower() == "no")
                {
                    quit = true;
                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                }
            }
            // End of Program-
            Console.WriteLine("End of Program");
            Console.ReadKey();
        }
    }
}
