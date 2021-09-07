using System;

namespace IfStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja vanust
            //kui kasutaja on vanem, kui 18, siis konsoolis kuvatakse "oled piisavalt vana"
            //kui kasutaja on noorem, kui 18, siis konsoolis kuvatakse "oled liiga noor"
            //kui kasutaja on 18, siis konsoolis kuvatakse "oledki 18"

            Console.WriteLine("How old are you?");
            int Userage = Int32.Parse(Console.ReadLine());

            if (Userage > 18)
            {
                Console.WriteLine("You are old enough.");
            }
            else if (Userage < 18)
            {
                Console.WriteLine("You are not old enough.");
            }
            else
            {
                Console.WriteLine("You are exactly 18.");
            }
            Console.WriteLine("Have a good day!");
            Console.ReadLine();

        }
    }
}
