using System;

namespace ParallelArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarations
            int[] scores = { 90, 80, 70, 60, 0 };
            char[] grades = { 'A', 'B', 'C', 'D', 'F' };
            int userScore;
            int index = 4;

            // Prompts and stores users response to test score
            Console.WriteLine("Please enter your test score.");
            userScore = int.Parse(Console.ReadLine());

            // Loops through scores array to find correct grade
            for(int x = 4; x >= 0; x--)
            {
                if(userScore >= scores[x])
                {
                    index = x;
                }
            }

            // Outputs the grade recieved
            Console.WriteLine("You have recieved a {0}.", grades[index]);

            // End of Program
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("End of Program");
        }
    }
}
