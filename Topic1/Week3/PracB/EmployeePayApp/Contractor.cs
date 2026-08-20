namespace EmployeePayApp;

public class Contractor : Employee, IReportable
{
    public decimal Rate { get; set; }
    public decimal Hours { get; set; }

    public Contractor(string name, decimal rate, decimal hours)
        : base(name)
    {
        if (rate < 0)
        {
            throw new ArgumentException("Rate cannot be negative.");
        }

        if (hours < 0)
        {
            throw new ArgumentException("Hours cannot be negative.");
        }

        Rate = rate;
        Hours = hours;
    }

    public override decimal CalculatePay()
    {
        decimal grossPay = Rate * Hours;
        decimal tax = grossPay * TaxRate;

        return grossPay - tax;
    }

    public string GenerateReport()
    {
        decimal grossPay = Rate * Hours;
        decimal tax = grossPay * TaxRate;

        return $"Contractor: {Name}, Gross: ${grossPay:F2}, Tax: ${tax:F2}, Pay: ${CalculatePay():F2}";
    }
}