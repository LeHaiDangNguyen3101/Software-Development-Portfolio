namespace PayrollCalculator;

public class Payroll
{
    private double hours;
    private decimal rate;
    private decimal taxRate;

    public double Hours
    {
        get
        {
            return hours;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Hours cannot be negative.");
            }

            hours = value;
        }
    }

    public decimal Rate
    {
        get
        {
            return rate;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Rate cannot be negative.");
            }

            rate = value;
        }
    }

    public decimal TaxRate
    {
        get
        {
            return taxRate;
        }
        private set
        {
            if (value < 0)
            {
                throw new ArgumentException("Tax rate cannot be negative.");
            }

            taxRate = value;
        }
    }

    public Payroll(double hours, decimal rate, decimal taxRate)
    {
        Hours = hours;
        Rate = rate;
        TaxRate = taxRate;
    }

    public decimal CalculateNetPay()
    {
        decimal grossPay = (decimal)Hours * Rate;
        decimal tax = grossPay * TaxRate;

        return grossPay - tax;
    }

    public void ChangeTaxRate(decimal newTaxRate)
    {
        TaxRate = newTaxRate;
    }
}