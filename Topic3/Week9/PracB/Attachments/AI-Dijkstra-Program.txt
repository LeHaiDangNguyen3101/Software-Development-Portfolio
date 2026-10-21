using System;
using System.Collections.Generic;

// Week 9 Prac B - Task 2
// AI-generated Dijkstra implementation using string node names

Console.WriteLine("-- AI Dijkstra's Algorithm --");

// Store the graph using an adjacency list
Dictionary<string, List<(string Neighbour, int Weight)>> graph = new();

// Add an undirected weighted edge
void AddEdge(string from, string to, int weight)
{
    if (!graph.ContainsKey(from))
        graph[from] = new();

    if (!graph.ContainsKey(to))
        graph[to] = new();

    graph[from].Add((to, weight));
    graph[to].Add((from, weight));
}

// Create the same horse graph from Task 1
AddEdge("Start", "A", 1);
AddEdge("Start", "B", 5);
AddEdge("Start", "D", 5);

AddEdge("A", "C", 1);
AddEdge("B", "E", 5);

AddEdge("D", "C", 5);
AddEdge("D", "E", 5);
AddEdge("D", "G", 5);

AddEdge("E", "H", 5);
AddEdge("C", "F", 1);

AddEdge("G", "F", 1);
AddEdge("G", "H", 1);
AddEdge("G", "J", 1);

AddEdge("F", "I", 5);
AddEdge("H", "K", 1);

AddEdge("J", "I", 5);
AddEdge("J", "K", 5);
AddEdge("J", "M", 5);

AddEdge("I", "L", 5);
AddEdge("K", "N", 1);

AddEdge("M", "L", 1);
AddEdge("M", "N", 1);

AddEdge("L", "End", 1);

// Find the shortest weighted path
(List<string> Path, int Cost) Dijkstra(
    string start, string end)
{
    Dictionary<string, int> distances = new();
    Dictionary<string, string?> previous = new();

    PriorityQueue<string, int> queue = new();

    // Initialize each node with infinite distance
    foreach (string node in graph.Keys)
    {
        distances[node] = int.MaxValue;
        previous[node] = null;
    }

    distances[start] = 0;
    queue.Enqueue(start, 0);

    while (queue.Count > 0)
    {
        queue.TryDequeue(
            out string? current,
            out int priority);

        if (current == null)
            continue;

        // Skip outdated entries
        if (priority > distances[current])
            continue;

        // Stop when the destination is reached
        if (current == end)
            break;

        foreach (var (neighbour, weight) in graph[current])
        {
            int newCost = distances[current] + weight;

            if (newCost < distances[neighbour])
            {
                distances[neighbour] = newCost;
                previous[neighbour] = current;

                queue.Enqueue(neighbour, newCost);
            }
        }
    }

    // Return if no path was found
    if (distances[end] == int.MaxValue)
        return (new List<string>(), -1);

    // Reconstruct the shortest path
    List<string> path = new();
    string? step = end;

    while (step != null)
    {
        path.Add(step);
        step = previous[step];
    }

    path.Reverse();

    return (path, distances[end]);
}

// Run Dijkstra
var result = Dijkstra("Start", "End");

// Display the result
Console.WriteLine("Total nodes: " + graph.Count);

Console.WriteLine("Total edges: " +
    graph.Values.Sum(edges => edges.Count) / 2);

if (result.Path.Count > 0)
{
    Console.WriteLine("Shortest path: " +
        string.Join(" -> ", result.Path));

    Console.WriteLine("Total weight: " + result.Cost);
}
else
{
    Console.WriteLine("No path found.");
}

