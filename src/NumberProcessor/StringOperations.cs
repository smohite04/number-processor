using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumberProcessor
{
    internal static class StringOperations
    {
        /// <summary>
        /// The input string is in the format "5 10 15 DUP +".
        /// we need to separate the numbers and operations.
        /// NOTE: All operators will be in the end of string.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        internal static (IEnumerable<int> Numbers, IEnumerable<string> Operations) ToData(this string input)
        {
            if (string.IsNullOrEmpty(input) == true)
                throw new InvalidOperationException("Input can be empty.");

            var allValues = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            var numbers = GetAllNumbers(allValues);

            var operations = allValues.TakeLast(allValues.Length - numbers.Count);

            return (numbers, operations);
        }

        private static List<int> GetAllNumbers(string[] values)
        {
            var numbers = new List<int>();
            for (var i = 0; i < values.Length; i++)
            {
                if (int.TryParse(values[i], out int number) == false)
                {
                    break;
                }
                else
                {
                    numbers.Add(number);
                }
            }

            return numbers;
        }
    }
}
