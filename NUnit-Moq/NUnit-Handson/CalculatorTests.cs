using NUnit.Framework;

[TestFixture]
public class CalculatorTests
{
    private Calculator calculator;

    [SetUp]
    public void Setup()
    {
        calculator = new Calculator();
    }

    [TestCase(2, 3, 5)]
    [TestCase(10, 20, 30)]
    [TestCase(5, 7, 12)]
    public void Add_ReturnsExpectedResult(int a, int b, int expected)
    {
        Assert.That(calculator.Add(a, b), Is.EqualTo(expected));
    }
}