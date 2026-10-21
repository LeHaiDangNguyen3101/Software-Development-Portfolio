using System.Collections.Generic;

public class Node
{
    // Store the name of the node
    public string Data { get; set; }

    // Store connected nodes and their weights
    public Dictionary<Node, int> Edges { get; set; }

    // Constructor
    public Node(string data)
    {
        Data = data;
        Edges = new Dictionary<Node, int>();
    }
}
