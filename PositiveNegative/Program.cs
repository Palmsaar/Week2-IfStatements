using System;

namespace PositiveNegative
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number.");
            int Number = Convert.ToInt32(Console.ReadLine());

            if (Number < 0)
            {
                Console.WriteLine("Your number is negative.");
            }
            else if (Number > 0)
            {
                Console.WriteLine("Your number is positive.");
            }
            else
            {
                Console.WriteLine("Your number is zero.");
            }
            Console.ReadLine();
        }
    }
}
