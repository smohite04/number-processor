using System.Collections.Generic;

namespace NumberProcessor.Core.Models
{
    public class LinkedListBasedStack<T> : Stack<T>
    {
        private SingleAccessLinkedList<T> _data { get; } = new SingleAccessLinkedList<T>();

        private Node<T> _top => _data.Tail;
        public override int Count => _data.Count;

        public override bool IsEmpty => Count == 0;
        public LinkedListBasedStack()
        {

        }

        public LinkedListBasedStack(IEnumerable<T> data) : base(data)
        {
            _data = new SingleAccessLinkedList<T>(data);
        }

        public override T Peek()
        {
            if (IsEmpty == true)
                throw new StackEmptyException();

            return _top.Data;
        }

        public override T Pop()
        {
            if (IsEmpty == true)
                throw new StackEmptyException();

            return _data.RemoveLast();
        }

        public override void Push(T data)
        {
            _data.AddLast(data);
        }
    }
}
