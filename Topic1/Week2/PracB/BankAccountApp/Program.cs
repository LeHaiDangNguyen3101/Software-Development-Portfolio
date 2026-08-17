using BankAccountApp;

try
{
    Console.Write("Enter account owner: ");
    string owner = Console.ReadLine() ?? "";

    Console.Write("Enter initial balance: $");
    decimal initialBalance = decimal.Parse(Console.ReadLine() ?? "0");

    BankAccount account = new BankAccount(owner, initialBalance);

    Console.WriteLine();
    Console.WriteLine($"Account owner: {account.Owner}");
    Console.WriteLine($"Current balance: ${account.Balance:F2}");

    Console.WriteLine();
    Console.Write("Enter amount to deposit: $");
    decimal depositAmount = decimal.Parse(Console.ReadLine() ?? "0");

    account.Deposit(depositAmount);

    Console.WriteLine($"Balance after deposit: ${account.Balance:F2}");

    Console.WriteLine();
    Console.Write("Enter amount to withdraw: $");
    decimal withdrawAmount = decimal.Parse(Console.ReadLine() ?? "0");

    account.Withdraw(withdrawAmount);

    Console.WriteLine($"Balance after withdrawal: ${account.Balance:F2}");
}
catch (FormatException)
{
    Console.WriteLine("Invalid input. Please enter a valid number.");
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}
catch (InvalidOperationException ex)
{
    Console.WriteLine(ex.Message);
}

Console.WriteLine();
Console.WriteLine("--Deposit Overloading Example--");

BankAccount testAccount = new BankAccount("Test Account", 100m);

testAccount.Deposit(50m);
Console.WriteLine($"After decimal deposit: ${testAccount.Balance:F2}");

testAccount.Deposit(25);
Console.WriteLine($"After int deposit: ${testAccount.Balance:F2}");

testAccount.Deposit(12.5);
Console.WriteLine($"After double deposit: ${testAccount.Balance:F2}");
