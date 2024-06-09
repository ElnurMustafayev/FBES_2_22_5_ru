namespace Calc.Services;

public class Calculator : ICalculator
{
    public decimal Plus(decimal num1, decimal num2)
    {
        return num1 + num2;
    }

    public double Minus(double? num1, double? num2)
    {
        // return num1.GetValueOrDefault(0) - num2.GetValueOrDefault(0);

        if(num1 == null || num2 == null) {
            return 0;
        }

        return (double)num1 - (double)num2;
    }

    public double Divide(double? num1, double? num2)
    {
        if(num2 == null || num2.Value == 0) {
            throw new ArgumentException("The second operand can not be zero!");
        }

        return num1.GetValueOrDefault(0) / num2.Value;
    }
}