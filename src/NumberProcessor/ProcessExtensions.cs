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
                foreach (var stackOperation in stackOperations)
                {
                    stackOperation.Operate(stack);
                }
                return stack.Peek();
        }
    }
}
