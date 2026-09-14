using System;

public class BankAccount
{
    public string Owner { get; set; }

    public double Balance { get; private set; }

    public BankAccount(string owner, double initialBalance)
    {
        if (string.IsNullOrWhiteSpace(owner))
        {
            throw new ArgumentException("Owner name cannot be empty.");
        }

        if (initialBalance < 0)
        {
            throw new ArgumentException("Initial balance cannot be negative.");
        }

        Owner = owner;
        Balance = initialBalance;
    }

    public void Deposit(double amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Deposit amount must be positive.");
        }

        Balance += amount;
    }

    public void Withdraw(double amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Withdrawal amount must be positive.");
        }

        if (amount > Balance)
        {
            throw new InvalidOperationException("Insufficient balance.");
        }

        Balance -= amount;
    }
}