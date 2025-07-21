namespace Aspire.Demo.CoreWCFService;

[ServiceContract]
public interface ICalculator
{
    [OperationContract]
    long Multiply(int value, int value2);

    [OperationContract]
    int Subtract(int value, int value2);

    [OperationContract]
    double Divide(int value, int value2);

    [OperationContract]
    int Add(int value, int value2);

    public class Calculator : ICalculator
    {
        public long Multiply(int value, int value2)
        {
            return (long)value * value2;
        }

        public int Subtract(int value, int value2)
        {
            return value - value2;
        }

        public double Divide(int value, int value2)
        {
            if (value2 == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }

            return (double)value / value2;
        }

        public int Add(int value, int value2)
        {
            return value + value2;
        }
    }
}