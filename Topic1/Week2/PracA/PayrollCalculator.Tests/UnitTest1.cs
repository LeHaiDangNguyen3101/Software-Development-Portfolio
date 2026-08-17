using PayrollCalculator;

namespace PayrollCalculator.Tests;

public class PayrollTests
{
    [Fact]
    public void CalculateNetPay_ReturnsCorrectNetPay()
    {
        Payroll payroll = new Payroll(40, 30m, 0.2m);

        decimal result = payroll.CalculateNetPay();

        Assert.Equal(960m, result);
    }

    [Fact]
    public void Constructor_NegativeHours_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() =>
            new Payroll(-1, 30m, 0.2m));
    }

    [Fact]
    public void Constructor_NegativeRate_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() =>
            new Payroll(40, -1m, 0.2m));
    }

    [Fact]
    public void Constructor_NegativeTaxRate_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() =>
            new Payroll(40, 30m, -0.1m));
    }

    [Fact]
    public void Hours_CanBeChangedToValidValue()
    {
        Payroll payroll = new Payroll(40, 30m, 0.2m);

        payroll.Hours = 45;

        Assert.Equal(45, payroll.Hours);
    }

    [Fact]
    public void Hours_NegativeValue_ThrowsArgumentException()
    {
        Payroll payroll = new Payroll(40, 30m, 0.2m);

        Assert.Throws<ArgumentException>(() =>
            payroll.Hours = -5);
    }

    [Fact]
    public void Rate_CanBeChangedToValidValue()
    {
        Payroll payroll = new Payroll(40, 30m, 0.2m);

        payroll.Rate = 35m;

        Assert.Equal(35m, payroll.Rate);
    }

    [Fact]
    public void Rate_NegativeValue_ThrowsArgumentException()
    {
        Payroll payroll = new Payroll(40, 30m, 0.2m);

        Assert.Throws<ArgumentException>(() =>
            payroll.Rate = -10m);
    }

    [Fact]
    public void ChangeTaxRate_ChangesTaxRate()
    {
        Payroll payroll = new Payroll(40, 30m, 0.2m);

        payroll.ChangeTaxRate(0.1m);

        Assert.Equal(1080m, payroll.CalculateNetPay());
    }

    [Fact]
    public void ChangeTaxRate_NegativeValue_ThrowsArgumentException()
    {
        Payroll payroll = new Payroll(40, 30m, 0.2m);

        Assert.Throws<ArgumentException>(() =>
            payroll.ChangeTaxRate(-0.1m));
    }
}
