using System;

namespace MyFriends
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarations
            string[] myFriends = new string[12];

            // Loops through to have user enter names to the array
            for(int x = 0; x < 12; x++)
            {
                Console.WriteLine("Please enter a name to add to the array.");
                myFriends[x] = Console.ReadLine();
            }

            // Asks user to hit a key then clears the console
            Console.WriteLine("Press any key to see the names in alphabetical order and then reversed");
            Console.ReadKey();
            Console.Clear();
            
            // Sorts the array in alphabetical order and then calls the display method
            Array.Sort(myFriends);
            DisplayFriends(myFriends);
            // Reverses the array in the opposite alphabetical order and then calls the display method
            Array.Reverse(myFriends);
            DisplayFriends(myFriends);

            // End of program
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("End of Program");
        }

        // Method that displays all the strings in the array
        static void DisplayFriends(Array myFriends)
        {
            foreach(string friend in myFriends)
            {
                Console.Write("{0}, ", friend);
            }
            Console.Write("\n");
        }
    }
}
