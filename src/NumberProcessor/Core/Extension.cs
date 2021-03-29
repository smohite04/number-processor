using System;
using System.Collections.Generic;
using System.Text;
using NumberProcessor.Models;

namespace NumberProcessor.Core
{
    public static class Extension
    {
        public static IEnumerable<IStackOperation> ToOperations(this IEnumerable<string> stackOperators)
        {
            var operations = new List<IStackOperation>();
            foreach (var stackOperator in stackOperators)
            {                
                var operation = OperatorFactory.Create(stackOperator);
                operations.Add(operation);
            }
            return operations;
        }
        public static Models.Stack<int> ToDataStack(this IEnumerable<int> data)
        {
            //TODO : for multiple stack implementation can introduce factory
            return new ListBasedStack<int>(data);
        }
    }
}
