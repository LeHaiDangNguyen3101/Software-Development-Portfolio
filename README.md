# Software Development Portfolio

## Student Information

**Name:** Le Hai Dang Nguyen  
**Student ID:** a1914365

## About This Repository

This repository contains my practical work and learning progress for the Software Development course at the University of Adelaide.

The portfolio contains source code, tests, reflections, and other practical work completed during the semester. It demonstrates my progress in C# programming, software development practices, testing, debugging, refactoring, and version control.

## Repository Structure

### Topic 1
Topic 1 introduces the fundamentals of C# and software development practices.

### Week 1
#### Prac A
Prac A includes:
- Setting up the .NET development environment.
- Creating and running C# console applications.
- Using the VS Code debugger and breakpoints.
- Translating a Python payroll program into C#.
- Creating a `Person` class using properties, constructors, and methods.
- Using Git for basic version control.

#### Prac B
Prac B includes:
- Using `List<string>` to store tasks.
- Building a command-line Todo application.
- Using `Dictionary<string, List<int>>` for task tagging.
- Validating user input and handling errors.
- Creating basic xUnit tests.
- Refactoring code into smaller methods with clear responsibilities.
- Applying C# naming and coding conventions.

### Week 2
#### Prac A
Prac A includes:
- Refactoring the Week 1 Payroll Calculator from procedural code into a `Payroll` class.
- Using private fields to encapsulate payroll data.
- Creating a constructor with input validation.
- Using properties with getters and setters.
- Validating hours, hourly rate, and tax rate.
- Creating `CalculateNetPay()` and `ChangeTaxRate()` methods.
- Creating an xUnit test project for the `Payroll` class.
- Testing valid and invalid code paths.
- Achieving 100% line coverage for the `Payroll` class.

#### Prac B
Prac B includes:
- Creating a `BankAccount` class using auto-properties, a constructor, and methods.
- Applying encapsulation and access modifiers to protect account data.
- Implementing `Deposit()` and `Withdraw()` methods with validation.
- Using exceptions to handle invalid deposits and insufficient balances.
- Using method overloading with `decimal`, `int`, and `double` deposit amounts.
- Using casting and type conversion between numeric types.
- Creating an xUnit test project for the `BankAccount` class.
- Testing successful operations and exception paths.
- Achieving 100% line coverage for the `BankAccount` class.

### Week 3
#### Prac A
Prac A focuses on inheritance and polymorphism in C#.
It includes:
- Creating base and derived classes.
- Using `base()` constructors.
- Creating `SavingsAccount` and `CheckingAccount`.
- Using `virtual` and `override` methods.
- Writing xUnit tests for inherited classes.
- Generating test coverage reports.

#### Prac B
Prac B focuses on abstract classes, interfaces, and polymorphism in C#.
It includes:
- Creating an abstract `Employee` base class.
- Creating `FullTimeEmployee` and `Contractor` derived classes.
- Implementing the `IReportable` interface.
- Overriding `CalculatePay()` for different employee types.
- Using a `List<Employee>` to demonstrate polymorphism.
- Writing xUnit tests for the employee classes.
- Generating test coverage reports.

### Week 4
#### Prac A
Prac A focuses on debugging, code analysis, and refactoring in C#.
It includes:
- Using breakpoints and stepping through code with the debugger.
- Using Locals and Watch to inspect variables during execution.
- Finding and fixing logic and runtime errors.
- Fixing unreliable input parsing and handling line endings.
- Using .NET code analysis to identify code-quality issues.
- Refactoring code to improve readability and structure.
- Understanding the difference between errors and warnings.
- Deciding which code-analysis warnings should or should not be fixed.
#### Prac B
Prac B focuses on understanding, documenting, refactoring, and fixing unfamiliar C# code.
It includes:
- Using the debugger to understand code written by another developer.
- Using Step Into and Step Over to follow method execution.
- Working with `Index()` and C# range syntax such as `[..^1]`.
- Understanding `StringBuilder` and grid-based processing.
- Writing XML documentation comments for methods and parameters.
- Using the `Recommended` .NET code-analysis mode.
- Making small readability refactors.
- Changing a `void` method to return an `int`.
- Updating `totalCount` so the program reports the correct split total.

## Topic 2

Topic 2 focuses on working with collections and data structures in C#.

### Week 5

#### Prac A - Arrays and Lists

- Created and worked with `string[]` arrays.
- Used loops to access array values and find the shortest and longest names.
- Sorted and reversed arrays using `Array.Sort()` and `Array.Reverse()`.
- Created and modified `List<string>` using `Add()`, `Remove()`, `Insert()`, and `AddRange()`.
- Searched lists using `IndexOf()` and `Contains()`.
- Converted between `string[]` and `List<string>`.
- Compared the syntax, flexibility, performance, and use cases of arrays and lists.

#### Prac B - Linked Lists and Collections of Classes

- Used `LinkedList<T>` and `LinkedListNode<T>` to work with linked nodes.
- Inserted values using `AddFirst()`, `AddLast()`, `AddBefore()`, and `AddAfter()`.
- Removed values using `Remove()`, `RemoveFirst()`, and `RemoveLast()`.
- Traversed a linked list using `First` and `Next` instead of indexes.
- Created collections of `Person` objects using `List<Person>` and `LinkedList<Person>`.
- Implemented `ToLinkedList()`, `PrintPeople()`, and `SortPeople()`.
- Sorted people from youngest to oldest using a linked-list sorting algorithm.
- Learned how reference types allow the same object changes to appear across different collections.

### Week 6

#### Prac A - Stacks, Queues and Sorting

- Used `Stack<T>` and learned how LIFO (Last In, First Out) works with `Push()`, `Peek()`, and `Pop()`.
- Used `Queue<T>` and learned how FIFO (First In, First Out) works with `Enqueue()`, `Peek()`, and `Dequeue()`.
- Worked with `Stack<BankAccount>` and `Queue<BankAccount>` instead of only simple string values.
- Created a `StackToQueue()` method to convert a stack into a queue while keeping the same displayed order.
- Implemented a bubble sort algorithm to sort bank accounts from lowest to highest balance.
- Practised comparing neighbouring values and swapping objects without using a built-in sorting method.

#### Prac B - LINQ with Lists, Stacks and Queues

- Learned how to use LINQ to query and transform C# collections.
- Used `OrderBy()` to sort a `List<string>` alphabetically without changing the original list.
- Used `Select()` to retrieve the `Owner` property from `BankAccount` objects.
- Applied the same LINQ queries to both `Stack<BankAccount>` and `Queue<BankAccount>`.
- Used `Where()` to filter bank accounts based on the owner's name.
- Chained `Where()`, `Select()`, and `OrderBy()` to filter, select, and sort data.
- Learned how lambda expressions such as `x => x.Owner` work in LINQ.
- Learned that LINQ can work with collections that implement `IEnumerable<T>`.

### Week 7

#### Prac A - SortedSet and Data Plotting

- Used `SortedSet<int>` to store unique scores in automatically sorted order.
- Used `Min` and `Max` to find the lowest and highest scores.
- Learned how `SortedSet` handles duplicate values.
- Used `SortedSet<BankAccount>` with a custom `IComparer<BankAccount>`.
- Created a `BankComparer` to sort bank accounts by balance and owner name.
- Used LINQ `Select()` and `ToArray()` to extract account balances.
- Used ScottPlot to create a bar chart from the bank account data.
- Added axis labels, changed font sizes, and saved the graph as `Topic7A-Task3.png`.

### Prac B - SortedDictionary and PriorityQueue

- Created a player ranking system using `SortedDictionary`.
- Learned that dictionary keys must be unique while values can be duplicated.
- Used custom `ScoreEntry` objects as keys with `IComparer<ScoreEntry>`.
- Created a `ScoreComparer` to sort players by score and stage reached.
- Used `PriorityQueue<Player, int>` for priority-based player scheduling.
- Tested multiple players with the same priority.
- Used a `Priority` enum instead of integers to make priorities easier to understand.
- Compared the behaviour of `SortedSet`, `SortedDictionary`, and `PriorityQueue`.


### Week 8

#### Prac A - Hashtable and Complexity Analysis

- Used `Hashtable` to store Player objects and their scores as key-value pairs.
- Learned how `Hashtable` handles different key types and duplicate keys.
- Used `KeyValuePair<Player, int>` and `Sort()` to sort player scores in descending order.
- Used the `is` keyword to check data types safely.
- Used `Stopwatch` to measure the execution time of different methods.
- Compared normal string concatenation using `+=` with `StringBuilder.Append()`.
- Learned why StringBuilder is more efficient for repeated string operations.
- Used nested `for` loops and `List<double>` to collect benchmark results.
- Used ScottPlot to create graphs showing how execution time changes with input size.
- Learned about O(n²) and O(n) time complexity using the benchmark results.
- Saved the graphs as `appendPlot.png` and `buildPlot.png`.

#### Prac B - File I/O, JSON Serialization and Memory Benchmarking

- Used `System.IO` to create, write and read text files in C#.
- Used `StreamWriter`, `StreamReader` and `File.ReadAllText()` to work with `MyTest.txt`.
- Tested relative file paths, missing folders and file overwriting.
- Used `System.Text.Json` to serialize and deserialize a `List<Player>`.
- Saved and loaded five Player objects using `Players.json`.
- Created reusable generic `FileWriter<T>()` and `FileReader<T>()` methods.
- Used `where T : class` to restrict generic methods to reference types.
- Created a `LinkedList<Player>` and added players using `AddLast()`.
- Used `GC.Collect()` and `GC.GetGCMemoryInfo().HeapSizeBytes` to examine managed heap memory.
- Used `Process.GetCurrentProcess().PeakWorkingSet64` to measure peak process working-set memory.
- Compared memory measurements for `List<Player>` and `LinkedList<Player>` containing 10,000 players.
- Learned how data structure design can affect memory usage and why memory measurements need careful interpretation.

### Week 9

#### Prac A – Graphs, BFS and DFS

- Created a graph data structure using `Node` and `Graph` classes in C#.
- Used `HashSet<Node>` to store nodes and connections without duplicates.
- Implemented an undirected graph using the `AddEdge()` method.
- Implemented Breadth First Search (BFS) using a `Queue` to explore nodes level by level.
- Implemented Depth First Search (DFS) using a `Stack` to explore nodes branch by branch.
- Used visited-node collections to avoid repeated processing.
- Compared BFS and DFS traversal behaviour and their `O(V + E)` time complexity.


#### Prac B – Dijkstra's Algorithm and AI Code Generation

- Modified the graph structure to support weighted edges using `Dictionary<Node, int>`.
- Created a weighted graph with 16 nodes and 23 edges.
- Implemented Dijkstra's algorithm using `PriorityQueue<Node, int>`.
- Used dictionaries to track shortest distances and reconstruct the shortest path.
- Found the lowest-cost route from Start to End with a total weight of 10.
- Generated and tested an alternative implementation using ChatGPT.
- Compared object-oriented graph classes with a dictionary-based adjacency list.
- Reflected on C# learning, challenges and development practices throughout the semester.## Running the Projects

The .NET SDK is required to run the C# projects.

The following commands can be run from the root directory of this repository.

### Week 1 - Prac A

To run the Week 1 Payroll Calculator:

```powershell
dotnet run --project Topic1/Week1/PracA/PayrollCalculator
```

### Week 1 - Prac B

To run the Todo application:

```powershell
dotnet run --project Topic1/Week1/PracB/TodoApp
```

To run the Todo application unit tests:

```powershell
dotnet test Topic1/Week1/PracB/TodoApp.Tests
```

### Week 2 - Prac A

To run the Payroll Calculator:

```powershell
dotnet run --project Topic1/Week2/PracA/PayrollCalculator
```

To run the Payroll unit tests:

```powershell
dotnet test Topic1/Week2/PracA/PayrollCalculator.Tests
```

### Week 2 - Prac B

To run the BankAccount application:

```powershell
dotnet run --project Topic1/Week2/PracB/BankAccountApp
```

To run the BankAccount unit tests:

```powershell
dotnet test Topic1/Week2/PracB/BankAccountApp.Tests
```

## Weekly Reflection Notes

Each topic contains a `Notes.md` file describing:

- What I learned.
- Reflection questions for each workshop classes (if have)



This README will be updated as I complete additional topics throughout the semester.

