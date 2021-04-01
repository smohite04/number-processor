using System;
using System.Collections.Generic;

namespace NumberProcessor.Core
{
    internal class OperationFactory
    {
        private static readonly Dictionary<string, IOperation> _operations = new Dictionary<string, IOperation>() {
            {Constants.Operations.Duplicate , new DuplicateOperation() },
            {Constants.Operations.Pop , new PopOperation() },
            {Constants.Operations.Add, new AddOperation() },
            {Constants.Operations.Subtract, new SubstractOperation() },
        };
        internal static IOperation Create(string operation)
        {
            var key = operation.ToUpper();

            if (_operations.ContainsKey(key) == false)
                throw new InvalidOperationException($"Operation :\"{key}\" is not supported by the system.");

            return _operations[key];
        }
    }
}