using System;
using System.Collections.Generic;
using System.Text;
using NumberProcessor.Core.Models;

namespace NumberProcessor.Core
{
    public static class Extension
    {
        public static IEnumerable<IOperation> ToOperations(this IEnumerable<string> operations)
        {
            var stackOperations = new List<IOperation>();
            foreach (var operation in operations)
            {                
                var stackOperation = OperationFactory.Create(operation);
                stackOperations.Add(stackOperation);
            }
            return stackOperations;
        }
        public static Models.Stack<int> ToDataStack(this IEnumerable<int> data)
        {
            // return new ListBasedStack<int>(data);
            return new LinkedListBasedStack<int>(data);
        }
    }
}
