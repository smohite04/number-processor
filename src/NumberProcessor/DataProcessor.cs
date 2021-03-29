using NumberProcessor.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NumberProcessor
{
    public static class DataProcessor
    {
        public static int ProcessNumbers(this (IEnumerable<int> Numbers, IEnumerable<string> Operations) data)
        {
                var stack = data.Numbers.ToDataStack();
                var stackOperations = data.Operations.ToOperations();
                foreach (var stackOperator in stackOperations)
                {
                    stackOperator.Operate(stack);
                }
                return stack.Peek();
        }
    }
}
