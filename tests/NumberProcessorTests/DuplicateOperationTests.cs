using FluentAssertions;
using NumberProcessor.Core;
using NumberProcessor.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace NumberProcessorTests
{
    public class DuplicateOperationTests
    {
        [Fact]
        public void Operate_Should_Duplicate_Top_Element_On_Stack_And_Return_Updated_stack_When_Valid_Input_Is_Provided()
        {
            var data = new List<int> { 7, 10, 10 };
            var inputStack = new ListBasedStack<int>(data);
            var duplicateOperation = new DuplicateOperation();
            var output = duplicateOperation.Operate(inputStack);
            output.Count.Should().Be(4);
            output.Peek().Should().Be(10);
            output.Pop();
            var isEqual = output.Equals(inputStack);
            isEqual.Should().BeTrue();
            //to ensure the input is not mutated.
            data.Count.Should().Be(3);
        }
        [Fact]
        public void Operate_Should_Throw_InvalidOperationExcpetion_When_InValid_Input_Is_Provided()
        {
            var data = new List<int>();
            var inputStack = new ListBasedStack<int>(data);
            var duplicateOperation = new DuplicateOperation();
            Func<NumberProcessor.Models.Stack<int>> response = 
                    ()=> duplicateOperation.Operate(inputStack);
            response.Should().Throw<InvalidOperationException>();            
        }
    }
}
