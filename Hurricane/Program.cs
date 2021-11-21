using System;

namespace Hurricane
{
    class Program
    {
        static void Main(string[] args)
        {
            int windSpeed;

            Console.WriteLine("Please enter the wind speed");
            windSpeed = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(CalculateCategory(windSpeed));
        }

        static string CalculateCategory(int windSpeed)
        {
            int cat5Speed = 157;
            int cat4Speed = 130;
            int cat3Speed = 111;
            int cat2Speed = 96;
            int cat1Speed = 74;

            if (windSpeed >= cat5Speed)
            {
                return "Category 5";
            }
            else if (windSpeed >= cat4Speed && windSpeed < cat5Speed)
            {
                return "Category 4";
            }
            else if (windSpeed >= cat3Speed && windSpeed < cat4Speed)
            {
                return "Category 3";
            }
            else if (windSpeed >= cat2Speed && windSpeed < cat3Speed)
            {
                return "Category 2";
            }
            else if (windSpeed >= cat1Speed && windSpeed < cat2Speed)
            {
                return "Category 1";
            }
            else
                return "Not a hurricane";
        }
    }
}
