using System;

namespace NineInts
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarations
            int[] nineInts = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // Sorts the array
            Array.Sort(nineInts);
            // Displays each value in the array
            foreach(int x in nineInts)
            {
                Console.WriteLine(x);
            }
            // Reverses the array order
            Array.Reverse(nineInts);
            // Displays each value in the array
            foreach (int x in nineInts)
            {
                Console.WriteLine(x);
            }

            // End of program
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("End of Program");
        }
    }
}
