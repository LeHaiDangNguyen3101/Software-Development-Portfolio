using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Task 3: Stack<BankAccount>
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

        // Convert Stack to Queue
        Queue<BankAccount> accountQueue = StackToQueue(accounts);

        Console.WriteLine("\n-- Queue<BankAccount> --");

        foreach (BankAccount account in accountQueue)
        {
            Console.WriteLine($"{account.Owner}: ${account.Balance:F2}");
        }

        // Task 4: Sort Queue by Balance
        Console.WriteLine("\n-- Queue Before Sorting --");

        foreach (BankAccount account in accountQueue)
        {
            Console.WriteLine($"{account.Owner}: ${account.Balance:F2}");
        }

        Queue<BankAccount> sortedQueue = SortQueue(accountQueue);

        Console.WriteLine("\n-- Queue After Sorting (Lowest Balance First) --");

        foreach (BankAccount account in sortedQueue)
        {
            Console.WriteLine($"{account.Owner}: ${account.Balance:F2}");
        }
    }


    // Task 3 Method
    static Queue<BankAccount> StackToQueue(Stack<BankAccount> stack)
    {
        Queue<BankAccount> queue = new Queue<BankAccount>();

        foreach (BankAccount account in stack)
        {
            queue.Enqueue(account);
        }

        return queue;
    }

    // Task 4 Method
    static Queue<BankAccount> SortQueue(Queue<BankAccount> queue)
    {
        List<BankAccount> accounts = new List<BankAccount>();

        // Copy all queue items into a List
        foreach (BankAccount account in queue)
        {
            accounts.Add(account);
        }

        // Bubble sort - lowest balance first
        for (int i = 0; i < accounts.Count - 1; i++)
        {
            for (int j = 0; j < accounts.Count - i - 1; j++)
            {
                if (accounts[j].Balance > accounts[j + 1].Balance)
                {
                    BankAccount temp = accounts[j];
                    accounts[j] = accounts[j + 1];
                    accounts[j + 1] = temp;
                }
            }
        }

        // Put the sorted accounts back into a Queue
        Queue<BankAccount> sortedQueue = new Queue<BankAccount>();

        foreach (BankAccount account in accounts)
        {
            sortedQueue.Enqueue(account);
        }

        return sortedQueue;
    }
}