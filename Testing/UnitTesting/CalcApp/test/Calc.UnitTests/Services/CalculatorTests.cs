using Calc.Services;

namespace Calc.UnitTests.Services;

public class CalculatorTests
{
    private readonly Calculator calculator;
    public CalculatorTests()
    {
        this.calculator = new Calculator();
    }

    [Fact]
    public void Plus_CorrectParameters_ReturnsPlusResult()
    {
        decimal num1 = 10, num2 = 5;
        const decimal plusCurrectResult = 15;

        var result = calculator.Plus(num1, num2);

        Assert.Equal(plusCurrectResult, result);

        // if(result != plusCurrectResult) {
        //     throw new Exception($"Expected value: {plusCurrectResult}, Actual value: {result}");
        // }
    }

    [Fact]
    public void Minus_CorrectParameters_ReturnsMinusResult() {
        double num1 = 10, num2 = 5;
        const double minusCurrectResult = 5;

        var result = calculator.Minus(num1, num2);

        Assert.Equal(minusCurrectResult, result);
    }

    [Fact]
    public void Minus_ParametersContainAtLeastOneNull_ReturnsZero() {
        double? num1 = null, num2 = 5;
        const double minusCurrectResult = 0;

        var result = calculator.Minus(num1, num2);

        Assert.Equal(minusCurrectResult, result);
    }

    /*
    [Fact]
    public void Minus_SetNullables_ReturnsCorrectValue() {
        decimal?[,] testValues = {
            {10, 5, 5},
            {null, 5 ,0}
        };

        for (int i = 0; i < testValues.GetLength(0); i++)
        {
            var result = new Calculator().Minus(testValues[i,0], testValues[i,1]);
            Assert.Equal(testValues[i,2], result);
        }
    }
    */

    [Theory]
    [InlineData(null, 10.0, 0.0)]
    [InlineData(5.7, null, 0.0)]
    public void Minus_SetNullables_ReturnsCorrectValue(double? num1, double? num2, double expectedResult) {
        var result = calculator.Minus(num1, num2);
        Assert.Equal(expectedResult, result);
    }

    /*
    [Theory]
    [InlineData(10.5, 0.0)]
    [InlineData(5.7, null)]
    public void Divide_SecondParameterIsNullOrZero_ReturnsZero(double? num1, double? num2) {
        var result = new Calculator().Divide(num1, num2);

        Assert.Equal(0, result);
    }
    */

    [Fact]
    public void Divide_SecondParameterIsNullOrZero_ThrowsArgumentException() {
        Assert.Throws<ArgumentException>(() => {
            calculator.Divide(10, null);
        });
    }
}
