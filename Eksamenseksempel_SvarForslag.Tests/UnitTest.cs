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
    
    // Del 3, oppgave 5
    [Fact]
    public void Test_Discounted_Price()
    {
        Product p = new Product("Test Product", 100);
        var result = p.GetDiscountedPrice(40);
        Assert.Equal(60, result);
    }
}