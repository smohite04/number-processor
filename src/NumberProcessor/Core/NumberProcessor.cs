using NumberProcessor.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NumberProcessor.Core
{
    public class NumberProcessor
    {
        public int Process(IEnumerable<int> numbers, IEnumerable<string> operators)
        {
            try
            {
                var stack = numbers.ToDataStack();
                var stackOperations = operators.ToOperations();
                foreach (var stackOperator in stackOperations)
                {
                    stackOperator.Operate(stack);
                }
                return stack.Peek();
            }
            catch (InvalidOperationException ex)
            {
                //TODO: filebased logging
                return -1;
            }
        }
    }
}
