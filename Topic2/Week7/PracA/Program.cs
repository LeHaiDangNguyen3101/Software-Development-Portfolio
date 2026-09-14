using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Task 1: SortedSet<int>
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


        // Task 2: SortedSet<BankAccount>
        Console.WriteLine("\n--- Task 2: SortedSet with BankAccount ---");

        var sortedBankSet =
            new SortedSet<BankAccount>(new BankComparer());

        // Add 10 BankAccount objects
        sortedBankSet.Add(new BankAccount("Alice", 1500));
        sortedBankSet.Add(new BankAccount("Bob", 800));
        sortedBankSet.Add(new BankAccount("Charlie", 2200));
        sortedBankSet.Add(new BankAccount("David", 1200));
        sortedBankSet.Add(new BankAccount("Emma", 3000));
        sortedBankSet.Add(new BankAccount("Frank", 950));
        sortedBankSet.Add(new BankAccount("Grace", 1750));
        sortedBankSet.Add(new BankAccount("Henry", 600));
        sortedBankSet.Add(new BankAccount("Isabella", 2500));
        sortedBankSet.Add(new BankAccount("Jack", 1100));

        Console.WriteLine("\n--- Original Bank Accounts ---");
        DisplayAccounts(sortedBankSet);

        // Add a new high balance
        sortedBankSet.Add(new BankAccount("Kevin", 5000));

        Console.WriteLine("\n--- After Adding High Balance ---");
        DisplayAccounts(sortedBankSet);

        // Add a duplicate BankAccount
        sortedBankSet.Add(new BankAccount("Alice", 1500));

        Console.WriteLine("\n--- After Adding Duplicate Alice ---");
        DisplayAccounts(sortedBankSet);

        // Task 3: Plotting data with ScottPlot
        Console.WriteLine("\n--- Task 3: Plotting Bank Account Balances ---");

        // Get the balances from the SortedSet<BankAccount>
        double[] balances = sortedBankSet
            .Select(account => account.Balance)
            .ToArray();

        // Create a new ScottPlot
        ScottPlot.Plot myPlot = new();

        // Add the balances as a bar chart
        myPlot.Add.Bars(balances);

        // Add axis labels
        myPlot.XLabel("Ranking");
        myPlot.YLabel("Account Balance");

        // Change label font sizes
        myPlot.Axes.Bottom.Label.FontSize = 20;
        myPlot.Axes.Left.Label.FontSize = 20;

        // Set the graph margins
        myPlot.Axes.Margins(bottom: 0, top: 0.2);

        // Save the graph as an 800 x 600 PNG file
        myPlot.SavePng("Topic7A-Task3.png", 800, 600);

        Console.WriteLine("Graph saved as Topic7A-Task3.png");
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

    static void DisplayAccounts(SortedSet<BankAccount> accounts)
    {
        foreach (BankAccount account in accounts)
        {
            Console.WriteLine(
                $"Owner: {account.Owner}, Balance: ${account.Balance:F2}");
        }
    }
}