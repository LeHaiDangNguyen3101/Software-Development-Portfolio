using System.Text.Json;
using System.Collections.Generic;
using System;
using System.IO;
using System.Diagnostics;


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

// Save JSON using our generic FileWriter method
string playerPath = Path.Combine("Attachments", "Players.json");

JsonFileHelper.FileWriter(playerPath, players);

Console.WriteLine("\nPlayers saved to JSON successfully!");

// Load JSON using our generic FileReader method
List<Player> loadedPlayers =
    JsonFileHelper.FileReader<List<Player>>(playerPath);

// Print the loaded players
Console.WriteLine("\n-- Deserialized Players --");

foreach (Player player in loadedPlayers)
{
    Console.WriteLine(player);
}


// Task 4: Displaying Memory Usage for LinkedList

Console.WriteLine("\n-- Task 4: LinkedList Memory Usage --");

// Create a LinkedList of Players
LinkedList<Player> linkedPlayers = new LinkedList<Player>();

// Add the five players to the LinkedList
foreach (Player player in players)
{
    linkedPlayers.AddLast(player);
}

Console.WriteLine($"Players in LinkedList: {linkedPlayers.Count}");

// Save LinkedList to JSON using generic FileWriter
string linkedPath = Path.Combine("Attachments", "LinkedPlayers.json");

JsonFileHelper.FileWriter(linkedPath, linkedPlayers);

Console.WriteLine("LinkedList saved successfully!");

// Load LinkedList from JSON using generic FileReader
LinkedList<Player> loadedLinkedPlayers =
    JsonFileHelper.FileReader<LinkedList<Player>>(linkedPath);

Console.WriteLine("\n-- Loaded LinkedList Players --");

foreach (Player player in loadedLinkedPlayers)
{
    Console.WriteLine(player.Name);
}

// Request garbage collection before measuring
GC.Collect();

// Get managed heap memory information
long heapSizeBytes = GC.GetGCMemoryInfo().HeapSizeBytes;

// Get peak process working-set memory
long peakWorkingSet64 =
    Process.GetCurrentProcess().PeakWorkingSet64;

Console.WriteLine("\n-- Memory Usage --");

Console.WriteLine($"HeapSizeBytes: {heapSizeBytes:N0} bytes");
Console.WriteLine($"PeakWorkingSet64: {peakWorkingSet64:N0} bytes");



// Task 5: Benchmarking List vs LinkedList

Console.WriteLine("\n-- Task 5: List vs LinkedList Memory --");

// Change this to "LinkedList" for the second test
string benchmarkType = "LinkedList";

if (benchmarkType == "List")
{
    // Create a List of 10,000 players
    List<Player> listPlayers = new List<Player>();

    for (int i = 0; i < 10_000; i++)
    {
        listPlayers.Add(new Player($"Player{i}"));
    }

    Console.WriteLine($"List count: {listPlayers.Count}");

    // Save List to JSON
    string listPath = Path.Combine("Attachments", "ListPlayers.json");
    JsonFileHelper.FileWriter(listPath, listPlayers);

    // Load List from JSON
    List<Player> loadedList =
        JsonFileHelper.FileReader<List<Player>>(listPath);

    Console.WriteLine($"Loaded List count: {loadedList.Count}");

    // Measure memory
    GC.Collect();

    long listHeap = GC.GetGCMemoryInfo().HeapSizeBytes;
    long listPeak = Process.GetCurrentProcess().PeakWorkingSet64;

    Console.WriteLine("\n-- List Memory Results --");
    Console.WriteLine($"HeapSizeBytes: {listHeap:N0} bytes");
    Console.WriteLine($"PeakWorkingSet64: {listPeak:N0} bytes");

    GC.KeepAlive(loadedList);
    GC.KeepAlive(listPlayers);
}
else if (benchmarkType == "LinkedList")
{
    // Create a LinkedList of 10,000 players
    LinkedList<Player> linkedBenchPlayers = new LinkedList<Player>();

    for (int i = 0; i < 10_000; i++)
    {
        linkedBenchPlayers.AddLast(new Player($"Player{i}"));
    }

    Console.WriteLine($"LinkedList count: {linkedBenchPlayers.Count}");

    // Save LinkedList to JSON
    string linkedBenchPath =
        Path.Combine("Attachments", "LinkedListPlayers.json");

    JsonFileHelper.FileWriter(linkedBenchPath, linkedBenchPlayers);

    // Load LinkedList from JSON
    LinkedList<Player> loadedLinkedList =
        JsonFileHelper.FileReader<LinkedList<Player>>(linkedBenchPath);

    Console.WriteLine($"Loaded LinkedList count: {loadedLinkedList.Count}");

    // Measure memory
    GC.Collect();

    long linkedHeap = GC.GetGCMemoryInfo().HeapSizeBytes;
    long linkedPeak = Process.GetCurrentProcess().PeakWorkingSet64;

    Console.WriteLine("\n-- LinkedList Memory Results --");
    Console.WriteLine($"HeapSizeBytes: {linkedHeap:N0} bytes");
    Console.WriteLine($"PeakWorkingSet64: {linkedPeak:N0} bytes");

    GC.KeepAlive(loadedLinkedList);
    GC.KeepAlive(linkedBenchPlayers);
}


// Task 3: Refactor File I/O Methods

public static class JsonFileHelper
{
    // Generic method to save an object as JSON
    public static void FileWriter<T>(string path, T objectToWrite)
        where T : class
    {
        string json = JsonSerializer.Serialize(
            objectToWrite,
            new JsonSerializerOptions { WriteIndented = true });

        File.WriteAllText(path, json);
    }

    // Generic method to read JSON into an object
    public static T FileReader<T>(string path)
        where T : class
    {
        string json = File.ReadAllText(path);

        T? result = JsonSerializer.Deserialize<T>(json);

        return result ?? throw new InvalidDataException(
            "Could not deserialize the JSON file.");
    }
}
