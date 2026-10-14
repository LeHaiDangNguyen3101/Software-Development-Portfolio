# Topic 2 Notes

## Week 5 - Prac A: Arrays and Lists

### What I Learned

In this practical, I learned how to use arrays and lists in C#. I created a `string[]` array, looped through the values, found the shortest and longest names, sorted the array using `Array.Sort()`, and reversed it using `Array.Reverse()`.

I also learned how to use `List<string>` and methods such as `Add()`, `Remove()`, `Insert()`, and `AddRange()`. I used `IndexOf()` to search for an exact name and `Contains()` to search for part of a name. I also calculated the total length of all names and converted a `string[]` array into a `List<string>` using `ToList()`.

### Array.Sort()

C# uses the `Array.Sort()` method to sort an array. When it is used with strings, the values are sorted in ascending alphabetical order.

### Comparing Arrays and Lists

Arrays use square brackets in their syntax, such as `string[] names`, while lists use generic syntax such as `List<string> names`.

An array has a fixed size after it is created. A list is more flexible because items can be added or removed while the program is running.

Arrays can be useful when the number of values is already known and will not change. Lists are useful when the number of values may change because they provide methods such as `Add()`, `Remove()`, `Insert()`, and `AddRange()`.

Arrays can be slightly simpler and use less overhead when working with a fixed number of values. Lists provide more flexibility and are usually easier to use when the collection needs to grow or shrink.

## Prac B: Linked Lists and Collections of Classes

### What I Learned

In this practical, I learned how to use `LinkedList<T>` in C# and how it is different from a `List<T>`. I used `AddFirst()`, `AddLast()`, `AddBefore()`, and `AddAfter()` to insert nodes, and `Remove()`, `RemoveFirst()`, and `RemoveLast()` to remove them. I also learned how to move through a linked list using `First` and `Next` because a linked list does not provide direct index access.

I also worked with collections of `Person` objects. I converted a `List<Person>` into a `LinkedList<Person>`, printed the people, and created a sorting algorithm that repeatedly finds the youngest person and moves them into a new linked list. This helped me understand how collections can store objects and how reference types behave when the same object is stored in multiple collections.

### Reflection Questions

#### How is `LinkedList<T>` different from `List<T>`?

A `List<T>` allows elements to be accessed directly using an index, such as `list[3]`. A `LinkedList<T>` stores elements as connected `LinkedListNode<T>` nodes. Each node has references to the previous and next nodes, so the linked list is normally accessed by moving through its nodes.

#### Why can't a `LinkedList<T>` be initialized using standard List syntax?

A `LinkedList<T>` is structured around linked nodes rather than indexed elements like a `List<T>`. Values are normally added using methods such as `AddFirst()`, `AddLast()`, `AddBefore()`, and `AddAfter()`.

#### Why can't we access a node using something like `linkedList[3]`?

`LinkedList<T>` does not provide an indexer. To reach a particular position, the program must start from a node such as `First` and follow the `Next` references until it reaches the required node.

#### Did changes to `fred` propagate to both the List and LinkedList? Why?

Yes. When I changed the `fred` object, the change appeared in both the `List<Person>` and `LinkedList<Person>`. This is because `Person` is a class and therefore a reference type. Both collections contain references to the same `Person` object rather than separate copies.
## Week 6 - Prac A: Stacks, Queues and Sorting

### What I Learned

In this practical, I learned how to use `Stack<T>` and `Queue<T>` in C#. A stack follows LIFO (Last In, First Out), where `Push()` adds an item, `Peek()` views the top item, and `Pop()` removes the top item. A queue follows FIFO (First In, First Out), where `Enqueue()` adds an item to the back, `Peek()` views the front item, and `Dequeue()` removes the front item.

I also learned how to use stacks and queues with objects such as `BankAccount`. I created a `Stack<BankAccount>` and wrote a `StackToQueue()` method to convert it into a `Queue<BankAccount>` while keeping the same displayed order.

Finally, I learned how to sort bank accounts by balance using a bubble sort algorithm. I copied the queue into a list, compared neighbouring balances, swapped them when they were in the wrong order, and then placed the sorted accounts back into a queue. This helped me understand how a basic sorting algorithm works instead of relying on a built-in sorting method.

## Prac B: LINQ with Lists, Stacks and Queues

### What I Learned

In this practical, I learned how to use LINQ to query and transform C# collections. I used `OrderBy()` to sort a list alphabetically, `Select()` to choose specific properties from `BankAccount` objects, and `Where()` to filter accounts based on a condition.

I also learned that LINQ works with different collections such as `List<T>`, `Stack<T>`, and `Queue<T>` because they implement `IEnumerable<T>`. LINQ methods return new query results instead of changing the original collection. I also became more familiar with lambda expressions such as `x => x.Owner` and method chaining using `Where()`, `Select()`, and `OrderBy()`.

### Reflection Questions

#### Task 1

**What type is your `List.OrderBy(x => x)` before converting it back to a list?**

It returns an `IOrderedEnumerable<string>`, not a `List<string>`.

**Why does `.OrderBy()` return ordered results instead of sorting the original list in place like `.Sort()`?**

LINQ methods normally return a new result and do not change the original collection. This makes the original data stay unchanged.

**What is the purpose of `x => x` in `List.OrderBy(x => x)`?**

The first `x` represents each item in the list, and the second `x` means the item itself is used as the value for sorting.

**What does `x` mean? Can I use any name? Why doesn't `x` have a type?**

`x` is just a parameter name for each item. I can use another name such as `name => name`. C# can infer the type automatically from the collection.

#### Task 2

**Did the syntax need to change between your Stack and Queue select? Why or why not?**

No. The LINQ syntax stayed the same because both `Stack<T>` and `Queue<T>` implement `IEnumerable<T>`, so LINQ can work with both collections.

#### Task 3

**Compared to the stack sorting algorithm in the previous practical, which did you prefer and why?**

I preferred LINQ because it is shorter and easier to read. The previous bubble sort required loops, comparisons and swapping, while LINQ can filter, select and sort using a few chained methods.

**Did you find the LINQ syntax unusual, or was it intuitive?**

At first the lambda syntax such as `x => x.Owner` looked unusual, but after using it several times it became easier to understand.

**Did the syntax need to change between your Stack and Queue select? Why or why not?**

No. The same LINQ methods worked for both Stack and Queue because both collections support enumeration through `IEnumerable<T>`.


## Week 7 - Prac A: SortedSet and Data Plotting

### What I Learned

In this practical, I learned how to use `SortedSet` in C# to store data in sorted order while preventing duplicate values. In Task 1, I used a `SortedSet<int>` to store game scores. The scores were automatically sorted, so I did not need to use `.Sort()`. I also used the `Min` and `Max` properties to find the lowest and highest scores.

In Task 2, I learned that a `SortedSet` needs to know how objects should be compared. When I tried to use `SortedSet<BankAccount>` without a comparer, the program produced a runtime error because `BankAccount` did not implement a default comparison. I fixed this by creating a `BankComparer` class that implements `IComparer<BankAccount>`. I compared accounts by their balance first and then by owner name when the balances were equal.

In Task 3, I learned how to use ScottPlot to visualise data in C#. I extracted the balances from the `SortedSet<BankAccount>` using LINQ `Select()` and converted them to a `double[]` using `ToArray()`. I then created a bar chart, added axis labels, changed the label font size and saved the graph as a PNG file.

### Reflection Questions

**1. Did you need to run `.Sort()` or similar on your `SortedSet` to maintain its ordering? Why or why not?**

No. `SortedSet` automatically keeps its elements in sorted order when values are added, so I did not need to manually call `.Sort()`.

**2. What is the underlying data structure used by `SortedSet`? How did you find out?**

`SortedSet` uses a self-balancing binary search tree, specifically a red-black tree. I found this by checking how `SortedSet` works in the .NET documentation.

**3. What happened when you tried to add the duplicate score to the set? Why does `SortedSet` behave this way?**

The duplicate score was not added and only one copy remained in the set. This is because `SortedSet` only stores unique values and does not allow duplicate elements.

### Difficulties and Solutions

The main difficulty was using `SortedSet` with `BankAccount` objects. The program initially produced an `ArgumentException` because C# did not know how to compare two `BankAccount` objects. I solved this by creating `BankComparer` with `IComparer<BankAccount>` and defining the comparison using balance and owner name.

Another new part was using ScottPlot. I needed to convert the account balances into a `double[]` before passing the data to the bar chart. Using LINQ `Select()` and `ToArray()` made this easier.

## Prac B: SortedDictionary and PriorityQueue

### Reflection Questions

#### Task 1: SortedDictionary

**1. What is the data structure backing the SortedDictionary? How did you find out?**

`SortedDictionary` is backed by a self-balancing binary search tree. I found this from the .NET documentation and also from the runtime error, which showed `TreeSet` in the error information.

**2. What happened when you tried to add a duplicate score? Why?**

When I tried to add a duplicate score, the program threw an `ArgumentException` because the score was being used as the key. A `SortedDictionary` requires every key to be unique, so two players cannot have the same integer key.

**3. Contrast SortedSet and SortedDictionary. Provide an example of when each might be useful.**

A `SortedSet` stores unique values and automatically keeps them sorted. It could be used for storing a unique set of game scores. A `SortedDictionary` stores key-value pairs and sorts them by key. It could be used for a ranking system where the score is the key and the player name is the value.

#### Task 3: PriorityQueue

**1. What data structure backs a PriorityQueue? How did you find out?**

A `PriorityQueue` is backed by a heap data structure. I found this from the .NET documentation. The heap allows the queue to efficiently find and remove the item with the highest priority.

**2. What happens when you Enqueue two different players with the same priority?**

Both players can be added to the `PriorityQueue`. Unlike a `SortedSet`, duplicate priorities are allowed. However, the order of players with the same priority is not guaranteed.

**3. Why does a PriorityQueue permit duplicates when a SortedSet does not?**

A `PriorityQueue` uses the priority to decide which item should be processed next, so multiple items are allowed to have the same priority. A `SortedSet` represents a set of unique values, so values that compare as equal are treated as duplicates.

#### Task 4: Priority Enum

**1. Why did we not need to implement IComparer or IComparable for the Priority enum?**

We did not need to create a custom comparer because enum values already have an underlying numeric order. In our enum, `HighPriority` is 0, `MediumPriority` is 1, and `LowPriority` is 2, so the `PriorityQueue` can compare them automatically.

**2. If we used a struct with `int Priority { get; set; } = 0` instead of an enum, would we need IComparer or IComparable? Why?**

Yes, if the struct itself was used as the priority type, we would need to provide a way to compare the struct objects, such as implementing `IComparable` or providing an `IComparer`. The `PriorityQueue` needs to know how one priority object should be ordered compared with another.

### What I Learned

In this practical, I learned how to use `SortedDictionary` and `PriorityQueue` to store and organise data automatically. I used a `SortedDictionary<int, string>` to create player rankings and learned that dictionary keys must be unique while values can be duplicated.

I also used custom `ScoreEntry` objects as dictionary keys. Because C# did not know how to compare these objects automatically, I created a `ScoreComparer` using `IComparer<ScoreEntry>` to compare the score first and the stage reached when scores were equal.

Finally, I learned how `PriorityQueue` processes items based on priority. I tested both integer priorities and an enum called `Priority`. I learned that lower priority values are processed first and multiple players can have the same priority.

## Week 8 - Prac A: Hashtable and Complexity Analysis

### What I Learned

In this practical, I learned how to use `Hashtable` in C# to store players and their scores using key-value pairs. In Task 1, I created a `Hashtable` with five `Player` objects as keys and integers as scores. I learned that `Hashtable` does not provide compile-time type safety because it stores keys and values as objects. I tested this by adding a string key, which was accepted, and a duplicate player key, which caused an `ArgumentException`. I also used `KeyValuePair<Player, int>` and `Sort()` to organise the players by score in descending order.

In Task 2, I learned how to use `Stopwatch` from `System.Diagnostics` to measure code performance. I compared normal string concatenation using `+=` with `StringBuilder.Append()` by adding 100,000 characters. The normal Append method took 709.61 ms, while StringBuilder only took 0.50 ms. This helped me understand why StringBuilder is more efficient when repeatedly modifying strings.

In Task 3, I learned how to analyse algorithm complexity using benchmarking and graphs. I used nested `for` loops to test both methods with increasing input sizes and stored their execution times in `List<double>`. I then used ScottPlot to create two bar charts and saved them as `appendPlot.png` and `buildPlot.png`. The results helped me understand Big-O notation, showing that repeated string concatenation has approximately O(n²) time complexity, while StringBuilder has approximately O(n) time complexity.

### Reflection Questions

**Task 1: Using Hashtable**
**1. What happened when you tried to add the (Key: String, Value: int) entry? Why?**
The string key was added successfully because `Hashtable` stores keys and values as objects, so it does not enforce specific data types at compile time.

**2. What happened when you tried to add the duplicate key?**
The program produced an `ArgumentException` because the same Player object was already stored as a key, and `Hashtable` does not allow duplicate keys.

**3. Were you able to use LINQ methods when writing your sorting algorithm? Why or why not?**
I did not use LINQ directly because `Hashtable` is not a strongly typed collection. Instead, I converted the entries into a `List<KeyValuePair<Player, int>>` and used `Sort()` to organise the scores in descending order.

**Task 2: Complexity Analysis Through Benchmarking**

**1. Which approach was faster? Append or Build?**
The StringBuilder method was faster, taking only 0.50 ms compared with 709.61 ms for normal string concatenation.

**2. Why?**
StringBuilder was faster because it uses a resizable buffer to add characters, while normal string concatenation repeatedly creates new strings and copies existing content.

**Task 3: Graphing the Analysis**
**1. What is the Big-O notation complexity of the Append method?**
The repeated string concatenation method has approximately O(n²) time complexity.

**2. How does your evidence support this conclusion?**
The execution time increased rapidly as the input size grew, from 6.88 ms for 10,000 characters to 3,324.56 ms for 200,000 characters. This showed a curved growth pattern, supporting O(n²) complexity.

**3. What is the Big-O notation complexity of the Builder method?**
The StringBuilder method has approximately O(n) time complexity.

**4. How does your evidence support this conclusion?**
The execution time increased slowly from 0.14 ms for 10,000 characters to 1.56 ms for 200,000 characters. This showed a roughly linear growth pattern, supporting O(n) complexity.

### Difficulties and Solutions
One difficulty was understanding how `Hashtable` handles different key types and duplicate keys. When I added a string key, it was accepted even though I intended to store only Player objects. I also received a warning when converting a Hashtable value directly into an integer. I fixed this by using the `is` keyword to check the key and value types before using them.

Another difficulty was understanding the performance difference between normal string concatenation and StringBuilder. I used `Stopwatch` to measure both methods with the same number of characters and found that StringBuilder was much faster. In Task 3, I used increasing input sizes and ScottPlot graphs to understand how their execution times changed. This helped me connect the benchmark results with Big-O notation.

## Week 8 - Prac B: File I/O, JSON Serialization and Memory Benchmarking

### What I Learned

In this practical, I learned how to read and write files in C# using `System.IO`. In Task 1, I used `StreamWriter` to create and write text into `MyTest.txt`, then used `StreamReader` and `File.ReadAllText()` to read the content. I also tested different file paths and learned that using a path with a folder that does not exist causes a `DirectoryNotFoundException`. I found that `File.CreateText()` overwrites the existing content when the file already exists.

In Task 2, I learned how to use `System.Text.Json` to serialize and deserialize a `List<Player>`. I created five Player objects, converted them into JSON using `JsonSerializer.Serialize()`, and saved the data to `Players.json`. I then used `JsonSerializer.Deserialize()` to convert the saved JSON back into a list of players. I also learned that the Player properties need to be public for them to be included in JSON serialization by default.

In Task 3, I learned how to refactor repeated file operations into reusable generic methods. I created `FileWriter<T>()` and `FileReader<T>()` using the `where T : class` constraint. These methods allowed me to save and load different collection types without repeating the same JSON code. I used them with `List<Player>` and later reused them with `LinkedList<Player>`.

In Task 4, I learned how to use `LinkedList<Player>` to store players in connected nodes. I added five players using `AddLast()`, saved and loaded the collection using my generic methods, and measured memory usage using `GC.GetGCMemoryInfo().HeapSizeBytes` and `Process.GetCurrentProcess().PeakWorkingSet64`. I also learned how the Garbage Collector manages memory used by .NET objects.

In Task 5, I compared the memory usage of `List<Player>` and `LinkedList<Player>` by creating 10,000 players in each collection. I saved and loaded both collections and measured their memory usage. The List run reported 10,572,752 bytes of managed heap size, while the LinkedList run reported 11,280,600 bytes. This helped me understand that LinkedList has additional memory overhead because each node stores references to other nodes. I also learned that these memory measurements include more than just the collections themselves.

### Reflection Questions

**Task 1: Basic File I/O**

**1. What happens if the text file already exists when you write to it?**

If the file already exists, `File.CreateText()` overwrites its previous content with the new text. I tested this by adding an extra line to `MyTest.txt` and running the program again. The extra line disappeared.

**2. What does the @ symbol before the quoted string mean?**

The `@` symbol creates a verbatim string literal in C#. It allows backslashes to be written without escaping them, which is useful for Windows file paths such as `@"C:\temp\MyTest.txt"`.

**3. Do you need to wrap the file access with using StreamReader and using StreamWriter? What would happen if you don't do this?**

Using `using` is recommended because it automatically closes and disposes of the reader or writer when finished. Without it, I would need to close or dispose of the file resources manually. Otherwise, the file could remain open longer than necessary and cause resource or file access problems.

**4. How is using StreamReader different from just File.ReadAllText()?**

`StreamReader` allows me to read a file gradually, such as one line at a time, while `File.ReadAllText()` reads the entire file into one string. StreamReader is useful for processing large files, while ReadAllText is simpler for small text files.

**Task 2: Serialise and Deserialise a List**

**1. What does the ! symbol at the end of the Deserialize line do?**

The `!` is the null-forgiving operator. It tells the compiler to ignore a possible null warning because I expect deserialization to return a valid object. However, it does not prevent null values or errors at runtime.

**2. What happens if all your class properties aren't public?**

By default, `System.Text.Json` serializes public properties. If properties are not public, they may be missing from the JSON output. In this task, I made the Health, Attack and Defence properties public so all player information could be saved correctly.

**Task 3: Refactor I/O Methods**

**1. What does where T : class mean?**

`where T : class` is a generic type constraint. It means the type `T` must be a reference type. This allows the same generic methods to work with different reference types, such as `List<Player>` and `LinkedList<Player>`.

**Task 4: Displaying Memory Usage for LinkedList**

**1. What is the purpose of the Garbage Collector?**

The Garbage Collector automatically manages memory used by .NET objects. It identifies objects that are no longer reachable and reclaims their managed memory.

**2. Why does it know the current amount of bytes allocated to the Heap?**

The .NET runtime manages the managed heap and tracks information about its memory usage. `GC.GetGCMemoryInfo().HeapSizeBytes` provides the heap size reported by the Garbage Collector after the most recent collection. It does not measure only the LinkedList.

**3. What does GC.Collect() do?**

`GC.Collect()` requests a garbage collection to reclaim memory from objects that are no longer reachable. I used it before checking memory information to make the results more consistent.

**4. Was the PeakWorkingSet64 different from the HeapSizeBytes? Why?**

Yes. In Task 4, HeapSizeBytes was 419,032 bytes, while PeakWorkingSet64 was 31,326,208 bytes. They were different because HeapSizeBytes reports managed heap information, while PeakWorkingSet64 measures the highest physical working-set memory used by the entire process, including other application memory.

**Task 5: Benchmarking Memory for List and LinkedList**

**1. Which class used more memory?**

In my experiment, the LinkedList run reported higher memory usage. Its HeapSizeBytes was 11,280,600 bytes compared with 10,572,752 bytes for List. The LinkedList run also had a higher PeakWorkingSet64.

**2. Why?**

A `List<T>` stores references in a backing array, while a `LinkedList<T>` creates separate nodes with additional references to neighbouring nodes. This means LinkedList usually has more memory overhead per element. However, my measurements included other application memory, so they did not measure the exact memory used by each collection alone.

### Difficulties and Solutions

One difficulty was understanding how file paths work. When I changed the path to a folder that did not exist, the program produced a `DirectoryNotFoundException`. I solved this by restoring the correct relative path and using `Directory.CreateDirectory()` to ensure the Attachments folder existed.

Another difficulty occurred in Task 3 when I accidentally declared `loadedPlayers` twice in the same scope. This caused a `CS0128` compilation error. I fixed it by removing the duplicate code and keeping the reusable file operations inside the `JsonFileHelper` class.

In Tasks 4 and 5, the main challenge was understanding memory measurements. I used `GC.Collect()`, `HeapSizeBytes` and `PeakWorkingSet64` to examine memory usage. By comparing List and LinkedList with the same number of players, I developed a better understanding of how different data structures can affect memory usage and why benchmark results need to be interpreted carefully.