
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

// Print the graph
Console.WriteLine(graph.ToString());
