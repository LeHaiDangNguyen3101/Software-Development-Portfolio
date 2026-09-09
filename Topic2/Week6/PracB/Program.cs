using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<string> names = new List<string>
        {
            "Jack",
            "Alice",
            "Henry",
            "Emma",
            "Bob",
            "Grace",
            "David",
            "Charlie",
            "Isabella",
            "Frank"
        };

        Console.WriteLine("-- Original List --");

        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        var orderedNames = names.OrderBy(x => x);

        List<string> sortedNames = orderedNames.ToList();

        Console.WriteLine("\n-- Names in Alphabetical Order --");

        foreach (string name in sortedNames)
        {
            Console.WriteLine(name);
        }
    }
}
