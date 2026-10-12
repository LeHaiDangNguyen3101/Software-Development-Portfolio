
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Text;

// Task 1: Using Hashtable

// Create a Hashtable
Hashtable scoreHash = new Hashtable();

// Step 2: Create five players
Player lucas = new Player("Lucas");
Player jack = new Player("Jack");
Player emma = new Player("Emma");
Player alice = new Player("Alice");
Player henry = new Player("Henry");

// Add players and their scores to the Hashtable
scoreHash.Add(lucas, 85);
scoreHash.Add(jack, 70);
scoreHash.Add(emma, 95);
scoreHash.Add(alice, 60);
scoreHash.Add(henry, 90);

Console.WriteLine("-- Original Hashtable --");

foreach (DictionaryEntry entry in scoreHash)
{
    if (entry.Key is Player player && entry.Value is int score)
    {
        Console.WriteLine($"{player.Name}: {score}");
    }
}


Console.WriteLine("\n-- Test Different Key Type --");

try
{
    scoreHash.Add("David", 75);
    Console.WriteLine("String key added successfully!");
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}


Console.WriteLine("\n-- Test Duplicate Key --");

try
{
    scoreHash.Add(lucas, 100);
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}


Console.WriteLine("\n-- Players Sorted by Score --");

// Create a list to store Player and Score pairs
List<KeyValuePair<Player, int>> playerScores =
    new List<KeyValuePair<Player, int>>();

foreach (DictionaryEntry entry in scoreHash)
{
    if (entry.Key is Player player && entry.Value is int score)
    {
        playerScores.Add(new KeyValuePair<Player, int>(player, score));
    }
}

// Sort scores from highest to lowest
playerScores.Sort((a, b) => b.Value.CompareTo(a.Value));

// Print sorted players
foreach (KeyValuePair<Player, int> entry in playerScores)
{
    Console.WriteLine($"{entry.Key.Name}: {entry.Value}");
}

 // Task 2
 Console.WriteLine("\n-- Task 2: Benchmarking --");

 int iterations = 100_000;

 // Method 1
 Console.WriteLine("\n-- Method 1: String Append --");

 string aOutput = "";

 Stopwatch appendWatch = new Stopwatch();
 appendWatch.Start();

 for (int i = 0; i < iterations; i++)
 {
     aOutput += "z";
 }

 appendWatch.Stop();

 Console.WriteLine($"Append time: {appendWatch.Elapsed.TotalMilliseconds:F2} ms");


 // Method 2: Build using StringBuilder
 Console.WriteLine("\n-- Method 2: StringBuilder --");

 StringBuilder bOutput = new StringBuilder();

 Stopwatch buildWatch = new Stopwatch();
 buildWatch.Start();

 for (int i = 0; i < iterations; i++)
 {
     bOutput.Append("z");
 }

 buildWatch.Stop();

 Console.WriteLine($"Build time: {buildWatch.Elapsed.TotalMilliseconds:F2} ms");

 // Compare the two methods
 Console.WriteLine("\n-- Performance Comparison --");

 Console.WriteLine($"Append length: {aOutput.Length}");
 Console.WriteLine($"Build length: {bOutput.Length}");

 if (appendWatch.Elapsed.TotalMilliseconds > buildWatch.Elapsed.TotalMilliseconds)
 {
     Console.WriteLine("StringBuilder was faster!");
 }
 else
 {
     Console.WriteLine("Normal string concatenation was faster!");
 }

