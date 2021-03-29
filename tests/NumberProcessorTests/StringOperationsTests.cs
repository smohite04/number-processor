using FluentAssertions;
using NumberProcessor;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace NumberProcessorTests
{
    public class StringOperationsTests
    {
        [Theory]
        [MemberData(nameof(Data))]
        public void ToData_Should_Return_Valid_Distribution_Of_Numbers_And_Operations_When_Valid_Input_Is_Provided_For_Processing( List<int> values, List<string> operations, string input)
        {
            var (Numbers, Operations) = input.ToData();

            Numbers.Should().Contain(values);

            if(operations.Count>0)
            Operations.Should().Contain(operations);
        }
        public static IEnumerable<object[]> Data()
        {
            return new object[][] {
                new object[]{ new List<int> { 0,0,0,0,-1}, new List<string> {"DUP", "POP"}, "0 0 0 0 -1 DUP POP"},
                new object[]{ new List<int> { 100},new List<string>(), "100"},
                new object[]{ new List<int> { 13,7,20}, new List<string> {"DUP", "-","+"} , "13 7 20 DUP - +"},
            };
        }
    }
}
