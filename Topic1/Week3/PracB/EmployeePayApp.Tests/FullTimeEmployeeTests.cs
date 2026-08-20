using EmployeePayApp;

namespace EmployeePayApp.Tests;

public class FullTimeEmployeeTests
{
    [Fact]
    public void Constructor_ValidValues_CreatesEmployee()
    {
        FullTimeEmployee employee =
            new FullTimeEmployee("Bill", 50000m);

        Assert.Equal("Bill", employee.Name);
        Assert.Equal(50000m, employee.AnnualSalary);
    }

    [Fact]
    public void Constructor_EmptyName_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() =>
            new FullTimeEmployee("", 50000m));
    }

    [Fact]
    public void Constructor_NegativeSalary_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() =>
            new FullTimeEmployee("Bill", -100m));
    }

    [Fact]
    public void CalculatePay_ReturnsSalaryAfterTax()
    {
        FullTimeEmployee employee =
            new FullTimeEmployee("Bill", 50000m);

        decimal pay = employee.CalculatePay();

        Assert.Equal(40000m, pay);
    }

    [Fact]
    public void GenerateReport_ReturnsPayDetails()
    {
        FullTimeEmployee employee =
            new FullTimeEmployee("Bill", 50000m);

        string report = employee.GenerateReport();

        Assert.Contains("Bill", report);
        Assert.Contains("50000.00", report);
        Assert.Contains("10000.00", report);
        Assert.Contains("40000.00", report);
    }
}