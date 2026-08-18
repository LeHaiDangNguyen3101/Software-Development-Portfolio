namespace BankAccountApp;

public class SavingsAccount : BankAccount
{
    public decimal InterestRate { get; set; }

    public SavingsAccount(
        string owner,
        decimal initialBalance,
        decimal interestRate)
        : base(owner, initialBalance)
    {
        if (interestRate < 0)
        {
            throw new ArgumentException("Interest rate cannot be negative.");
        }

        InterestRate = interestRate;
    }

    public void ApplyInterest()
    {
        decimal interest = Balance * InterestRate / 100;
        Deposit(interest);
    }
}