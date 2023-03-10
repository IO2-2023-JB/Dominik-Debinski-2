namespace UnitTests;

using StringCalculator;

public class Tests
{
    private StringCalculator _calculator;
    
    [SetUp]
    public void Setup()
    {
        _calculator = new StringCalculator();
    }

    [Test]
    public void TestEmptyString()
    {
        Assert.True(_calculator.Calculate("") == 0);
    }

    [Test]
    public void TestTwoCommaSeparatedNumbers()
    {
        Assert.True(_calculator.Calculate("1, 2") == 3);
    }
    
    [Test]
    public void TestMultipleCommaSeparatedNumbers()
    {
        Assert.True(_calculator.Calculate("1, 2, 3, 1") == 7);
    }

    [Test]
    public void TestInputWithNegativeValue()
    {
        Assert.Throws<ArgumentException>(() => _calculator.Calculate("1, -2, -3, 1"));
    }

    [Test]
    public void TestInputWithNewLineSymbols()
    {
        Assert.True(_calculator.Calculate("1, 2 \r\n 3 \r\n 1, 3") == 10);
    }
}