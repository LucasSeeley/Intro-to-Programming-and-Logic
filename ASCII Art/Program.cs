using System;

namespace FunShit
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = "Fun Shit";
            Console.Title = title;

            Console.WriteLine("Please enter what you want this to be called");
            title = Console.ReadLine();
            Console.Title = title;

            Console.ReadKey();
        }
    }
}
