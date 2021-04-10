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
                Models.Stack<int> outputStack = stack.Clone();
                foreach (var stackOperation in stackOperations)
                {
                    outputStack = stackOperation.Operate(outputStack);
                }
                return outputStack.Peek();
        }
    }
}
