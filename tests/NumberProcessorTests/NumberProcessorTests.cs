using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using NumberProcessor.Core;
using FluentAssertions;

namespace NumberProcessorTests
{
    public class NumberProcessorTests
    {
        [Theory]
        [MemberData(nameof(Data))]
        public void Operate_Should_Return_Valid_Output_When_Valid_Data_Is_Provided_For_Processing(List<int> values, List<string> operations, int expectedOutcome)
        {
            var processor = new NumberProcessor.Core.NumberProcessor();
            var outcome = processor.Process(values, operations);
            outcome.Should().Be(expectedOutcome);

        }
        public static IEnumerable<object[]> Data()
        {
            return new object[][] {
                new object[]{ new List<int> { 0,0,0,0,-1}, new List<string> {"DUP"} , -1},
                new object[]{ new List<int> { 100},new List<string>(), 100},
                new object[]{ new List<int>(), new List<string> { "DUP"}, -1 },
                new object[]{ new List<int>(), new List<string> { "ERR"}, -1 }
            };
        }
    }
}
