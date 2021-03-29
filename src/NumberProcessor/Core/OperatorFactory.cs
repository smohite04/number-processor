using System;
using System.Collections.Generic;

namespace NumberProcessor.Core
{
    internal class OperatorFactory
    {
        private static readonly Dictionary<string, IStackOperation> _operations = new Dictionary<string, IStackOperation>() {
            {"DUP", new DuplicateStackOperation() },
            {"POP", new PopStackOperation() },
             {"+", new AdditionStackOperation() },
              {"-", new SubstractionStackOperation() },
        };
        internal static IStackOperation Create(string operation)
        {
            var key = operation.ToUpper();
            if (_operations.ContainsKey(key) == false)
                throw new InvalidOperationException($"Operation :\"{key}\" is not supported by the system.");
            return _operations[key];
        }
    }
}