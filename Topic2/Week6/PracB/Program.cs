using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
// Task 1: LINQ OrderBy with List<string>

        // Create a list of 10 names
        List<string> names = new List<string>
        {
            "Jack",
            "Alice",
            "Henry",
            "Emma",
            "Bob",
            "Grace",
            "David",
            "Charlie",
            "Isabella",
            "Frank"
        };

        Console.WriteLine("-- Task 1: Original List --");

        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        // Sort the names alphabetically using LINQ
        var orderedNames = names.OrderBy(x => x);

        // Convert the LINQ result back to a List
        List<string> sortedNames = orderedNames.ToList();

        Console.WriteLine("\n-- Task 1: Names in Alphabetical Order --");

        foreach (string name in sortedNames)
        {
            Console.WriteLine(name);
        }


// Task 2: LINQ Select with Stack and Queue

        // Create a Stack of BankAccounts
        Stack<BankAccount> accountStack = new Stack<BankAccount>();

        accountStack.Push(new BankAccount("Alice", 100m));
        accountStack.Push(new BankAccount("Bob", 250m));
        accountStack.Push(new BankAccount("Charlie", 150m));
        accountStack.Push(new BankAccount("David", 500m));
        accountStack.Push(new BankAccount("Emma", 300m));
        accountStack.Push(new BankAccount("Frank", 450m));
        accountStack.Push(new BankAccount("Grace", 200m));
        accountStack.Push(new BankAccount("Henry", 350m));
        accountStack.Push(new BankAccount("Isabella", 50m));
        accountStack.Push(new BankAccount("Jack", 400m));

        // Create a Queue of BankAccounts
        Queue<BankAccount> accountQueue = new Queue<BankAccount>();

        accountQueue.Enqueue(new BankAccount("Alice", 100m));
        accountQueue.Enqueue(new BankAccount("Bob", 250m));
        accountQueue.Enqueue(new BankAccount("Charlie", 150m));
        accountQueue.Enqueue(new BankAccount("David", 500m));
        accountQueue.Enqueue(new BankAccount("Emma", 300m));
        accountQueue.Enqueue(new BankAccount("Frank", 450m));
        accountQueue.Enqueue(new BankAccount("Grace", 200m));
        accountQueue.Enqueue(new BankAccount("Henry", 350m));
        accountQueue.Enqueue(new BankAccount("Isabella", 50m));
        accountQueue.Enqueue(new BankAccount("Jack", 400m));

        // Select only Owner and sort names alphabetically
        var stackOwners = accountStack
            .Select(x => x.Owner)
            .OrderBy(x => x);

        Console.WriteLine("\n-- Task 2: Stack Owners Ordered by Name --");

        foreach (string owner in stackOwners)
        {
            Console.WriteLine(owner);
        }

        // Do the same LINQ query for the Queue
        var queueOwners = accountQueue
            .Select(x => x.Owner)
            .OrderBy(x => x);

        Console.WriteLine("\n-- Task 2: Queue Owners Ordered by Name --");

        foreach (string owner in queueOwners)
        {
            Console.WriteLine(owner);
        }


// Task 3: LINQ Where, Select and OrderBy

        // Filter Stack owners that contain "e"
        var stackResults = accountStack
            .Where(x => x.Owner.Contains("e"))  // Filter
            .Select(x => new                    // Select Owner and Balance
            {
                x.Owner,
                x.Balance
            })
            .OrderBy(x => x.Balance);           // Sort by balance

        Console.WriteLine("\n-- Task 3: Stack Results --");

        foreach (var account in stackResults)
        {
            Console.WriteLine($"{account.Owner}: ${account.Balance:F2}");
        }

        // Do the same LINQ query for the Queue
        var queueResults = accountQueue
            .Where(x => x.Owner.Contains("e"))  // Filter
            .Select(x => new                    // Select Owner and Balance
            {
                x.Owner,
                x.Balance
            })
            .OrderBy(x => x.Balance);           // Sort by balance

        Console.WriteLine("\n-- Task 3: Queue Results --");

        foreach (var account in queueResults)
        {
            Console.WriteLine($"{account.Owner}: ${account.Balance:F2}");
        }
    }
}