using System.Collections.Generic;
using System;

// Task 1: Building a Graph

Console.WriteLine("-- Task 1: Building a Graph --");

// Create an empty graph
Graph graph = new Graph();

// Create 9 nodes from A to I
Node A = new Node("A");
Node B = new Node("B");
Node C = new Node("C");
Node D = new Node("D");
Node E = new Node("E");
Node F = new Node("F");
Node G = new Node("G");
Node H = new Node("H");
Node I = new Node("I");

// Connect nodes using edges
graph.AddEdge(A, B);
graph.AddEdge(A, C);
graph.AddEdge(B, D);
graph.AddEdge(B, E);
graph.AddEdge(C, F);
graph.AddEdge(D, G);
graph.AddEdge(E, H);
graph.AddEdge(F, I);
// Task 3 adjusted graph
graph.AddEdge(G, H);
graph.AddEdge(D, E);

// Print the graph
Console.WriteLine(graph.ToString());



// Task 2: Traversing with BFS

Console.WriteLine("-- Task 2: BFS --");

// Store checked nodes
HashSet<Node> checkedBFS = new HashSet<Node>();

// Keep the visiting order
List<Node> visitedBFS = new List<Node>();

// Create a queue
Queue<Node> queued = new Queue<Node>();

// Set the target node
Node target = I;

// Start at node A
queued.Enqueue(A);

bool foundBFS = false;

while (queued.Count > 0)
{
    // Remove the first node from the queue
    Node current = queued.Dequeue();

    // Skip nodes already checked
    if (checkedBFS.Contains(current))
    {
        continue;
    }

    // Check whether the target is found
    if (current == target)
    {
        foundBFS = true;
        visitedBFS.Add(current);
        break;
    }

    // Mark this node as checked
    checkedBFS.Add(current);
    visitedBFS.Add(current);
    
    // Add unvisited neighbours to the queue
    foreach (Node edge in current.Edges)
    {
        if (!checkedBFS.Contains(edge) && !queued.Contains(edge))
        {
            queued.Enqueue(edge);
        }
    }
}

// Print BFS result
Console.WriteLine("BFS visited: " +
    string.Join(" -> ", visitedBFS.ConvertAll(n => n.Data)));

Console.WriteLine("Target found: " + foundBFS);


// Task 3: Traversing with DFS

Console.WriteLine("-- Task 3: DFS --");

// Store checked nodes
HashSet<Node> checkedDFS = new HashSet<Node>();

// Keep the visiting order
List<Node> visitedDFS = new List<Node>();

// Create a stack
Stack<Node> stacked = new Stack<Node>();

// Start at node A
stacked.Push(A);

bool foundDFS = false;

while (stacked.Count > 0)
{
    // Remove the top node from the stack
    Node current = stacked.Pop();

    // Skip nodes already checked
    if (checkedDFS.Contains(current))
    {
        continue;
    }

    // Check whether the target is found
    if (current == target)
    {
        foundDFS = true;
        visitedDFS.Add(current);
        break;
    }

    // Mark this node as checked
    checkedDFS.Add(current);
    visitedDFS.Add(current);

    // Add unvisited neighbours to the stack
    foreach (Node edge in current.Edges)
    {
        if (!checkedDFS.Contains(edge) && !stacked.Contains(edge))
        {
            stacked.Push(edge);
        }
    }
}

// Print DFS result
Console.WriteLine("DFS visited: " +
    string.Join(" -> ", visitedDFS.ConvertAll(n => n.Data)));

Console.WriteLine("Target found: " + foundDFS);


