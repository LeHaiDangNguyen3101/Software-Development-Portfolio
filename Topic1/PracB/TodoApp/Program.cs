List<string> tasks = new List<string>();
Dictionary<string, List<int>> tags = new Dictionary<string, List<int>>();

while (true)
{
    static string ReadCommand()
    {
        Console.Write("> ");
        return Console.ReadLine() ?? "";
    }

    string[] parts = input.Split(' ', 2);
    string command = parts[0].ToLower();GCNotificationStatus

    switch (command)
    {
        case "add":
            AddTask(tasks, parts);
            break;

        case "show":
            ShowTasks(tasks);
            break;

        case "remove":
            RemoveTask(tasks, parts);
            break;

        case "clear":
            ClearTasks(tasks);
            break;

        case "tag":
            TagTask(tasks, tags, input);
            break;

        case "get-tagged":
            ShowTaggedTasks(tasks, tags, parts);
            break;

        default:
            Console.WriteLine("Unknown command.");
            break;
    }
}

static void AddTask(List<string> tasks, string[] parts)
{
    if (parts.Length < 2 || string.IsNullOrWhiteSpace(parts[1]))
    {
        Console.WriteLine("Please provide a task to add.");
        return;
    }

    tasks.Add(parts[1]);
    Console.WriteLine("Task added.");
}

static void ShowTasks(List<string> tasks)
{
    if (tasks.Count == 0)
    {
        Console.WriteLine("No tasks.");
        return;
    }

    for (int i = 0; i < tasks.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {tasks[i]}");
    }
}

static void RemoveTask(List<string> tasks, string[] parts)
{
    if (parts.Length < 2)
    {
        Console.WriteLine("Please provide an index.");
        return;
    }

    if (!int.TryParse(parts[1], out int index))
    {
        Console.WriteLine("Index must be a number.");
        return;
    }

    if (index < 1 || index > tasks.Count)
    {
        Console.WriteLine("Index is out of range.");
        return;
    }

    tasks.RemoveAt(index - 1);
    Console.WriteLine("Task removed.");
}

static void ClearTasks(List<string> tasks)
{
    tasks.Clear();
    Console.WriteLine("All tasks cleared.");
}

static void TagTask(
    List<string> tasks,
    Dictionary<string, List<int>> tags,
    string input)
{
    string[] tagParts = input.Split(' ', 3);

    if (tagParts.Length < 3)
    {
        Console.WriteLine("Usage: tag [index] [name]");
        return;
    }

    if (!int.TryParse(tagParts[1], out int taskNumber))
    {
        Console.WriteLine("Index must be a number.");
        return;
    }

    int taskIndex = taskNumber - 1;

    if (taskIndex < 0 || taskIndex >= tasks.Count)
    {
        Console.WriteLine("Index is out of range.");
        return;
    }

    string tagName = tagParts[2].Trim().ToLower();

    if (string.IsNullOrWhiteSpace(tagName))
    {
        Console.WriteLine("Tag name cannot be empty.");
        return;
    }

    if (!tags.ContainsKey(tagName))
    {
        tags[tagName] = new List<int>();
    }

    if (tags[tagName].Contains(taskIndex))
    {
        Console.WriteLine("This task already has that tag.");
        return;
    }

    tags[tagName].Add(taskIndex);
    Console.WriteLine($"Tag '{tagName}' added to task {taskNumber}.");
}

static void ShowTaggedTasks(
    List<string> tasks,
    Dictionary<string, List<int>> tags,
    string[] parts)
{
    if (parts.Length < 2 || string.IsNullOrWhiteSpace(parts[1]))
    {
        Console.WriteLine("Usage: get-tagged [tag]");
        return;
    }

    string tagName = parts[1].Trim().ToLower();

    if (!tags.ContainsKey(tagName))
    {
        Console.WriteLine($"Tag '{tagName}' was not found.");
        return;
    }

    Console.WriteLine($"Tasks tagged '{tagName}':");

    foreach (int taskIndex in tags[tagName])
    {
        if (taskIndex >= 0 && taskIndex < tasks.Count)
        {
            Console.WriteLine($"{taskIndex + 1}. {tasks[taskIndex]}");
        }
    }
}