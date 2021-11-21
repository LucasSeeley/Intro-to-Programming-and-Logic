using System;

namespace SubnetCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarations
            int numOfSubnets = 0;
            double availableSubnets = 0;
            int bits = 0;
            int subnetMask;
            bool loop = true;
            int[] IPRange;
            int[] Broadcast;
            int[] Gateway;

            // Loop continues till user enters valid entry for subnets needed
            while (loop) {
                try {
                    Console.WriteLine("How many subnets do you need?");
                    numOfSubnets = int.Parse(Console.ReadLine());
                    loop = false;
                }
                catch {
                    Console.WriteLine("You entered an invalid value please try again");
                }

            }
            // Tests how many bits will be needed and the amount of subnets will be available
            for (int x = 0; availableSubnets <= numOfSubnets; x++) {
                bits = x;
                availableSubnets = Math.Pow(numOfSubnets, x);
            }

            Console.WriteLine(bits);
        }
    }
}
