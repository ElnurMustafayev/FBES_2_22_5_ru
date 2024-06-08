using Calc.Services;

namespace Calc.UnitTests.Services;

public class CalculatorTests
{
    [Fact]
    public void Plus_CorrectParameters_ReturnsPlusResult()
    {
        decimal num1 = 10, num2 = 5;
        const decimal plusCurrectResult = 15;

        var result = Calculator.Plus(num1, num2);

        Assert.Equal(plusCurrectResult, result);

        // if(result != plusCurrectResult) {
        //     throw new Exception($"Expected value: {plusCurrectResult}, Actual value: {result}");
        // }
    }

    //[Fact]
    //Plus_CorrectParameters_ReturnsMinusResult();
}