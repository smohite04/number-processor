namespace NumberProcessor.Core
{
    /// <summary>
    /// POP operation, removes the top element in stack.
    /// </summary>
    public class PopOperation : IOperation
    {
        public string Operation => Constants.Operations.Pop;

        public void Operate(Models.Stack<int> stack)
        {
            stack.Pop();
        }

    }
}
