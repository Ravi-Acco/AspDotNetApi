using System.ServiceModel;

namespace SOAP.Model
{
    public class CalServiceContract
    {
        [ServiceContract]
        public interface IOperations
        {
            [OperationContract]
            double SUM(double a, double b);
            [OperationContract]
            double SUB(double a, double b);
            [OperationContract]
            double DIV(double a, double b);
            [OperationContract]
            double MUL(double a, double b);
        }
    }
}
