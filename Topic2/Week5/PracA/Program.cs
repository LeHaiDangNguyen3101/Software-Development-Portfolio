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

Console.WriteLine();
Console.WriteLine("-- Task 2: Using Lists --");

// Create a List of student names
List<string> studentNames = new List<string>
{
    "Alex",
    "Emma",
    "James",
    "Olivia",
    "William"
};


// Add()
studentNames.Add("Sophia");
studentNames.Add("Lucas");


// Insert()
studentNames.Insert(1, "Henry");


// AddRange()
studentNames.AddRange(new string[]
{
    "Mia",
    "Jack",
    "Grace"
});


// Remove()
studentNames.Remove("James");


Console.WriteLine();
Console.WriteLine("-- Student List After Add, Insert, AddRange and Remove --");

foreach (string student in studentNames)
{
    Console.WriteLine(student);
}


// Search for a specific name
Console.WriteLine();
Console.WriteLine("-- Exact Name Search --");

string searchName = "Sophia";
int index = studentNames.IndexOf(searchName);

if (index != -1)
{
    Console.WriteLine($"{searchName} found at index {index}");
}
else
{
    Console.WriteLine($"{searchName} was not found.");
}


// Search for a partial name
Console.WriteLine();
Console.WriteLine("-- Partial Name Search --");

string partialName = "ia";

foreach (string student in studentNames)
{
    if (student.Contains(partialName))
    {
        Console.WriteLine(student);
    }
}


// Sum the length of all names
int totalLength = 0;

foreach (string student in studentNames)
{
    totalLength += student.Length;
}

Console.WriteLine();
Console.WriteLine($"Total length of all student names: {totalLength}");


// Convert the Task 1 array into a List
List<string> arrayAsList = names.ToList();

Console.WriteLine();
Console.WriteLine("-- Task 1 Array Converted To List --");

foreach (string name in arrayAsList)
{
    Console.WriteLine(name);
}


// Add converted array values to the Task 2 List
studentNames.AddRange(arrayAsList);

Console.WriteLine();
Console.WriteLine("-- Final Student List --");

foreach (string student in studentNames)
{
    Console.WriteLine(student);
}