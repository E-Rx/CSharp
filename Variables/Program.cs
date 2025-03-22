// See https://aka.ms/new-console-template for more information
using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int x = 7;
            int y = 3;
            int z = x + y;
            Console.WriteLine(z);
            Console.ReadLine();
            */

            Console.WriteLine("What is your name?");
            Console.Write("Type your first name: ");
            string myFirstName = Console.ReadLine();

            Console.Write("Type your last name: ");
            string myLastName = Console.ReadLine();

            Console.WriteLine("Hello " + myFirstName + " " + myLastName);
            Console.ReadLine();
        }
    }
}
