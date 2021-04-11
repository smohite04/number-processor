using System.Collections.Generic;
using System.Linq;

namespace NumberProcessor.Core.Models
{
    public class ListBasedStack<T> : Stack<T>
    {
        private List<T> _data { get; } = new List<T>();
        
        private int _topIndex = - 1;
        public override int Count =>  _data.Count;

        public override bool IsEmpty => (Count == 0);
        public ListBasedStack()
        {
        }
        public ListBasedStack(IEnumerable<T> data) : base(data)
        {
            _data = data.ToList();
            _topIndex = _data.Count - 1;
        }

        public override T Peek()
        {
            if (IsEmpty == true)
                throw new StackEmptyException();

            return _data[_topIndex];
        }

        public override T Pop()
        {
            if (IsEmpty == true)
                throw new StackEmptyException();

            var topData = _data[_topIndex];
            _data.RemoveAt(_topIndex);
            _topIndex--;
            return topData;
        }

        public override void Push(T data)
        {
            _data.Add(data);
            _topIndex++;
        }       
    }
}
