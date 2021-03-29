using System;
using System.Collections.Generic;
using System.Text;

namespace NumberProcessor
{
    public static class Ensure
    {
        public static void EnsureDataValid<T>(this IEnumerable<T> data)
        {
            if (data == null)
                throw new InvalidOperationException("Stack can not be initialized with null collection.");
        }
    }
}
