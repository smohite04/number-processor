using NumberProcessor.Models;

namespace NumberProcessor.Core
{
    /// <summary>
    /// POP operation, removes the top element in stack.
    /// </summary>
    public class PopOperation : IOperation
    {
        public string Operation => Constants.Operations.Pop;

        public Stack<int> Operate(Stack<int> stack)
        {
            var output = stack.Clone();
            output.Pop();
            return output;
        }

    }
}
