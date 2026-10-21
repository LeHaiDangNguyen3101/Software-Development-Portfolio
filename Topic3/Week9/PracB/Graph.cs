using System.Collections.Generic;
using System.Text;

public class Graph
{
    // Store all nodes in the graph
    public HashSet<Node> Nodes { get; set; }

    // Constructor
    public Graph()
    {
        Nodes = new HashSet<Node>();
    }

    // Connect two nodes with a weight
    public void AddEdge(Node fromNode, Node toNode, int weight)
    {
        // Add nodes to the graph
        Nodes.Add(fromNode);
        Nodes.Add(toNode);

        // Store the connection and its weight in both directions
        fromNode.Edges.Add(toNode, weight);
        toNode.Edges.Add(fromNode, weight);
    }

    // Display nodes, connections and weights
    public override string ToString()
    {
        StringBuilder result = new StringBuilder();

        foreach (Node node in Nodes)
        {
            result.Append(node.Data + ": ");

            foreach (KeyValuePair<Node, int> edge in node.Edges)
            {
                result.Append(edge.Key.Data + "(" + edge.Value + ") ");
            }

            result.AppendLine();
        }

        return result.ToString();
    }
}
