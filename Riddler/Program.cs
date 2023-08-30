using System;
using Riddle.Models;

namespace ShapeTracker
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("Welcome to your Doom....");
      Console.WriteLine("I am the Riddle Sphinx...");
      Console.WriteLine("Answer my question correctly to survive D:");
      Console.WriteLine("Are you ready to begin? Enter 'yes' to proceed, or 'no' to exit the console");
      string userInput = Console.ReadLine();
      if (userInput == "yes")
      {
        Console.WriteLine("Answer the following: \n {Riddle}");
      }
    }
  }
}