using BankAccountApp;

namespace BankAccountApp.Tests;

public class BankAccountTests
{
    [Fact]
    public void Constructor_ValidValues_CreatesAccount()
    {
        BankAccount account = new BankAccount("Dang", 1000m);

        Assert.Equal("Dang", account.Owner);
        Assert.Equal(1000m, account.Balance);
    }

    [Fact]
    public void Constructor_EmptyOwner_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() =>
            new BankAccount("", 1000m));
    }

    [Fact]
    public void Constructor_NegativeBalance_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() =>
            new BankAccount("Dang", -100m));
    }

    [Fact]
    public void Deposit_DecimalAmount_IncreasesBalance()
    {
        BankAccount account = new BankAccount("Dang", 100m);

        account.Deposit(50m);

        Assert.Equal(150m, account.Balance);
    }

    [Fact]
    public void Deposit_InvalidAmount_ThrowsArgumentException()
    {
        BankAccount account = new BankAccount("Dang", 100m);

        Assert.Throws<ArgumentException>(() =>
            account.Deposit(0m));
    }

    [Fact]
    public void Deposit_IntAmount_IncreasesBalance()
    {
        BankAccount account = new BankAccount("Dang", 100m);

        account.Deposit(50);

        Assert.Equal(150m, account.Balance);
    }

    [Fact]
    public void Deposit_DoubleAmount_IncreasesBalance()
    {
        BankAccount account = new BankAccount("Dang", 100m);

        account.Deposit(50.5);

        Assert.Equal(150.5m, account.Balance);
    }

    [Fact]
    public void Withdraw_ValidAmount_DecreasesBalance()
    {
        BankAccount account = new BankAccount("Dang", 100m);

        account.Withdraw(40m);

        Assert.Equal(60m, account.Balance);
    }

    [Fact]
    public void Withdraw_InvalidAmount_ThrowsArgumentException()
    {
        BankAccount account = new BankAccount("Dang", 100m);

        Assert.Throws<ArgumentException>(() =>
            account.Withdraw(0m));
    }

    [Fact]
    public void Withdraw_InsufficientBalance_ThrowsInvalidOperationException()
    {
        BankAccount account = new BankAccount("Dang", 100m);

        Assert.Throws<InvalidOperationException>(() =>
            account.Withdraw(200m));
    }
}