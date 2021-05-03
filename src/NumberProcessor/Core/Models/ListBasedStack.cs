using System;
using System.Collections.Generic;
using System.Linq;

namespace NumberProcessor.Models
{
    public class ListBasedStack<T> : Stack<T>, IEquatable<ListBasedStack<T>>
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

        public override Stack<T> Clone()
        {
            return new ListBasedStack<T>(_data);
        }
        public override IEnumerable<T> GetAllElements()
        {
            return _data;
        }
        public override bool Equals(object obj)
        {
            return Equals(obj as ListBasedStack<T>);
        }

        public bool Equals(ListBasedStack<T> other)
        {
            if (other == null || other.Count != this.Count)
                return false;

            var otherData = other.GetAllElements().ToList();
            for (var index = 0; index < this.Count; index++)
            {
                if (_data[index].Equals(otherData[index]) == false)
                {
                    return false;
                }
            }
            return true;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_data);
        }
        

        public static bool operator ==(ListBasedStack<T> stack1, ListBasedStack<T> stack2)
        {
            return EqualityComparer<ListBasedStack<T>>.Default.Equals(stack1, stack2);
        }

        public static bool operator !=(ListBasedStack<T> stack1, ListBasedStack<T> stack2)
        {
            return !(stack1 == stack2);
        }
    }
}
