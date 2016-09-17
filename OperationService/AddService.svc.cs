namespace OperationService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AddService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select AddService.svc or AddService.svc.cs at the Solution Explorer and start debugging.
    public class AddService : IOperation
    {
       
        public double Operation(double a, double b)
        {
            return a + b;
        }
    }
}
