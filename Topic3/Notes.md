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

## Week 9 – Prac A: Graphs, BFS and DFS

### What I Learned

In this practical, I learned how to create and use a graph data structure in C#. I created a `Node` class to store node data and connected nodes, and a `Graph` class to manage all the nodes and their edges. I used `HashSet<Node>` to prevent duplicate connections and implemented the `AddEdge()` method to create an undirected graph.

I also learned how Breadth First Search (BFS) and Depth First Search (DFS) work. BFS uses a `Queue` to visit nodes level by level, while DFS uses a `Stack` to explore one branch before moving to another. I used collections to keep track of visited nodes and avoid repeated visits.

By testing both algorithms on the original and adjusted graphs, I learned that BFS finds the shortest path in an unweighted graph, while DFS may reach a target faster depending on the order of the nodes. I also learned that both algorithms have a time complexity of `O(V + E)`.

**Task 1 reflection answers**
**Q1. What sort of graph have we created?**

We created an undirected, acyclic, and unweighted graph. It is also a tree because all nodes are connected and there are no cycles.

**Q2. What are two other commonly used data structures that are secretly graphs?**

Trees and linked lists are also graphs because they contain nodes connected by links.

**Task 2 reflection answers**

**Q1. Why do we need to keep track of visited nodes?**

We track visited nodes to avoid visiting the same node repeatedly and to prevent infinite loops when the graph contains cycles.

**Q2. In the adjusted graph, which path does BFS take to I? Why?**

BFS finds the path A → C → F → I because it explores the graph level by level and finds the shortest path in an unweighted graph.

**Q3. What is the computational complexity of BFS? What do V and E mean?**

BFS has a time complexity of O(V + E), where V is the number of vertices (nodes) and E is the number of edges (connections).

**Task 3 reflection answers**

**Q1. For the initial graph, which algorithm would find the target faster, BFS or DFS? Why?**

With our node order, DFS reaches I faster because it explores the A → C → F → I branch directly, whereas BFS visits other nodes level by level.

**Q2. For the adjusted graph, which algorithm would find the target faster, BFS or DFS? Why?**

**With our current node order, DFS still reaches I faster because it explores the C branch first. However, the result can change depending on the order in which neighbours are processed.**

**Q3. If the algorithms are different, how can their computational complexity be the same?**

Both BFS and DFS have a time complexity of O(V + E) because, in the worst case, both visit all nodes and examine all edges, even though they visit them in different orders.

## Week 9 – Prac B: Dijkstra's Algorithm and AI Code Generation

### What I Learned

In this practical, I learned how to implement Dijkstra's algorithm in C# to find the shortest path in a weighted graph. I modified my previous `Node` and `Graph` classes to use `Dictionary<Node, int>` instead of `HashSet<Node>`, allowing each connection to store a weight. I created a graph with 16 nodes and 23 edges, using weights of 1 for safer paths and 5 for less desirable paths.

I used `PriorityQueue<Node, int>` to process nodes based on their lowest known total distance. I also used dictionaries to store the shortest distances and parent nodes, which helped me reconstruct the final path from Start to End. My program successfully found the shortest path with a total weight of 10.

I also learned how Dijkstra's algorithm differs from BFS and DFS. BFS explores nodes level by level using a Queue, while DFS explores branches using a Stack. Dijkstra's algorithm considers the weight of each connection to find the path with the lowest total cost rather than simply the fewest edges.

In Task 2, I used ChatGPT to generate a separate implementation of Dijkstra's algorithm. The AI-generated code used string-based nodes and a dictionary-based adjacency list instead of separate `Node` and `Graph` classes. Both implementations produced the same shortest path and total weight. This helped me understand that the same algorithm can be implemented using different data structures.

### Task 1 – Dijkstra's Algorithm: Reflection Answers

**Q1. Explain, in plain English, how does your implementation of Dijkstra's algorithm work?**

My implementation starts from the Start node and gives it a distance of 0, while all other nodes are initially given an infinite distance. It uses a `PriorityQueue` to process the node with the lowest known distance first. For each connected node, the algorithm calculates the new total distance and updates it if a shorter path is found. It also records the previous node using the `parents` dictionary. Once the destination is reached, the program follows the parent nodes backwards and reverses the list to display the shortest path from Start to End.

**Q2. What is the computational complexity of Dijkstra's algorithm? Why is it different from BFS / DFS?**

My implementation of Dijkstra's algorithm has a time complexity of `O((V + E) log V)` using a priority queue, where V is the number of nodes and E is the number of edges. This is different from BFS and DFS, which have a time complexity of `O(V + E)`, because Dijkstra's algorithm needs to manage node priorities based on their distances. BFS and DFS only traverse the graph without comparing weighted distances.

### Task 2 – AI Code Generation: Reflection Answers

**Q1. What AI tool did you use?**

I used ChatGPT to generate an alternative implementation of Dijkstra's algorithm in C#.

**Q2. What were some of the prompts you used?**

I asked ChatGPT to generate a complete C# implementation of Dijkstra's algorithm using the same weighted horse graph from Task 1. I also requested a separate working console application that could run using `dotnet run`, with a different code structure so I could compare it with my original implementation.

**Q3. Did the AI one-shot the problem, or did it require revision? How many rounds did it take?**

The AI-generated implementation worked correctly on the first run, so no revisions were needed to fix the algorithm. The program successfully created the graph with 16 nodes and 23 edges and found the same shortest path with a total weight of 10.

**Q4. What was one of the ways the AI code was substantially different from your approach?**

My original implementation used separate `Node` and `Graph` classes to represent the graph, while the AI-generated implementation used a dictionary-based adjacency list with string node names. The AI also placed Dijkstra's algorithm inside a reusable method instead of writing the algorithm directly in the main program.

**Q5. Compared to your code, what was one aspect the AI tool did better?**

One aspect the AI did better was organizing Dijkstra's algorithm into a reusable method that accepts a starting node and a destination. This makes it easier to run the algorithm again with different starting and ending nodes without rewriting the main logic.

**Q6. Compared to your code, what was one aspect the AI tool did worse?**

One disadvantage of the AI-generated code was that it used more compact syntax, such as tuples and an adjacency list, which was harder for me to understand as a beginner. My original implementation was easier to follow because the `Node` and `Graph` classes were similar to what I had already learned in Prac A.

### Task 3 – Wrapping Up: Reflection Answers

**Q1. What's been your favourite C# feature?**

My favourite C# feature is LINQ because it makes it easier to sort, filter, and work with collections without writing complicated loops.

**Q2. What's been your most hated C# feature?**

My least favourite C# feature is generics because I sometimes find it difficult to understand how different types work together, especially when using dictionaries and other collections.

**Q3. What was the easiest practical or topic for you, and why?**

I found the earlier practicals involving basic classes, methods, and object-oriented programming easier because the code was more straightforward, and I could understand how each method affected the program's output.

**Q4. What was the most fun practical or topic for you, and why?**

I enjoyed Week 9 Prac A because implementing BFS and DFS helped me understand how different algorithms search through the same graph. It was interesting to compare their visiting orders and see how using a Queue or Stack changes the algorithm's behaviour.

**Q5. What's one area you're going to revise before the exam?**

I plan to revise data structures and algorithms, especially graphs, BFS, DFS, Dijkstra's algorithm, and the differences between Queue, Stack, and PriorityQueue. I want to become more confident understanding the code and explaining how each algorithm works.

**Q6. What's one piece of advice you would give to new students taking SDP next semester?**

I would recommend completing each practical step by step, testing the code regularly, and trying to understand how it works instead of only copying it. Making small Git commits after each task also helps track progress and makes it easier to manage changes.

**Q7. What's one suggestion you have for the course coordinator to make the course better?**

I would suggest providing more step-by-step worked examples for complex topics such as graphs and algorithms. It would also be helpful to include more examples showing how the values and data structures change while the program is running.

### Final Reflection

Throughout this semester, I improved my understanding of C# programming, object-oriented programming, data structures, debugging, file handling, and algorithms. I also gained more experience using Git and GitHub to manage my code and track my progress through regular commits.

The practicals helped me become more comfortable reading and understanding code, especially when working with classes, collections, LINQ, and graph algorithms. I learned that testing code regularly and using the debugger are important ways to identify and solve problems.

I still need more practice with complex data structures and algorithms, but I feel more confident working with C# than at the beginning of the semester. I plan to continue revising these topics and applying what I have learned to future software development projects.