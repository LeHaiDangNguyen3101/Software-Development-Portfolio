using System;
using System.Collections.Generic;

public class BankComparer : IComparer<BankAccount>
{
    public int Compare(BankAccount? x, BankAccount? y)
    {
        if (x == null && y == null)
            return 0;

        if (x == null)
            return -1;

        if (y == null)
            return 1;

        // First compare by Balance
        int balanceComparison = x.Balance.CompareTo(y.Balance);

        if (balanceComparison != 0)
            return balanceComparison;

        // If balances are the same, compare by Owner
        return string.Compare(x.Owner, y.Owner, StringComparison.Ordinal);
    }
}