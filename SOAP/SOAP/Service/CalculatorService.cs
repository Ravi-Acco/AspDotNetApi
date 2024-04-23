using static SOAP.Model.CalServiceContract;

namespace SOAP.Service
{
    public class CalculatorService : IOperations
    {
        public double SUM(double a, double b)
        {
            return a + b;
        }
        public double SUB(double a, double b)
        {
            return a - b;
        }
        public double DIV(double a, double b)
        {
            return a / b;
        }
        public double MUL(double a, double b)
        {
            return a * b;
        }
    }
}
