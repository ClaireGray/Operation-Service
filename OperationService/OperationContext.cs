using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OperationService
{
    public static class OperationContext
    {
        private static Dictionary<OperationType, IOperation> _context;

        static OperationContext()
        {
            _context = new Dictionary<OperationType, IOperation>();
            _context.Add(OperationType.Add, new AddService());
            _context.Add(OperationType.Multiply, new Multiply());
            _context.Add(OperationType.Subtract, new SubtractOperation());
        }
        public static double DoOperation(double a, double b, OperationType type) {
            return _context[type].Operation(a, b);
        }
    }

    public enum OperationType
    {
        Add,
        Subtract,
        Multiply
    }
}