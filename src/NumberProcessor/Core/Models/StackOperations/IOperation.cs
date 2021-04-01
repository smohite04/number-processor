using NumberProcessor.Models;

namespace NumberProcessor.Core
{
    public interface IOperation
    {
        string Operation { get; }
        void Operate(Stack<int> stack);
    }
}