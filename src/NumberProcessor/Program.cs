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
            Console.WriteLine("Welcome. Please Enter the data to be processed along with the opertions in below format:");
            Console.WriteLine("format example: \"5 10 15 DUP - + POP\"");
            string shouldContinue = "Y";
            while (shouldContinue.Equals("N", StringComparison.OrdinalIgnoreCase) == false)
            {
                Console.Write("Input:");
                var input = Console.ReadLine();
                var output = Processor.Process(input);
                Console.WriteLine($"output:{output}");
                Console.WriteLine("Want to test another input?. Please Press \"N\" to exit.\"");
                shouldContinue = Console.ReadLine().Trim();
            }
        }
    }
}
