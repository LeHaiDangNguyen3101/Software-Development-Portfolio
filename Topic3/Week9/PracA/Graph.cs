
using System.Collections.Generic;
using System.Text;

public class Graph
{
    // Store all nodes in the graph
    public HashSet<Node> Nodes { get; set; }

    // Constructor: create an empty graph
    public Graph()
    {
        Nodes = new HashSet<Node>();
    }

    // Connect two nodes together
    public void AddEdge(Node fromNode, Node toNode)
    {
        // Add both nodes to the graph
        Nodes.Add(fromNode);
        Nodes.Add(toNode);

        // Connect the nodes in both directions
        fromNode.Edges.Add(toNode);
        toNode.Edges.Add(fromNode);
    }

    // Display all nodes and their connections
    public override string ToString()
    {
        StringBuilder result = new StringBuilder();

        foreach (Node node in Nodes)
        {
            result.Append(node.Data + ": ");

            foreach (Node edge in node.Edges)
            {
                result.Append(edge.Data + " ");
            }

            result.AppendLine();
        }

        return result.ToString();
    }
}
