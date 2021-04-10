using NumberProcessor.Models;
using System;

namespace NumberProcessor.Core
{
    /// <summary>
    /// Duplicate operation, duplicates the top element in stack.
    /// If stack is empty, when duplication is requested, the operation should fail.
    /// </summary>
    public class AddOperation : IOperation
    {
        public string Operation => Constants.Operations.Add;

        public Stack<int> Operate(Stack<int> stack)
        {          
            if (stack.Count<2)
            {
                throw new InvalidOperationException($"At least two element must exist in stack to perform \"{Operation}\" operation.");
            }
            var output = stack.Clone();
            var firstElement = output.Pop();
            var secondElement = output.Pop();
            output.Push(firstElement + secondElement);
            return output;
        }
    }
}