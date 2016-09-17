using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace OperationService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SubtractOperation" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select SubtractOperation.svc or SubtractOperation.svc.cs at the Solution Explorer and start debugging.
    public class SubtractOperation : IOperation
    {
        public double Operation(double a, double b) {
            return a - b;
        }

        
    }
}
