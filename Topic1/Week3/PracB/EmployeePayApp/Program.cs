using EmployeePayApp;

Console.WriteLine("-- Full-Time Employee --");

FullTimeEmployee fullTime = new FullTimeEmployee(
    "Bill",
    50000m
);

Console.WriteLine($"Name: {fullTime.Name}");
Console.WriteLine($"Annual salary: ${fullTime.AnnualSalary:F2}");
Console.WriteLine($"Calculated pay: ${fullTime.CalculatePay():F2}");
Console.WriteLine(fullTime.GenerateReport());

Console.WriteLine();

Console.WriteLine("-- Contractor --");

Contractor contractor = new Contractor(
    "Fred",
    50m,
    40m
);

Console.WriteLine($"Name: {contractor.Name}");
Console.WriteLine($"Rate: ${contractor.Rate:F2}");
Console.WriteLine($"Hours: {contractor.Hours}");
Console.WriteLine($"Calculated pay: ${contractor.CalculatePay():F2}");
Console.WriteLine(contractor.GenerateReport());
