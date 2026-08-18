using BankAccountApp;

namespace BankAccountApp.Tests;

public class SavingsAccountTests
{
    [Fact]
    public void Constructor_ValidValues_CreatesSavingsAccount()
    {
        SavingsAccount account = new SavingsAccount("Dang", 1000m, 5m);

        Assert.Equal("Dang", account.Owner);
        Assert.Equal(1000m, account.Balance);
        Assert.Equal(5m, account.InterestRate);
    }

    [Fact]
    public void Constructor_NegativeInterestRate_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() =>
            new SavingsAccount("Dang", 1000m, -1m));
    }

    [Fact]
    public void ApplyInterest_IncreasesBalance()
    {
        SavingsAccount account = new SavingsAccount("Dang", 1000m, 5m);

        account.ApplyInterest();

        Assert.Equal(1050m, account.Balance);
    }
    [Fact]
    public void DisplayAccountInfo_CanBeCalled()
    {
        SavingsAccount account = new SavingsAccount("Dang", 1000m, 5m);

        account.DisplayAccountInfo();
    }
}