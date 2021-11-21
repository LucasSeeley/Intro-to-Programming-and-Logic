using System;

namespace Paint_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the width of the wall");
            decimal width = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter the height of the wall");
            decimal height = decimal.Parse(Console.ReadLine());
            decimal area = width * height * 4;
            decimal gallons = area / 400;
            Console.WriteLine("Number of gallons to paint the walls: " + gallons + "gallons");
            Console.ReadKey();
        }
    }
}
