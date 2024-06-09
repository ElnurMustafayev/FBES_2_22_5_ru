namespace Calc.Services
{
    public interface ICalculator
    {
        public decimal Plus(decimal num1, decimal num2);
        public double Minus(double? num1, double? num2);
        public double Divide(double? num1, double? num2);
    }
}