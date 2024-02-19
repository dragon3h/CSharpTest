namespace CSharpTest.Tests;

public class StringServiceTest
{
    // TODO 15: Add a test for the Reverse method (at least 3 tests)
    [Theory]
    [InlineData("Welcome to Interfacing", "")]
    [InlineData("String Manipulation", "")]
    public void Reverse(string input, string output)
    {
        //Act

        //Assert
        //Assert.Equal(output, result);
    }
}