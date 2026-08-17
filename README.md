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

## Running the Projects

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
- Difficulties I encountered.
- How I solved problems.
- Important concepts and development practices.

## Learning Progression

### Topic 1

#### Week 1

##### Prac A

In Prac A, I learned the basic C# and .NET development workflow. I created and ran console applications, worked with static typing, used the VS Code debugger and breakpoints, and translated a simple Payroll Calculator from Python into C#.

I also created a `Person` class using properties, a constructor, and methods. This introduced me to the basic structure of classes and object-oriented programming in C#.

##### Prac B

In Prac B, I developed my understanding of C# collections by using `List` and `Dictionary` in a command-line Todo application. I also practised input validation and error handling to make the application more reliable.

I learned how to create basic xUnit tests and refactor code into smaller methods with clearer responsibilities. I also continued using Git to record my development progress through separate commits.

#### Week 2

##### Prac A

In Prac A, I developed my understanding of class-based design by refactoring the Week 1 Payroll Calculator into a `Payroll` class. I learned how encapsulation can keep related data and behaviour together and how properties with validation can prevent invalid values from being stored.

I also improved my unit testing skills using xUnit. I tested valid and invalid code paths in the `Payroll` class and achieved 100% line coverage. This helped me understand the importance of testing different execution paths rather than only checking normal inputs.

##### Prac B

In Prac B, I extended my understanding of object-oriented programming by creating a `BankAccount` class. I used encapsulation and access modifiers to control how account data can be accessed and modified. I also used exceptions to prevent invalid deposits, withdrawals, and withdrawals that exceeded the available balance.

I learned how method overloading allows methods to share the same name while accepting different parameter types. I created `Deposit()` overloads for `decimal`, `int`, and `double` values and used casting to reuse the main deposit logic.

I continued developing my unit testing skills by testing successful operations, invalid inputs, exception paths, and overloaded methods. All 10 tests passed, and the `BankAccount` class achieved 100% line coverage.

This README will be updated as I complete additional topics throughout the semester.
