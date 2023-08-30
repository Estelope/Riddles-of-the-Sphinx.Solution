
using System;
using System.Collections.Generic;

public class Sphinx
{
    private List<Riddle> riddles;
    private Random random;

    public Sphinx()
    {
        riddles = new List<Riddle>
        {
            new Riddle("I speak without a mouth and hear without ears. I have no body, but I come alive with the wind. What am I?", "an echo"),
            new Riddle("What has keys but can't open locks?", "a piano"),
            new Riddle("I'm not alive, but I can grow; I don't have lungs, but I need air; I don't have a mouth, but water kills me. What am I?", "a fire")
        };

        random = new Random();
    }

    public Riddle GetRandomRiddle()
    {
        int index = random.Next(riddles.Count);
        return riddles[index];
    }

    public bool IsAnswerCorrect(Riddle riddle, string userAnswer)
    {
        return string.Equals(riddle.Answer, userAnswer, StringComparison.OrdinalIgnoreCase);
    }
}

public class Riddle
{
    public string Question { get; }
    public string Answer { get; }

    public Riddle(string question, string answer)
    {
        Question = question;
        Answer = answer;
    }
}
