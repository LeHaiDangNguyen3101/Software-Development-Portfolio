# Topic 1 Reflection

## What I learned

- I learned how to create and run C# console applications using the .NET CLI.
- I learned the difference between Python's dynamic typing and C#'s static typing.
- I practised using classes, properties, constructors, and methods.
- I learned how to use `List` and `Dictionary` collections to store and manage data.
- I learned how to create basic xUnit tests to check that methods work correctly.
- I learned how to use Git to track changes to my code.

## Difficulties

- I initially had difficulty installing and configuring the .NET SDK.
- I found the Git repository structure confusing at first.
- I needed more practice understanding zero-based indexes and how `Dictionary` stores keys and values.
- I initially found it difficult to separate a large program into smaller methods during refactoring.

## How I solved the problems

- I used `dotnet --info` to confirm that the .NET SDK was installed correctly.
- I tested my programs incrementally using `dotnet run`.
- I used breakpoints and variable inspection in VS Code to understand how the program executes.
- I tested both valid and invalid inputs in the Todo application to check my error handling.
- I used `dotnet test` to confirm that the `Person` methods worked correctly.
- I refactored the Todo application into separate methods so that each method has a clearer responsibility.

## Important Concepts and Development Practices
- **Static typing:** C# requires variable types to be defined, which can help identify type-related errors during development.
- **Object-oriented programming:** I used a `Person` class with properties, a constructor, and methods to organise related data and behaviour.
- **Collections:** I used `List<string>` for storing tasks and `Dictionary<string, List<int>>` for connecting tags to tasks.
- **Input validation:** I used checks such as `int.TryParse()` and index validation to prevent invalid user input from causing errors.
- **Debugging:** I used breakpoints and inspected local variables in VS Code instead of relying only on console output.
- **Unit testing:** I used xUnit tests to automatically verify expected behaviour such as `FullName()` and `IsAdult()`.
- **Refactoring:** I extracted parts of the Todo application into separate methods to improve readability and make the code easier to maintain.
- **Version control:** I used Git commits to record different stages of development rather than keeping only the final version of the code.