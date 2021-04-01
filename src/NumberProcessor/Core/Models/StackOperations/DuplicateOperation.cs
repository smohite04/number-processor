using NumberProcessor.Models;
using System;

namespace NumberProcessor.Core
{
    /// <summary>
    /// Duplicate operation, duplicates the top element in stack.
    /// If stack is empty, when duplication is requested, the operation should fail.
    /// </summary>
    public class DuplicateOperation : IOperation
    {
        public string Operation => Constants.Operations.Duplicate;

        public void Operate(Stack<int> stack)
        {
            if (stack.IsEmpty == true)
            {
                throw new InvalidOperationException($"At least one element must exist in stack to perform \"{Operation}\" operation.");
            }

            var data = stack.Peek();
            stack.Push(data);
        }
    }
}