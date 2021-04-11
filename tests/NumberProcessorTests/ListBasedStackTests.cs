using FluentAssertions;
using NumberProcessor;
using NumberProcessor.Core.Models;
using System;
using System.Collections.Generic;
using Xunit;

namespace NumberProcessorTests
{
    public class ListBasedStackTests
    {
        [Fact]
        public void Stack_Creation_Should_Throw_Exception_When_Collection_Is_Null()
        {
            Func<NumberProcessor.Core.Models.Stack<int>> func =  ()=> new ListBasedStack<int>(null);
            func.Should().NotBeNull();
            func.Should().Throw<InvalidOperationException>().WithMessage("Stack can not be initialized with null collection.");
        }
        [Fact]
        public void Stack_Peek_Should_Throw_Exception_When_Stack_Is_Empty()
        {
            var data = new ListBasedStack<int>(new List<int>());
            Func<int> func = () => data.Peek();
            func.Should().Throw<StackEmptyException>().WithMessage("Stack is empty.");
        }
        [Fact]
        public void Stack_Peek_Should_Return_Top_Element_When_Data_Exists()
        {
            var values = new List<int>() { 2,4,5,6,4,1,3 };
            var data = new ListBasedStack<int>(values);
            var top = data.Peek();
            top.Should().Be(3);
        }
        [Theory]
        [MemberData(nameof(PeekData))]
        public void Stack_Pop_Should_Remove_And_Return_Top_Element_When_Data_Exists(List<int> values, int expectedTop, int expectedCount)
        {
            var data = new ListBasedStack<int>(values);
            var top = data.Pop();
            top.Should().Be(expectedTop);
            data.Count.Should().Be(expectedCount);
        }
        [Fact]
        public void Stack_Pop_Should_Throw_Exception_When_Stack_Is_Empty()
        {
            var data = new ListBasedStack<int>(new List<int>());
            Func<int> func = () => data.Pop();
            func.Should().Throw<StackEmptyException>().WithMessage("Stack is empty.");
        }
        [Theory]
        [MemberData(nameof(Data))]     
        public void Stack_Push_Should_Store_At_Top_When_Valid_Data_Is_Provided(List<int> values, int value, int expectedCount, int expectedTop)
        {           
            var data = new ListBasedStack<int>(values);
             data.Push(value);
            data.Count.Should().Be(expectedCount);
            data.Peek().Should().Be(expectedTop);
        }

        public static IEnumerable<object[]> Data()
        {
            return new object[][] {
                new object[]{ new List<int>(),3,1,3},
                 new object[]{ new List<int> { 2,3,4,1,0,0,1},-1,8,-1},
            };
        }
        public static IEnumerable<object[]> PeekData()
        {
            return new object[][] {
                new object[]{ new List<int> { 0,0,0,0,-1},-1,4},
                new object[]{ new List<int> { 100},100,0},
                 new object[]{ new List<int> { 2,3,4,1,0,0,1,-1},-1,7},
            };
        }
    }
}
