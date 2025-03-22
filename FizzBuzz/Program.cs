// See https://aka.ms/new-console-template for more information
using System;

namespace FizzBuzz
{

  class Program
  {
      static void Main( string[] args)
      {

        // Display instructions for the user
        Console.WriteLine("Enter three integers separated by a space:");
        Console.WriteLine("- The first number is at least 1.");
        Console.WriteLine("- The second number is greater than the first.");
        Console.WriteLine("- The third number is at least as large as the second and at most 100.");


        // Read the input from the user
        string input = Console.ReadLine() ?? string.Empty;

        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Error: Input cannot be empty.");
            return;
        }

        // Check if the input contains three values
        if (input.Length != 3)
        {
            Console.WriteLine("Error: Please enter exactly three integers separated by a space.");
            return;
        }

        // split the input string into an array of values X, Y, N. Remove empty entries.
        string[] inputValues = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);


        // Convert the input values to integers
        int X = int.Parse(inputValues[0]);
        int Y = int.Parse(inputValues[1]);
        int N = int.Parse(inputValues[2]);

        // Check if the values are in the valid range
        if (!(1 <= X && X < Y && Y <= N && N <= 100))
        {
            Console.WriteLine("Invalid input: Please ensure that:");
            Console.WriteLine("- The first number is at least 1.");
            Console.WriteLine("- The second number is greater than the first.");
            Console.WriteLine("- The third number is at least as large as the second and at most 100.");
            return;
        }

        // Loop from 1 to N
        for (int i = 1; i <= N; i++)
        {
          // Check first if divisible by both X and Y
            if (i % X == 0 && i % Y == 0)
            {
                Console.WriteLine("FizzBuzz");
            }

            // Check if divisible only by X
            else if (i % X == 0)
            {
                Console.WriteLine("Fizz");
            }

            // Check if divisible only by Y
            else if (i % Y == 0)
            {
                Console.WriteLine("Buzz");
            }


            // If not divisible by either X or Y
            else
            {
                Console.WriteLine(i);
            }
          }
      }
  }
}
