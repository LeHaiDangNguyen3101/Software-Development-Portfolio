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

Console.WriteLine();
Console.WriteLine("-- Task 2: Collections of Classes --");

Person fred = new Person("Fred", "Smith", 21);
Person alice = new Person("Alice", "Brown", 19);
Person john = new Person("John", "Wilson", 35);
Person emma = new Person("Emma", "Taylor", 17);
Person michael = new Person("Michael", "Davis", 42);
Person sophia = new Person("Sophia", "Clark", 25);
Person ben = new Person("Ben", "Lewis", 15);
Person olivia = new Person("Olivia", "Walker", 31);
Person daniel = new Person("Daniel", "Hall", 28);
Person mia = new Person("Mia", "Young", 20);

List<Person> people = new List<Person>
{
    fred,
    alice,
    john,
    emma,
    michael,
    sophia,
    ben,
    olivia,
    daniel,
    mia
};

LinkedList<Person> linkedPeople =
    PersonUtilities.ToLinkedList(people);

Console.WriteLine();
Console.WriteLine("--- People in LinkedList ---");

Console.WriteLine(PersonUtilities.PrintPeople(linkedPeople));

LinkedList<Person> peopleToSort =
    PersonUtilities.ToLinkedList(people);

LinkedList<Person> sortedPeople =
    PersonUtilities.SortPeople(peopleToSort);

Console.WriteLine();
Console.WriteLine("--- People Sorted By Age ---");

Console.WriteLine(PersonUtilities.PrintPeople(sortedPeople));

Console.WriteLine();
Console.WriteLine("--- Quick Tests ---");

// Test 1: Check number of people
Console.WriteLine($"Original List count: {people.Count}");
Console.WriteLine($"LinkedList count: {linkedPeople.Count}");
Console.WriteLine($"Sorted LinkedList count: {sortedPeople.Count}");

// Test 2: Check youngest person
if (sortedPeople.First != null)
{
    Console.WriteLine(
        $"Youngest person: {sortedPeople.First.Value.FullName} - Age: {sortedPeople.First.Value.Age}"
    );
}

// Test 3: Check oldest person
if (sortedPeople.Last != null)
{
    Console.WriteLine(
        $"Oldest person: {sortedPeople.Last.Value.FullName} - Age: {sortedPeople.Last.Value.Age}"
    );
}

