using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
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

        var stackResults = accountStack
            .Where(x => x.Owner.Contains("e"))
            .Select(x => new
            {
                x.Owner,
                x.Balance
            })
            .OrderBy(x => x.Balance);

        Console.WriteLine("-- Stack Results --");

        foreach (var account in stackResults)
        {
            Console.WriteLine($"{account.Owner}: ${account.Balance:F2}");
        }

        var queueResults = accountQueue
            .Where(x => x.Owner.Contains("e"))
            .Select(x => new
            {
                x.Owner,
                x.Balance
            })
            .OrderBy(x => x.Balance);

        Console.WriteLine("\n-- Queue Results --");

        foreach (var account in queueResults)
        {
            Console.WriteLine($"{account.Owner}: ${account.Balance:F2}");
        }
    }
}