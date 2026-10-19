
using System.Collections.Generic;

public class Node
{
    // Store the name of the node
    public string Data { get; set; }

    // Store the nodes connected to this node
    public HashSet<Node> Edges { get; set; }

    // Constructor: create a node with a name
    public Node(string data)
    {
        Data = data;
        Edges = new HashSet<Node>();
    }
}
