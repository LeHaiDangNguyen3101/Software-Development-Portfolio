namespace TodoApp.Tests;

public class PersonTests
{
    [Fact]
    public void FullName_ReturnsExpectedFormat()
    {
        Person person = new Person("Dang", "Nguyen", 20);

        string result = person.FullName();

        Assert.Equal("Nguyen, Dang", result);
    }

    [Fact]
    public void IsAdult_ReturnsTrue_WhenAge18OrMore()
    {
        Person person = new Person("Dang", "Nguyen", 20);

        bool result = person.IsAdult();

        Assert.True(result);
    }
}