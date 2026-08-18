using BankAccountApp;

Console.WriteLine("=== Savings Account ===");

SavingsAccount savings = new SavingsAccount(
    "Dang",
    1000m,
    5m
);

Console.WriteLine($"Owner: {savings.Owner}");
Console.WriteLine($"Starting balance: ${savings.Balance:F2}");
Console.WriteLine($"Interest rate: {savings.InterestRate}%");

savings.ApplyInterest();

Console.WriteLine($"Balance after interest: ${savings.Balance:F2}");

Console.WriteLine();

Console.WriteLine("=== Checking Account ===");

CheckingAccount checking = new CheckingAccount(
    "Dang",
    1000m,
    5m
);

Console.WriteLine($"Owner: {checking.Owner}");
Console.WriteLine($"Starting balance: ${checking.Balance:F2}");
Console.WriteLine($"Transaction fee: ${checking.TransactionFee:F2}");

checking.Withdraw(200m);

Console.WriteLine("Withdrew: $200.00");
Console.WriteLine($"Balance after withdrawal and fee: ${checking.Balance:F2}");
