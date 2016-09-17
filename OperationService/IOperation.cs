using System.ServiceModel;

namespace OperationService
{
    [ServiceContract]
    public interface IOperation
    {   
        [OperationContract]
        double Operation(double a, double b);
    }
}
