using PayrollCalculator;

try
{
    Console.Write("Enter employee name: ");
    string name = Console.ReadLine() ?? "";

    Console.Write("Hours worked: ");
    double hours = double.Parse(Console.ReadLine() ?? "0");

    Console.Write("Hourly rate: ");
    decimal rate = decimal.Parse(Console.ReadLine() ?? "0");

    Payroll payroll = new Payroll(hours, rate, 0.2m);

    decimal netPay = payroll.CalculateNetPay();

    Console.WriteLine($"{name} earned ${netPay:F2} after tax.");
}
catch (FormatException)
{
    Console.WriteLine("Invalid input. Please enter numbers for hours and rate.");
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}