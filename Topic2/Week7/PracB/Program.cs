using System;
using System.Collections.Generic;
using System.Linq;

// =========================
// Task 4: Priority Enum
// =========================

public enum Priority
{
    HighPriority,
    MediumPriority,
    LowPriority
}

class Program
{
    static void Main()
    {
        // Task 1: SortedDictionary for Player Rankings

        var sortedScores = new SortedDictionary<int, string>();

        // Add 10 players with different scores
        sortedScores.Add(850, "Alice");
        sortedScores.Add(1200, "Bob");
        sortedScores.Add(650, "Charlie");
        sortedScores.Add(1500, "David");
        sortedScores.Add(950, "Emma");
        sortedScores.Add(1800, "Frank");
        sortedScores.Add(1100, "Grace");
        sortedScores.Add(700, "Henry");
        sortedScores.Add(1350, "Isabella");
        sortedScores.Add(1000, "Jack");

        // Print the top three scores
        Console.WriteLine("--- Task 1: Top Three Scores ---");

        foreach (var player in sortedScores.Reverse().Take(3))
        {
            Console.WriteLine(
                $"Player: {player.Value}, Score: {player.Key}");
        }

        // Print the bottom three scores
        Console.WriteLine("\n--- Task 1: Bottom Three Scores ---");

        foreach (var player in sortedScores.Take(3))
        {
            Console.WriteLine(
                $"Player: {player.Value}, Score: {player.Key}");
        }

        // Remove a player who has left the game
        Console.WriteLine("\n--- Player Leaving: Emma ---");

        int emmaScore = sortedScores
            .First(x => x.Value == "Emma")
            .Key;

        sortedScores.Remove(emmaScore);

        // Print remaining players
        Console.WriteLine("\n--- Remaining Players ---");

        foreach (var player in sortedScores)
        {
            Console.WriteLine(
                $"Player: {player.Value}, Score: {player.Key}");
        }

        // Step 5: Try to add a duplicate score with a different player
        Console.WriteLine("\n--- Attempting Duplicate Score ---");

        // sortedScores.Add(1200, "Kevin");

        // Step 6: Add the same player name with a different score
        Console.WriteLine("\n--- Same Player Name with Different Score ---");

        sortedScores.Add(2000, "Bob");

        Console.WriteLine("Successfully added Bob again with score 2000.");

        foreach (var player in sortedScores)
        {
            Console.WriteLine(
                $"Player: {player.Value}, Score: {player.Key}");
        }

        // =========================
        // Task 2: SortedDictionary with ScoreEntry and Player
        // =========================

        Console.WriteLine("\n--- Task 2: Player Rankings with ScoreEntry ---");

        // Create SortedDictionary using our custom ScoreComparer
        var sortedScores2 =
            new SortedDictionary<ScoreEntry, Player>(new ScoreComparer());

        // Create 10 ScoreEntry and Player objects
        sortedScores2.Add(new ScoreEntry(1500, 5), new Player("Alice"));
        sortedScores2.Add(new ScoreEntry(900, 3), new Player("Bob"));
        sortedScores2.Add(new ScoreEntry(1800, 6), new Player("Charlie"));
        sortedScores2.Add(new ScoreEntry(700, 2), new Player("David"));
        sortedScores2.Add(new ScoreEntry(1200, 4), new Player("Emma"));
        sortedScores2.Add(new ScoreEntry(2000, 7), new Player("Frank"));
        sortedScores2.Add(new ScoreEntry(1100, 3), new Player("Grace"));
        sortedScores2.Add(new ScoreEntry(800, 2), new Player("Henry"));
        sortedScores2.Add(new ScoreEntry(1700, 5), new Player("Isabella"));
        sortedScores2.Add(new ScoreEntry(1300, 4), new Player("Jack"));

        // Print top three scores
        Console.WriteLine("\n--- Top Three Scores ---");

        foreach (var entry in sortedScores2.Reverse().Take(3))
        {
            Console.WriteLine(
                $"Player: {entry.Value.Name}, " +
                $"Score: {entry.Key.Score}, " +
                $"Stage: {entry.Key.StageReached}");
        }

        // Print bottom three scores
        Console.WriteLine("\n--- Bottom Three Scores ---");

        foreach (var entry in sortedScores2.Take(3))
        {
            Console.WriteLine(
                $"Player: {entry.Value.Name}, " +
                $"Score: {entry.Key.Score}, " +
                $"Stage: {entry.Key.StageReached}");
        }

        // Find and remove Emma
        Console.WriteLine("\n--- Player Leaving: Emma ---");

        var emmaEntry = sortedScores2
            .First(x => x.Value.Name == "Emma");

        sortedScores2.Remove(emmaEntry.Key);

        // Print remaining players
        Console.WriteLine("\n--- Remaining Players ---");

        foreach (var entry in sortedScores2)
        {
            Console.WriteLine(
                $"Player: {entry.Value.Name}, " +
                $"Score: {entry.Key.Score}, " +
                $"Stage: {entry.Key.StageReached}");
        }

        // Same score as Alice, but different StageReached
        Console.WriteLine("\n--- Same Score, Different Stage ---");

        sortedScores2.Add(
            new ScoreEntry(1500, 8),
            new Player("Kevin"));

        Console.WriteLine(
            "Kevin added with score 1500 and stage 8.");

        // Different key, but same Player object value
        Console.WriteLine("\n--- Same Player Object, Different Score ---");

        Player sharedPlayer = new Player("Lucas");

        sortedScores2.Add(
            new ScoreEntry(2100, 7),
            sharedPlayer);

        sortedScores2.Add(
            new ScoreEntry(2200, 8),
            sharedPlayer);

        Console.WriteLine(
            "Lucas added to two different ScoreEntry keys.");
        // =========================
        // Task 3: PriorityQueue for Priority Player Scheduling
        // =========================

        Console.WriteLine("\n--- Task 3: Priority Player Scheduling ---");

        // Create a PriorityQueue where:
        // Player = item being stored
        // int = priority
        var eventQueue = new PriorityQueue<Player, int>();

        // Add players with different priorities
        // Lower number means higher priority
        eventQueue.Enqueue(new Player("Alice"), 3);
        eventQueue.Enqueue(new Player("Bob"), 1);
        eventQueue.Enqueue(new Player("Charlie"), 4);
        eventQueue.Enqueue(new Player("David"), 2);
        eventQueue.Enqueue(new Player("Emma"), 5);

        Console.WriteLine("\n--- Processing Players by Priority ---");

        // Process players in priority order
        while (eventQueue.Count != 0)
        {
            Player player = eventQueue.Dequeue();
            Console.WriteLine(player.Name);
        }

        // Add players again to test the same priority
        Console.WriteLine("\n--- Testing Same Priority ---");

        eventQueue.Enqueue(new Player("Frank"), 1);
        eventQueue.Enqueue(new Player("Grace"), 2);
        eventQueue.Enqueue(new Player("Henry"), 2);
        eventQueue.Enqueue(new Player("Isabella"), 3);

        while (eventQueue.Count != 0)
        {
            Player player = eventQueue.Dequeue();
            Console.WriteLine(player.Name);
        }

        // =========================
        // Task 4: PriorityQueue with Enum Priority
        // =========================

        Console.WriteLine("\n--- Task 4: PriorityQueue with Enum Priority ---");

        // Create a PriorityQueue using the Priority enum
        var eventQueue2 = new PriorityQueue<Player, Priority>();

        // Add players with different priorities
        eventQueue2.Enqueue(new Player("Alice"), Priority.MediumPriority);
        eventQueue2.Enqueue(new Player("Bob"), Priority.HighPriority);
        eventQueue2.Enqueue(new Player("Charlie"), Priority.LowPriority);
        eventQueue2.Enqueue(new Player("David"), Priority.HighPriority);
        eventQueue2.Enqueue(new Player("Emma"), Priority.MediumPriority);

        Console.WriteLine("\n--- Processing Players with Enum Priority ---");

        // Process players in priority order
        while (eventQueue2.Count != 0)
        {
            Player player = eventQueue2.Dequeue();
            Console.WriteLine(player.Name);
        }

        // Test players with the same priority
        Console.WriteLine("\n--- Testing Same Enum Priority ---");

        eventQueue2.Enqueue(new Player("Frank"), Priority.HighPriority);
        eventQueue2.Enqueue(new Player("Grace"), Priority.MediumPriority);
        eventQueue2.Enqueue(new Player("Henry"), Priority.MediumPriority);
        eventQueue2.Enqueue(new Player("Isabella"), Priority.LowPriority);

        while (eventQueue2.Count != 0)
        {
            Player player = eventQueue2.Dequeue();
            Console.WriteLine(player.Name);
        }

    }
}
