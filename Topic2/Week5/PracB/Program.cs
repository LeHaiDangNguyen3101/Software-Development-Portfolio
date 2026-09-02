LinkedList<int> numbers = new LinkedList<int>();

// Add values using different insertion methods
numbers.AddFirst(30);
numbers.AddFirst(20);
numbers.AddFirst(10);

numbers.AddLast(40);
numbers.AddLast(50);
numbers.AddLast(60);
numbers.AddLast(70);
numbers.AddLast(80);

// AddBefore()
LinkedListNode<int>? node40 = numbers.Find(40);

if (node40 != null)
{
    numbers.AddBefore(node40, 35);
}

// AddAfter()
LinkedListNode<int>? node50 = numbers.Find(50);

if (node50 != null)
{
    numbers.AddAfter(node50, 55);
}

Console.WriteLine("-- Original LinkedList --");

foreach (int number in numbers)
{
    Console.WriteLine(number);
}


// Remove a specific value
numbers.Remove(35);

// Remove the first value
numbers.RemoveFirst();

// Remove the last value
numbers.RemoveLast();

Console.WriteLine();
Console.WriteLine("-- After Remove, RemoveFirst and RemoveLast --");

foreach (int number in numbers)
{
    Console.WriteLine(number);
}


// Remove the 5th element
LinkedListNode<int>? current = numbers.First;

for (int i = 1; i < 5 && current != null; i++)
{
    current = current.Next;
}

if (current != null)
{
    Console.WriteLine();
    Console.WriteLine($"Removing 5th element: {current.Value}");
    numbers.Remove(current);
}

Console.WriteLine();
Console.WriteLine("-- Final LinkedList --");

foreach (int number in numbers)
{
    Console.WriteLine(number);
}