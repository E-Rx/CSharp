// See https://aka.ms/new-console-template for more information
using System;

namespace AddTwoNumbers
{
  class Program
  {
    static void Main(string[] args)
    {
        // Loop until the user enters valid input (continue/break)
        while (true)
      {

        // Display instructions for the user
        Console.WriteLine("Enter two integers separated by a space (0 to 1000000):");

        // Read the input from the user
        string input = Console.ReadLine() ?? ""; // Null-coalescing operator to handle null input
        //string input = Console.ReadLine(); (warning CS8600: Converting null literal or possible null value to non-nullable type.)

        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Error");
            continue;
        }

        // Split the input string into an array of strings using the space character as separator
        string[] numbers = input.Split(' ');

        // Check if the input contains two values
        if (numbers.Length != 2)
        {
            Console.WriteLine("Error: Please enter exactly two integers separated by a space.");
            continue;
        }

        // Check if the values are integers
        if (!int.TryParse(numbers[0], out int a) || !int.TryParse(numbers[1], out int b))
        {
            Console.WriteLine("Error: Both values must be valid integers.");
            continue;
        }

        // Check if the values are in the valid range
        if (a < 0 || a > 1000000 || b < 0 || b > 1000000)
        {
            Console.WriteLine("Error: Values are out of range");
            continue;
        }

        Console.WriteLine($"The sum of {a} and {b} is: {a + b}");
        break;


      }
    }

  }
}
