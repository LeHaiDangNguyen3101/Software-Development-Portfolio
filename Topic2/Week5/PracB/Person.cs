public class Person
{
    public string FirstName { get; private set; }
    public string LastName { get; private set; }

    private double age;

    public double Age
    {
        get
        {
            return age;
        }
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Age can't be less than or equal to zero");
            }

            age = value;
        }
    }

    public string FullName => $"{FirstName}, {LastName}";

    public Person(string firstName, string lastName, double age)
    {
        FirstName = firstName;
        LastName = lastName;

        if (age <= 0)
        {
            throw new ArgumentException("Age should be greater than zero");
        }

        Age = age;
    }

    public bool IsAdult()
    {
        return Age >= 18;
    }
}
