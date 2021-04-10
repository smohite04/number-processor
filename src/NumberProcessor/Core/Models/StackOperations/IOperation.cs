using NumberProcessor.Models;

namespace NumberProcessor.Core
{
    public interface IOperation
    {
        string Operation { get; }
        Stack<int> Operate(Stack<int> stack);
    }
}