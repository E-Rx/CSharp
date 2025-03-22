// See https://aka.ms/new-console-template for more information

using System;

class Echo
{
    static void Main( string[] args)
    {

      string word = "";

      while (true)
    {
        // Display instructions for the user
        Console.WriteLine("Enter a single word containing only letters and no more than 15 characters:");

        // Read user input
        word = Console.ReadLine()?.Trim() ?? string.Empty;

        // Check if the word is not empty, contains only letters, and does not more than 15 characters
        if (string.IsNullOrEmpty(word) || word.Length > 15)
        {
            Console.WriteLine("Invalid input. Try again.");
            continue;
        }

        // Check if each character is a letter
          bool isValid = true;
          foreach (char c in word)
          {
              if (!char.IsLetter(c))
              {
                  Console.WriteLine("Invalid input. Please enter a word containing only letters. Try again.");
                  isValid = false;
                  break;
              }
          }

          if (!isValid)
          {
              continue;
          }


        break;

      }

        // Print the word three times, separated by spaces
        Console.WriteLine($"{word} {word} {word}");
    }
}
