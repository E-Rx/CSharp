// See https://aka.ms/new-console-template for more information
using System;

namespace Decisions
{

  class Program
  {
    static  void Main(string[] args)
    {
      /*
      Console.WriteLine("Game of Doors");
      Console.Write("Choose a door: 1, 2 or 3: ");
      string userValue = Console.ReadLine();

      string message = "";

      if (userValue == "1")
        message = "You win a new car!";
       else if (userValue == "2")
        message = "You win a new boat!";
      else if (userValue == "3")
        message = "You win a new cat!";
      else
      {
        message = "Sorry, we didn't understand that!";
        message += " You lose!";
      }

      Console.WriteLine(message);
      Console.ReadLine();
    }
    */

      Console.WriteLine("Game of Doors");
      Console.Write("Choose a door: 1, 2 or 3: ");
      string userValue = Console.ReadLine();

      string message = (userValue == "1") ? "boat" : "strand of lint";

      // Console.WriteLine("You won a {0}.", message);
      Console.WriteLine("You entered: {0}, therefore you won a {1}.", userValue, message);
      Console.ReadLine();
    }
  }
}
