﻿using NumberProcessor.Models;
using System;

namespace NumberProcessor.Core
{
    /// <summary>
    /// Subtract operation with sign "-", takes top two elements, subtracts them and pushes back to stack.
    /// It is expected that stack must have atleast 2 elements in it and top element should be greater than or equal to one below it.
    /// </summary>
    public class SubstractOperation : IOperation
    {
        public string Operation => Constants.Operations.Subtract;

        public Stack<int> Operate(Stack<int> stack)
        {
            if (stack.Count < 2)
            {
                throw new InvalidOperationException($"At least two element must exist in stack to perform \"{Operation}\" operation.");
            }
            var output = stack.Clone();
            var firstElement = output.Pop();
            var secondElement = output.Pop();

            if (firstElement < secondElement)
                throw new InvalidOperationException($"The top element must be greater than element below it in stack to perform \"{Operation}\" operation.");

            output.Push(firstElement - secondElement);
            return output;
        }
    }
}