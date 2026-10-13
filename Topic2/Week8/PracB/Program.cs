using System.Text.Json;
using System.Collections.Generic;
using System;
using System.IO;


// Task 1: Basic File I/O

Console.WriteLine("-- Task 1: Basic File I/O --");

// Create an Attachments folder for our text file
Directory.CreateDirectory("Attachments");

// Set the file path
string path = Path.Combine("Attachments", "MyTest.txt");


// Write to the file every time the program runs
using (StreamWriter sw = File.CreateText(path))
{
    sw.WriteLine("Hello");
    sw.WriteLine("World");
    sw.WriteLine("Welcome to Week 8 Prac B!");
}

Console.WriteLine("File written successfully!");


// Read the file using StreamReader
Console.WriteLine("\n-- Reading with StreamReader --");

using (StreamReader sr = File.OpenText(path))
{
    string? line;

    while ((line = sr.ReadLine()) != null)
    {
        Console.WriteLine(line);
    }
}

// Read the entire file using File.ReadAllText
Console.WriteLine("\n-- Reading with File.ReadAllText --");

string content = File.ReadAllText(path);

Console.WriteLine(content);


// Task 2: Serialise and Deserialise a List

Console.WriteLine("\n-- Task 2: JSON Serialization --");

// Create a list of five players
List<Player> players = new List<Player>
{
    new Player("Lucas", 100, 20, 10),
    new Player("Emma", 90, 25, 8),
    new Player("Jack", 110, 15, 12),
    new Player("Alice", 95, 22, 9),
    new Player("Henry", 120, 18, 15)
};

// Convert the Player list into JSON text
JsonSerializerOptions options = new JsonSerializerOptions
{
    WriteIndented = true
};

string jsonString = JsonSerializer.Serialize(players, options);

// Print JSON to the console
Console.WriteLine("\n-- Serialized Players --");
Console.WriteLine(jsonString);

// Save JSON to a file
string playerPath = Path.Combine("Attachments", "Players.json");

File.WriteAllText(playerPath, jsonString);

Console.WriteLine("\nPlayers saved to JSON successfully!");

// Read JSON from the file
string savedJson = File.ReadAllText(playerPath);

// Convert JSON back into a Player list
List<Player> loadedPlayers =
    JsonSerializer.Deserialize<List<Player>>(savedJson)!;

// Print the loaded players
Console.WriteLine("\n-- Deserialized Players --");

foreach (Player player in loadedPlayers)
{
    Console.WriteLine(player);
}

