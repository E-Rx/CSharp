﻿// See https://aka.ms/new-console-template for more information
using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
          /*
          int number1 = 4;
          int number2 = 8;
          int number3 = 15;
          int number4 = 16;
          int number5 = 23;

          if (number1 == 16)
          {
          }
          else if (number2 == 16)
          {
          }
          else if (number3 == 16)
          {
          }
        */

          /*
          int [] numbers = new int[5];
          numbers[0] = 4;
          numbers[1] = 8;
          numbers[2] = 15;
          numbers[3] = 16;
          numbers[4] = 23;
          //numbers[5] = 42;

          //Console.WriteLine(numbers[1]);
          Console.WriteLine(numbers.Length);
          */

          //int[] numbers = new int [] { 4, 8, 15, 16, 23, 42 };
          string[] names = new string[] { "Eddie", "Alex", "Michael", "David Lee" };

          /*

          for (int i = 0; i < names.Length; i++)
          {
            Console.WriteLine(names[i]);
          }
            Console.ReadLine();

          */

          /*
          foreach (string name in names)
          {
            Console.WriteLine(name);
          }
          Console.ReadLine();
          */

          string zig = "You can get what you want out of life" +
          "if you help enough other people get what they want.";
          char[] charArray = zig.ToCharArray();
          Array.Reverse(charArray);

          foreach (char zigChar in charArray)
          {
            Console.Write(zigChar);
          }
          Console.ReadLine();
        }
    }
}
