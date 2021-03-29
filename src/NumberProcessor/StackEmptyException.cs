using System;
using System.Collections.Generic;
using System.Text;

namespace NumberProcessor
{
    public class StackEmptyException : InvalidOperationException
    {
        public StackEmptyException() : base("Stack is empty.")
        {
        }
    }
}
