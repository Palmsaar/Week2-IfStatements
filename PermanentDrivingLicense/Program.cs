using System;

namespace PermanentDrivingLicense
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat
            // programm kontrollib kasutaja vanust 
            // programm teatab kasutajat, kas ta on piisavalt vaba
            //et juhiluba saada
            Console.WriteLine("What year were you born?");
            int UserYear = Int32.Parse(Console.ReadLine());
            int UserAge = 2021 - UserYear;
            if (UserAge >= 18)
            {
                Console.WriteLine("You are old enough to get a license.");
            }
            else
            {
                Console.WriteLine("You are not old enough to get a license.");
            }

            Console.WriteLine("Have a good day!");
            Console.ReadLine();
        }
    }
}
