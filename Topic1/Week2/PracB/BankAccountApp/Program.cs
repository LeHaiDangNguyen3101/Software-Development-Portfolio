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
