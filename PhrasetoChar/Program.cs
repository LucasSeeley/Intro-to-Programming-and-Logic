using System;

namespace PhrasetoChar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarations
            string userEntry;

            // Prompts user for phrase
            Console.Write("Hello there! Please enter a phrase: ");
            userEntry = Console.ReadLine();

            Console.WriteLine("Displaying each character individually... Press enter to continue.");
            Console.ReadKey();
            // Prints out each character in the userEntry variable
            for (int x = 0 ; x < userEntry.Length ; x++) {
                Console.WriteLine("{0} ", userEntry[x]);
            }
        }
    }
}
