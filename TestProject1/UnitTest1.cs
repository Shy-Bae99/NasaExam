using Xunit;

public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }
}


public class CalculatorTests
{
    [Fact] // Marks this method as a test method
    public void Add_WhenCalled_ReturnsSum()
    {
        // Arrange
        var calculator = new Calculator();

        // Act
        var result = calculator.Add(2, 3);

        // Assert
        Assert.Equal(5, result); // Asserts that the result is 5
    }
}
