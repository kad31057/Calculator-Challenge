using NUnit.Framework;

[TestFixture]
public class CalculatorTests
{
    private Calculator _calculator;

    [SetUp]
    public void Setup()
    {
        _calculator = new Calculator();
    }

    [Test]
    public void Add_EmptyString_ReturnsZero()
    {
        Assert.AreEqual(0, _calculator.Add(""));
    }

    [Test]
    public void Add_SingleNumber_ReturnsNumber()
    {
        Assert.AreEqual(20, _calculator.Add("20"));
    }

    [Test]
    public void Add_TwoNumbers_ReturnsSum()
    {
        Assert.AreEqual(1, _calculator.Add("1,5000"));
    }

    [Test]
    public void Add_InvalidNumbers_ReturnsSumWithInvalidAsZero()
    {
        Assert.AreEqual(5, _calculator.Add("5,tytyt"));
    }

    [Test]
    public void Add_MultipleNumbers_ReturnsSum()
    {
        Assert.AreEqual(78, _calculator.Add("1,2,3,4,5,6,7,8,9,10,11,12"));
    }

    [Test]
    public void Add_NegativeNumbers_ThrowsException()
    {
        var ex = Assert.Throws<ArgumentException>(() => _calculator.Add("1,-2,3,-4"));
        Assert.IsTrue(ex.Message.Contains("Negatives not allowed: -2, -4"));
    }

    [Test]
    public void Add_NumbersGreaterThan1000_IgnoresLargeNumbers()
    {
        Assert.AreEqual(8, _calculator.Add("2,1001,6"));
    }

    [Test]
    public void Add_CustomSingleCharacterDelimiter_ReturnsSum()
    {
        Assert.AreEqual(7, _calculator.Add("//#\n2#5"));
    }

    [Test]
    public void Add_CustomMultipleCharacterDelimiter_ReturnsSum()
    {
        Assert.AreEqual(66, _calculator.Add("//[***]\n11***22***33"));
    }

    [Test]
    public void Add_MultipleDelimitersOfAnyLength_ReturnsSum()
    {
        Assert.AreEqual(110, _calculator.Add("//[*][!!][r9r]\n11r9r22*hh*33!!44"));
    }
}
