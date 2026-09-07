using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<string> undoHistory = new Stack<string>();

        Console.WriteLine("-- Text Editor Undo History --");

        // Add actions to the stack
        undoHistory.Push("Typed Text");
        undoHistory.Push("Inserted Image");
        undoHistory.Push("Changed Colour");

        Console.WriteLine("\nInitial stack:");
        PrintStack(undoHistory);

        // Peek at the top item
        Console.WriteLine($"\nTop action using Peek(): {undoHistory.Peek()}");

        Console.WriteLine("\nStack after Peek():");
        PrintStack(undoHistory);

        // Remove the top item
        string removedAction = undoHistory.Pop();

        Console.WriteLine($"\nRemoved action using Pop(): {removedAction}");

        Console.WriteLine("\nStack after Pop():");
        PrintStack(undoHistory);
    }

    static void PrintStack(Stack<string> stack)
    {
        foreach (string action in stack)
        {
            Console.WriteLine(action);
        }
    }
}
