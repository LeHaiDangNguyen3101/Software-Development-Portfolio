using EmployeePayApp;

namespace EmployeePayApp.Tests;

public class ContractorTests
{
    [Fact]
    public void Constructor_ValidValues_CreatesContractor()
    {
        Contractor contractor =
            new Contractor("Fred", 50m, 40m);

        Assert.Equal("Fred", contractor.Name);
        Assert.Equal(50m, contractor.Rate);
        Assert.Equal(40m, contractor.Hours);
    }

    [Fact]
    public void Constructor_NegativeRate_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() =>
            new Contractor("Fred", -10m, 40m));
    }

    [Fact]
    public void Constructor_NegativeHours_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() =>
            new Contractor("Fred", 50m, -1m));
    }

    [Fact]
    public void CalculatePay_ReturnsPayAfterTax()
    {
        Contractor contractor =
            new Contractor("Fred", 50m, 40m);

        decimal pay = contractor.CalculatePay();

        Assert.Equal(1600m, pay);
    }

    [Fact]
    public void GenerateReport_ReturnsPayDetails()
    {
        Contractor contractor =
            new Contractor("Fred", 50m, 40m);

        string report = contractor.GenerateReport();

        Assert.Contains("Fred", report);
        Assert.Contains("2000.00", report);
        Assert.Contains("400.00", report);
        Assert.Contains("1600.00", report);
    }
}