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
    public void Deposit_ValidAmount_IncreasesBalance()
    {
        BankAccount account = new BankAccount("Dang", 1000m);

        account.Deposit(500m);

        Assert.Equal(1500m, account.Balance);
    }

    [Fact]
    public void Deposit_ZeroAmount_ThrowsArgumentException()
    {
        BankAccount account = new BankAccount("Dang", 1000m);

        Assert.Throws<ArgumentException>(() =>
            account.Deposit(0m));
    }

    [Fact]
    public void Withdraw_ValidAmount_DecreasesBalance()
    {
        BankAccount account = new BankAccount("Dang", 1000m);

        account.Withdraw(200m);

        Assert.Equal(800m, account.Balance);
    }

    [Fact]
    public void Withdraw_AmountGreaterThanBalance_ThrowsInvalidOperationException()
    {
        BankAccount account = new BankAccount("Dang", 1000m);

        Assert.Throws<InvalidOperationException>(() =>
            account.Withdraw(1500m));
    }

    [Fact]
    public void Withdraw_ZeroAmount_ThrowsArgumentException()
    {
        BankAccount account = new BankAccount("Dang", 1000m);

        Assert.Throws<ArgumentException>(() =>
            account.Withdraw(0m));
    }
}