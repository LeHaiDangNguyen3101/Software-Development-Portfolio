using BankAccountApp;

SavingsAccount savings = new SavingsAccount(
    "Dang",
    1000m,
    5m
);

CheckingAccount checking = new CheckingAccount(
    "Dang",
    1000m,
    5m
);

Console.WriteLine("=== Savings Account ===");
savings.ApplyInterest();
savings.DisplayAccountInfo();

Console.WriteLine();

Console.WriteLine("=== Checking Account ===");
checking.Withdraw(200m);
checking.DisplayAccountInfo();
