# Topic 1 Reflection
## Week 1
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

## Week 2 - Prac A: Classes, Properties and Unit Testing

### What I Learned
In this practical, I refactored the procedural Payroll Calculator from Week 1 into a class-based design. I created a `Payroll` class to store payroll data and used methods namely `CalculateNetPay()` and `ChangeTaxRate()` to control its behaviour.
I also learned how to use properties with getters and setters. Validation inside the setters prevents invalid values such as negative hours, rates, or tax rates from being stored in a Payroll object.

### Procedural vs Class-Based Design
In the procedural version, the payroll data and calculation logic were mainly handled directly in `Program.cs`. After changing to a class-based design, the data and related behaviour were grouped inside the `Payroll` class.
I found the class-based version more organised because `Program.cs` only needs to create and use a Payroll object, while the Payroll class is responsible for calculations and validation. This also makes the code easier to reuse, test, and maintain.

### Static Typing
Static typing helps me identify type errors while writing or compiling the program. For example, `hours` uses `double`, while money values such as `rate` and `taxRate` use `decimal`. C# checks that I use these types correctly.
Sometimes static typing requires extra conversions, such as converting `hours` from `double` to `decimal` during the payroll calculation. However, it helps prevent unexpected type-related errors and makes the expected data types clearer.


## Week 2 - Prac B: BankAccount and Method Overloading

### What I Learned
In this practical, I created a `BankAccount` class using auto-properties, a constructor, and methods to manage an account. The `Owner` property stores the account owner's name, while the `Balance` property uses a private setter so that the balance cannot be changed directly from outside the class.
I implemented `Deposit()` and `Withdraw()` methods to control changes to the account balance. I also used exceptions to prevent invalid operations such as depositing a non-positive amount, withdrawing a non-positive amount, or withdrawing more money than the available balance.

### Encapsulation in C#
Encapsulation groups related data and behaviour inside a class and controls how the data can be accessed or modified. In my `BankAccount` class, the balance can be read publicly but has a private setter. This means other code cannot directly change the balance and must use the `Deposit()` or `Withdraw()` methods.
This helps protect the object from invalid changes and keeps the rules for managing the balance inside the `BankAccount` class.

### Importance of Access Modifiers
Access modifiers control which parts of a program can access classes, properties, methods, and other members. For example, `public` allows a member to be accessed from outside the class, while `private` restricts access to the class itself.
In the `BankAccount` class, using `public decimal Balance { get; private set; }` allows other code to view the balance but prevents it from changing the balance directly. This makes the class safer and gives better control over its data.

### Method Overloading
Method overloading allows multiple methods to have the same name as long as they have different parameter types or parameter lists. I created three versions of the `Deposit()` method that accept `decimal`, `int`, and `double` values.
C# selects the appropriate method based on the type of argument passed to it. The `int` and `double` versions convert their values to `decimal` and then call the main `Deposit(decimal amount)` method. This avoids repeating the deposit validation and calculation logic.
For a Python programmer, I would explain that C# can define several methods with the same name and choose between them at compile time based on the argument types. Python does not normally use method overloading in the same way because Python is dynamically typed.

## Week 3 - Prac A

### What I Learned
In this practical, I learned how inheritance allows derived classes to reuse properties and methods from a base class. I used `BankAccount` as the base class and created `SavingsAccount` and `CheckingAccount` as derived classes with their own additional properties and behaviours.
I also learned how to use `base()` to call the parent constructor and how `virtual` and `override` allow derived classes to change inherited behaviour. I used xUnit tests and code coverage to check that the base and derived classes worked correctly.

### Inheritance
In this practical, I converted `BankAccount` into a base class and created `SavingsAccount` and `CheckingAccount` as derived classes.
Inheritance reduces duplicated code because both subclasses can reuse common properties and methods from `BankAccount`, such as `Owner`, `Balance`, `Deposit()`, and `Withdraw()`. This means I do not need to rewrite the same banking logic in every account class.
`SavingsAccount` has the responsibility of storing an interest rate and applying interest to the balance using `ApplyInterest()`.
`CheckingAccount` has the responsibility of storing a transaction fee and deducting the fee whenever a withdrawal is made.
I also learned how `base()` calls the constructor or methods from the parent class, while `virtual` and `override` allow subclasses to change inherited behaviour. I used this for `Withdraw()` and `DisplayAccountInfo()`.

## Week 3 - Prac B

### What I Learned
In this practical, I learned how to use an abstract `Employee` class as a common base for `FullTimeEmployee` and `Contractor`. I also used the `IReportable` interface so both employee types provide a `GenerateReport()` method while implementing their own `CalculatePay()` behaviour.
I learned that polymorphism allows different derived objects to be stored in the same `List<Employee>` and still use the correct method for each object. I also learned that C# uses explicit features such as `abstract`, `interface`, and `override`, while Python can provide similar behaviour more dynamically. I used xUnit tests and code coverage to verify the employee classes.

### Abstract Classes and Interfaces
In this practical, I created an abstract `Employee` base class with an abstract `CalculatePay()` method. I then created `FullTimeEmployee` and `Contractor` as derived classes.
The `IReportable` interface was also implemented by both derived classes. This made sure that both classes provided their own `GenerateReport()` method.

### Polymorphism
Polymorphism allows different derived objects to be treated as the same base type while still using their own behaviour.
For example, both `FullTimeEmployee` and `Contractor` can be stored inside a `List<Employee>`. When `CalculatePay()` is called on each object, C# automatically uses the correct overridden method for the actual employee type.
Inheritance alone allows classes to reuse properties and methods from a base class. Polymorphism goes further by allowing the same base-class reference to produce different behaviour depending on the actual object.

### Comparison with Python
This is similar to Python because Python also allows different objects to respond differently to the same method call.
However, C# is more explicit because inheritance, abstract classes, interfaces, and overridden methods are declared using keywords such as `abstract`, `interface`, and `override`.
Python uses dynamic typing and usually does not require the same amount of type declarations.

