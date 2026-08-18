namespace BankAccountApp;

public class CheckingAccount : BankAccount
{
    public decimal TransactionFee { get; set; }

    public CheckingAccount(
        string owner,
        decimal initialBalance,
        decimal transactionFee)
        : base(owner, initialBalance)
    {
        if (transactionFee < 0)
        {
            throw new ArgumentException("Transaction fee cannot be negative.");
        }

        TransactionFee = transactionFee;
    }

    public override void Withdraw(decimal amount)
    {
        decimal totalAmount = amount + TransactionFee;
        base.Withdraw(totalAmount);
    }
}