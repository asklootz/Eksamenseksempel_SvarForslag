namespace Eksamenseksempel_SvarForslag.Tests;

public class UnitTest
{

    // Del 1, oppgave 17
    [Fact]
    public void Add_TwoNumbers_ReturnsCorrectSum()
    {
        Calculator c = new Calculator();
        int result = c.Add(2, 3);
        Assert.Equal(5, result);
    }
}