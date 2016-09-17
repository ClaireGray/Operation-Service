using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace OperationService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Multiply" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Multiply.svc or Multiply.svc.cs at the Solution Explorer and start debugging.
    public class Multiply : IOperation
    {
        public double Operation(double a, double b)
        {
            return a * b;
        }
    }


}
