using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Task 1: Using SortedSet with Integers

        SortedSet<int> scores = new SortedSet<int>
        {
            75,
            42,
            88,
            63,
            95,
            51,
            70,
            36,
            82,
            67
        };

        Console.WriteLine("--- Original Scores ---");
        DisplayScores(scores);

        // Add a new high score
        Console.WriteLine("\n--- After Adding High Score 100 ---");
        scores.Add(100);
        DisplayScores(scores);

        // Add a duplicate score
        Console.WriteLine("\n--- After Adding Duplicate Score 75 ---");
        scores.Add(75);
        DisplayScores(scores);
    }

    static void DisplayScores(SortedSet<int> scores)
    {
        Console.WriteLine("Scores:");

        foreach (int score in scores)
        {
            Console.WriteLine(score);
        }

        Console.WriteLine($"Lowest Score: {scores.Min}");
        Console.WriteLine($"Highest Score: {scores.Max}");
    }
}