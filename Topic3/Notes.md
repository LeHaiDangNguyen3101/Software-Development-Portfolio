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