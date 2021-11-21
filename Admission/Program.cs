using System;

namespace Admission
{
    class Program
    {
        static void Main(string[] args)
        {
            float GPA;
            float testScore;

            Console.WriteLine("Please enter your GPA");
            GPA = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your test score");
            testScore = float.Parse(Console.ReadLine());

            if (GPA >= 3.0 && testScore >= 60)
            {
                Console.WriteLine("Accept");
            }
            else if (GPA < 3.0 && testScore >= 80)
            {
                Console.WriteLine("Accept");
            }
            else
                Console.WriteLine("Reject");
        }
    }
}
