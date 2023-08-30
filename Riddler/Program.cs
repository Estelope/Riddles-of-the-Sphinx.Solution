using System;

namespace ShapeTracker
{
  class Program
{
    static void Main(string[] args)
    {
        Sphinx sphinx = new Sphinx();
        bool defeated = false;

         Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
         Console.WriteLine("Welcome to your Doom....");
         Console.WriteLine("I am the Riddle Sphinx...");
          Console.WriteLine("You must answer the S riddles correctly to defeat me.");

        while (!defeated)
        {
            Riddle riddle = sphinx.GetRandomRiddle();
            Console.WriteLine("\nSphinx asks: " + riddle.Question);
            Console.Write("Your answer: ");
            string userAnswer = Console.ReadLine();

            if (sphinx.IsAnswerCorrect(riddle, userAnswer))
            {
                Console.WriteLine("Correct! The Sphinx asks another riddle.");
            }
            else
            {
                Console.WriteLine("Incorrect! The Sphinx eats you.");
                defeated = true;
            }
        }

        Console.WriteLine("Game Over!");
    }
}
}