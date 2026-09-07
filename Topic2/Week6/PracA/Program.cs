using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<BankAccount> accounts = new Stack<BankAccount>();

        accounts.Push(new BankAccount("Alice", 100m));
        accounts.Push(new BankAccount("Bob", 250m));
        accounts.Push(new BankAccount("Charlie", 150m));
        accounts.Push(new BankAccount("David", 500m));
        accounts.Push(new BankAccount("Emma", 300m));
        accounts.Push(new BankAccount("Frank", 450m));
        accounts.Push(new BankAccount("Grace", 200m));
        accounts.Push(new BankAccount("Henry", 350m));
        accounts.Push(new BankAccount("Isabella", 50m));
        accounts.Push(new BankAccount("Jack", 400m));

        Console.WriteLine("-- Stack<BankAccount> --");

        foreach (BankAccount account in accounts)
        {
            Console.WriteLine($"{account.Owner}: ${account.Balance:F2}");
        }

        Queue<BankAccount> accountQueue = StackToQueue(accounts);

        Console.WriteLine("\n-- Queue<BankAccount> --");

        foreach (BankAccount account in accountQueue)
        {
            Console.WriteLine($"{account.Owner}: ${account.Balance:F2}");
        }
    }

    static Queue<BankAccount> StackToQueue(Stack<BankAccount> stack)
    {
        Queue<BankAccount> queue = new Queue<BankAccount>();

        foreach (BankAccount account in stack)
        {
            queue.Enqueue(account);
        }

        return queue;
    }
}