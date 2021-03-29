using NumberProcessor.Models;

namespace NumberProcessor.Core
{
    public interface IStackOperation
    {
        string StackOperator { get; }
        void Operate(Stack<int> stack);
    }
}