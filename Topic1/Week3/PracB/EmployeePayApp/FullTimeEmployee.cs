namespace EmployeePayApp;

public class FullTimeEmployee : Employee, IReportable
{
    public decimal AnnualSalary { get; set; }

    public FullTimeEmployee(string name, decimal annualSalary)
        : base(name)
    {
        if (annualSalary < 0)
        {
            throw new ArgumentException("Annual salary cannot be negative.");
        }

        AnnualSalary = annualSalary;
    }

    public override decimal CalculatePay()
    {
        decimal tax = AnnualSalary * TaxRate;
        return AnnualSalary - tax;
    }

    public string GenerateReport()
    {
        decimal tax = AnnualSalary * TaxRate;

        return $"Full-time Employee: {Name}, Salary: ${AnnualSalary:F2}, Tax: ${tax:F2}, Pay: ${CalculatePay():F2}";
    }
}