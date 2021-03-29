using NumberProcessor.Core;
using System.Collections.Generic;

namespace NumberProcessor
{
    internal static class ProcessExtensions
    {
        internal static int PerformOperations(this (IEnumerable<int> numbersToBeProcessed, IEnumerable<string> operationsToBePerformed) data)
        {
                var stack = data.numbersToBeProcessed.ToDataStack();
                var stackOperations = data.operationsToBePerformed.ToOperations();
                foreach (var stackOperator in stackOperations)
                {
                    stackOperator.Operate(stack);
                }
                return stack.Peek();
        }
    }
}
