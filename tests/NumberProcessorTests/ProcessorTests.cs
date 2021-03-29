using FluentAssertions;
using NumberProcessor;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace NumberProcessorTests
{
    public class ProcessorTests
    {
        [Theory]
        [MemberData(nameof(Data))]
        public void ToData_Should_Return_Valid_Distribution_Of_Numbers_And_Operations_When_Valid_Input_Is_Provided_For_Processing( string input, int expecetdOutput)
        {
            var output = Processor.Process(input);

            output.Should().Be(expecetdOutput);
        }
        public static IEnumerable<object[]> Data()
        {
            return new object[][] {               
                new object[]{"13 7 20 DUP - +", 7},
                new object[]{"12 - +", -1},
                new object[]{"DUP", -1},
                new object[]{"0 DUP POP DUP POP DUP -", 0},
            };
        }
    }
}
