using System;
using System.Linq;

namespace ArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarations
            int[] storage = new int[10];
            int counter = 0;
            int counter2 = 1;
            string userEntry;

            // Tells the user what to do
            Console.WriteLine("Please enter 10 numbers one at a time and hit enter after each one.");
            while(counter < 10){
                // Try statement to catch any errors and make the user repeat the step
                try
                {
                    Console.Write("{0}: ", counter2);
                    storage[counter] = int.Parse(Console.ReadLine());
                    counter++;
                    counter2++;
                }catch
                {
                    Console.WriteLine("Your entry was invalid please try again!");
                }
            }


            // Repeatedly ask the user if they want to see the storage array or quit
            do
            {
                Console.WriteLine("\nEnter 'q' to exit or nothing to view the array");
                userEntry = Console.ReadLine();

                // Tests if user wants to quit
                if (userEntry != "q")
                {
                    // Lists each int in the storage array
                    foreach (int x in storage)
                    {
                        Console.Write("{0} ", x);
                    }
                }
            } while (userEntry != "q");

            // End of Program
            Console.WriteLine("End of program, press any key to quit.");
            Console.ReadKey();

        }
    }
}
