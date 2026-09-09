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