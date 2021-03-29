using System;
using System.Collections.Generic;
using System.Text;

namespace NumberProcessor.Models
{
    public abstract class Stack<T>
    {     
        protected Stack()
        {
        }
        protected Stack(IEnumerable<T> data)
        {
            data.EnsureDataValid();
        }
        public abstract int Count { get; }
        public abstract void Push(T data);
        public abstract T Pop();
        public abstract T Peek();
        public abstract bool IsEmpty { get; }
    }
}
