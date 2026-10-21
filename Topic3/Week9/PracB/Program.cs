using System;
using System.Collections.Generic;

// Task 1: Dijkstra's Algorithm

Console.WriteLine("-- Task 1: Weighted Horse Graph --");

// Create an empty graph
Graph graph = new Graph();

// Create 16 nodes
Node Start = new Node("Start");
Node A = new Node("A");
Node B = new Node("B (BEES)");
Node C = new Node("C");
Node D = new Node("D (BEES)");
Node E = new Node("E (BEES)");
Node F = new Node("F");
Node G = new Node("G");
Node H = new Node("H");
Node I = new Node("I (BEES)");
Node J = new Node("J (BEES)");
Node K = new Node("K");
Node L = new Node("L");
Node M = new Node("M");
Node N = new Node("N");
Node End = new Node("End");

// Connect nodes with weighted edges

// Start connections
graph.AddEdge(Start, A, 1);
graph.AddEdge(Start, B, 5);
graph.AddEdge(Start, D, 5);

// A, B and D connections
graph.AddEdge(A, C, 1);
graph.AddEdge(B, E, 5);

graph.AddEdge(D, C, 5);
graph.AddEdge(D, E, 5);
graph.AddEdge(D, G, 5);

// C and E connections
graph.AddEdge(E, H, 5);
graph.AddEdge(C, F, 1);

// G connections
graph.AddEdge(G, F, 1);
graph.AddEdge(G, H, 1);
graph.AddEdge(G, J, 1);

// F and H connections
graph.AddEdge(F, I, 5);
graph.AddEdge(H, K, 1);

// J connections
graph.AddEdge(J, I, 5);
graph.AddEdge(J, K, 5);
graph.AddEdge(J, M, 5);

// I and K connections
graph.AddEdge(I, L, 5);
graph.AddEdge(K, N, 1);

// M connections
graph.AddEdge(M, L, 1);
graph.AddEdge(M, N, 1);

// Final connection
graph.AddEdge(L, End, 1);

// Print graph information
Console.WriteLine("Total nodes: " + graph.Nodes.Count);

int totalEdges = 0;

foreach (Node node in graph.Nodes)
{
    totalEdges += node.Edges.Count;
}

// Divide by 2 because the graph is undirected
Console.WriteLine("Total edges: " + totalEdges / 2);

Console.WriteLine();
Console.WriteLine("-- Graph Connections --");
Console.WriteLine(graph.ToString());


// Dijkstra's algorithm

Console.WriteLine("-- Dijkstra's Algorithm --");

// Set the target node
Node target = End;

// Store the shortest known distance to each node
Dictionary<Node, int> distanceList = new Dictionary<Node, int>();

// Store the previous node for rebuilding the path
Dictionary<Node, Node?> parents = new Dictionary<Node, Node?>();

// Create a priority queue
PriorityQueue<Node, int> priorityQueue =
    new PriorityQueue<Node, int>();

// Set initial distances
foreach (Node node in graph.Nodes)
{
    distanceList[node] = int.MaxValue;
}

// The starting node has a distance of 0
distanceList[Start] = 0;
parents[Start] = null;

// Add the starting node to the priority queue
priorityQueue.Enqueue(Start, 0);

bool foundDijkstra = false;

// Search until the queue is empty
while (priorityQueue.Count > 0)
{
    // Remove the node with the lowest priority
    priorityQueue.TryDequeue(
        out Node? current,
        out int currentDistance);

    if (current == null)
    {
        continue;
    }

    // Ignore outdated queue entries
    if (currentDistance > distanceList[current])
    {
        continue;
    }

    // Check whether we reached the target
    if (current == target)
    {
        foundDijkstra = true;
        break;
    }

    // Check all neighbours of the current node
    foreach (KeyValuePair<Node, int> neighbour in current.Edges)
    {
        Node nextNode = neighbour.Key;
        int weight = neighbour.Value;

        // Calculate the total distance
        int newDistance = distanceList[current] + weight;

        // Only update if we found a shorter route
        if (newDistance < distanceList[nextNode])
        {
            distanceList[nextNode] = newDistance;

            // Remember how we reached this node
            parents[nextNode] = current;

            // Add the neighbour with its new priority
            priorityQueue.Enqueue(nextNode, newDistance);
        }
    }
}


// Print the shortest path

Console.WriteLine();
Console.WriteLine("-- Shortest Path --");

if (foundDijkstra)
{
    // Store the path
    List<string> path = new List<string>();

    // Start from the target node
    Node? node = target;

    // Follow the parents back to Start
    while (node != null)
    {
        path.Add(node.Data);
        node = parents[node];
    }

    // Reverse the path so it starts at Start
    path.Reverse();

    // Print the shortest path
    Console.WriteLine(string.Join(" -> ", path));

    // Print the total weight
    Console.WriteLine("Total weight: " + distanceList[target]);
}
else
{
    Console.WriteLine("No path found.");
}

