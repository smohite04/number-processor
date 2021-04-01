using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace NumberProcessor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Welcome. Please Enter the numbers to be processed followed by the opertions.{Environment.NewLine}Supported Operations are DUP POP - +.{Environment.NewLine}Please refer format example given below.");
            Console.WriteLine("format example: \"5 10 15 DUP - + POP\"");
            string shouldContinue = "Y";
            while (shouldContinue.Equals("N", StringComparison.OrdinalIgnoreCase) == false)
            {
                Console.Write("Input:");
                var input = Console.ReadLine();
                var output = Processor.Process(input);
                Console.WriteLine($"output:{output}");
                Console.WriteLine("Want to check another input?. Please Press \"N\" to exit.\"");
                shouldContinue = Console.ReadLine().Trim();
            }
        }
    }
}
