
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

