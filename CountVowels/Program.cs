using System;

namespace CountVowels
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarations
            string phrase;
            int numOfVowels = 0;

            Console.WriteLine("Welcome please enter a word or phrase");
            phrase = Console.ReadLine();
            
            // Counts the amount of vowels in the phrase variable
            foreach(char letter in phrase.ToLower())
            {
                if(letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
                {
                    // Increments the number of vowels in the phrase variable
                    numOfVowels++;
                }
            }

            // Writes out the number of vowels
            Console.WriteLine("There are {0} vowels in your phrase: {1}", numOfVowels, phrase);
        }
    }
}
