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

## Running the Projects

The .NET SDK is required to run the C# projects.

The following commands can be run from the root directory of this repository.

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

## Weekly Reflection Notes

Each topic contains a `Notes.md` file describing:

- What I learned.
- Difficulties I encountered.
- How I solved problems.
- Important concepts and development practices.

## Learning Progression

### Topic 1

#### Week 1

During Week 1, I developed my understanding of the basic C# development workflow. I learned how to create and run .NET projects, work with static typing, create classes and methods, use collections namely `List` and `Dictionary`, debug programs using breakpoints, and create basic unit tests.

I also practised using Git to track development progress and learned how refactoring can improve the readability and maintainability of code.

#### Week 2

During Week 2, I developed my understanding of class-based design by refactoring the Week 1 Payroll Calculator into a `Payroll` class. I learned how encapsulation can keep data and related behaviour together and how properties with validation can prevent invalid values from being stored.

I also improved my unit testing skills using xUnit. I tested both valid and invalid code paths in the `Payroll` class and achieved 100% line coverage. This helped me understand the importance of testing different execution paths rather than only checking whether normal inputs work.

This README will be updated as I complete additional topics throughout the semester.
