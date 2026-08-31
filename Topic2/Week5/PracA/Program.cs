string[] names =
{
    "Daniel",
    "Alice",
    "Christopher",
    "Ben",
    "Samantha",
    "John",
    "Elizabeth",
    "Tom",
    "Michael",
    "Kate"
};

Console.WriteLine("-- Original Array --");

foreach (string name in names)
{
    Console.WriteLine(name);
}


// Find shortest and longest names
string shortestName = names[0];
string longestName = names[0];

foreach (string name in names)
{
    if (name.Length < shortestName.Length)
    {
        shortestName = name;
    }

    if (name.Length > longestName.Length)
    {
        longestName = name;
    }
}

Console.WriteLine();
Console.WriteLine($"Shortest name: {shortestName}");
Console.WriteLine($"Longest name: {longestName}");


// Sort the array
Console.WriteLine();
Console.WriteLine("-- Before Sorting --");

foreach (string name in names)
{
    Console.WriteLine(name);
}

Array.Sort(names);

Console.WriteLine();
Console.WriteLine("-- After Sorting --");

foreach (string name in names)
{
    Console.WriteLine(name);
}


// Reverse the array
Console.WriteLine();
Console.WriteLine("-- Before Reversing --");

foreach (string name in names)
{
    Console.WriteLine(name);
}

Array.Reverse(names);

Console.WriteLine();
Console.WriteLine("-- After Reversing --");

foreach (string name in names)
{
    Console.WriteLine(name);
}
