﻿// See https://aka.ms/new-console-template for more information
using System;

namespace DatesAndTimes

{
  class Program {
    static void Main(string[] args) {

      DateTime myValue = DateTime.Now;
      //Console.WriteLine(myValue.ToString());
      //Console.WriteLine(myValue.ToShortDateString());
      //Console.WriteLine(myValue.ToShortTimeString());
      //Console.WriteLine(myValue.ToLongDateString());
      //Console.WriteLine(myValue.ToLongTimeString());

      //Console.WriteLine(myValue.AddDays(3).ToLongDateString());
      //Console.WriteLine(myValue.AddHours(3).ToShortTimeString());

      //Console.WriteLine(myValue.AddDays(-3).ToLongDateString());

      //Console.WriteLine(myValue.Month);

      //DateTime myBirthday = new DateTime(1985, 6, 24);
      //Console.WriteLine(myBirthday.ToShortDateString());

      DateTime myBirthday = DateTime.Parse("6/24/1985");
      TimeSpan myAge = DateTime.Now.Subtract(myBirthday);
      Console.WriteLine(myAge.TotalDays);

      Console.ReadLine();

    }
  }
}
