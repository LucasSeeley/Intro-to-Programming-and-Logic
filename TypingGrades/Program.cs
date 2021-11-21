using System;
using System.Linq;

namespace TypingGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarations
            // In words typed array I used 1000 as it is beyond impossible to have a typing speed that fast
            int[] wordsTyped = { 0, 16, 31, 51, 76 };
            char[] grade = { 'F', 'D', 'C', 'B', 'A' };
            int userWords;
            int index = 0;

            // Prompts and stores user's words typed per minute
            Console.WriteLine("Please enter your number of words typed per minute.");
            userWords = int.Parse(Console.ReadLine());

            // Loops through to find the index of the words per minute score
            foreach(int x in wordsTyped)
            {
                // Tests if the user's speed is greater than what is in the array to assign the index value to a var
                if(userWords >= x)
                {
                    index = Array.IndexOf(wordsTyped, x);
                }
            }

            // Displays the grade and repeats words per min
            Console.WriteLine("Your grade is a(n) {0} for having {1} words per minute.", grade[index], userWords);
        }
    }
}
