using BankAccountApp;

namespace BankAccountApp.Tests;

public class CheckingAccountTests
{
    [Fact]
    public void Constructor_ValidValues_CreatesCheckingAccount()
    {
        CheckingAccount account = new CheckingAccount("Dang", 1000m, 5m);

        Assert.Equal("Dang", account.Owner);
        Assert.Equal(1000m, account.Balance);
        Assert.Equal(5m, account.TransactionFee);
    }

    [Fact]
    public void Constructor_NegativeTransactionFee_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() =>
            new CheckingAccount("Dang", 1000m, -5m));
    }

    [Fact]
    public void Withdraw_ValidAmount_DeductsAmountAndFee()
    {
        CheckingAccount account = new CheckingAccount("Dang", 1000m, 5m);

        account.Withdraw(200m);

        Assert.Equal(795m, account.Balance);
    }

    [Fact]
    public void Withdraw_TotalAmountGreaterThanBalance_ThrowsInvalidOperationException()
    {
        CheckingAccount account = new CheckingAccount("Dang", 200m, 5m);

        Assert.Throws<InvalidOperationException>(() =>
            account.Withdraw(200m));
    }
    [Fact]
    public void DisplayAccountInfo_CanBeCalled()
    {
        CheckingAccount account = new CheckingAccount("Dang", 1000m, 5m);

        account.DisplayAccountInfo();
    }
}