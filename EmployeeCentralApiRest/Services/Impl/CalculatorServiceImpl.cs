namespace EmployeeCentralApiRest.Services.Impl
{
    public class CalculatorServiceImpl : ICalculatorService
    {
        public double CalculatePercentage(double number, double percentage)
        {
            return (number * percentage) / 100;
        }
    }
}

