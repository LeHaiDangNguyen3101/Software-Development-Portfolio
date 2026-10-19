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