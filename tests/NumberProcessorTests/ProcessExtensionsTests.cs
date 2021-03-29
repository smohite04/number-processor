using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using NumberProcessor;
using FluentAssertions;

namespace NumberProcessorTests
{
    public class ProcessExtensionsTests
    {
        [Theory]
        [MemberData(nameof(Data))]
        public void Operate_Should_Return_Valid_Output_When_Valid_Data_Is_Provided_For_Processing(List<int> values, List<string> operations, int expectedOutcome)
        {
            var data = (values, operations);
            var outcome = data.PerformOperations();
            outcome.Should().Be(expectedOutcome);

        }
        [Theory]
        [MemberData(nameof(InvalidData))]
        public void Operate_Should_Throw_Exception_When_InValid_Data_Is_Provided_For_Processing(List<int> values, List<string> operations)
        {
            var data = (values, operations);
            Func<int> func = () => data.PerformOperations();
            func.Should().Throw<InvalidOperationException>();
        }
        public static IEnumerable<object[]> Data()
        {
            return new object[][] {
                new object[]{ new List<int> { 0,0,0,0,-1}, new List<string> {"DUP", "POP"} , -1},
                new object[]{ new List<int> { 100},new List<string>(), 100},
                new object[]{ new List<int> { 13,7,20}, new List<string> {"DUP", "-","+"} , 7},
            };
        }
        public static IEnumerable<object[]> InvalidData()
        {
            return new object[][] {
                new object[]{ new List<int>(), new List<string> { "DUP"} },
                new object[]{ new List<int>(), new List<string> { "ERR"} }
            };
        }
    }
}
