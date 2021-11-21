using System;

namespace BinaryConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarations
            double binary = 0;
            double number;
            int exp = 12;
            string userEntry;

            do
            {
                // Prompts user for number
                Console.WriteLine("Enter a number to convert to binary");
                number = int.Parse(Console.ReadLine());

                while (exp >= 0)
                {
                    // Calculates binary number
                    if ((number - Math.Pow(2, exp)) >= 0)
                    {
                        number -= Math.Pow(2, exp);
                        binary += Math.Pow(10, exp);
                    }

                    exp--;
                }

                // Write out binary number
                Console.WriteLine(binary);

                // Gives option to quit
                Console.WriteLine("Enter 'q' to quit");
                userEntry = Console.ReadLine();
                Console.Clear();

                // Reset variables
                binary = 0;
                exp = 12;
            } while (userEntry != "q");

            Console.WriteLine("End of Program");
            Console.ReadKey();
        }
    }
}
