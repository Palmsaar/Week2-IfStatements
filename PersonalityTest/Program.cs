using System;

namespace PersonalityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite color?");
            string Usercolor = Console.ReadLine().ToLower();

            if (Usercolor == "punane")
            {
                Console.WriteLine("You are romanitc!");
            }
            else if (Usercolor == "sinine")
            {
                Console.WriteLine("You are industrious!");
            }
            else if (Usercolor == "roheline")
            {
                Console.WriteLine("You are natures friend!");
            }
            else
            {
                Console.WriteLine($"You are a {Usercolor} unicorn!");
            }
            Console.ReadLine();
        }
    }
}
