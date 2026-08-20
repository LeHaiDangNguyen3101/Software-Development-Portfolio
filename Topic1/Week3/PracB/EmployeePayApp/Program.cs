using EmployeePayApp;

List<Employee> employees = new List<Employee>
{
    new FullTimeEmployee("Bill", 50000m),
    new Contractor("Fred", 50m, 40m)
};

foreach (Employee employee in employees)
{
    decimal pay = employee.CalculatePay();
    decimal tax;

    if (employee is FullTimeEmployee fullTime)
    {
        tax = fullTime.AnnualSalary * Employee.TaxRate;
    }
    else if (employee is Contractor contractor)
    {
        decimal grossPay = contractor.Rate * contractor.Hours;
        tax = grossPay * Employee.TaxRate;
    }
    else
    {
        tax = 0m;
    }

    Console.WriteLine($"{employee.Name}: Pay ${pay:F2}, Tax ${tax:F2}");
}
