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
            Console.WriteLine("Hello World!");
            var a = new List<string>();
            a.Add("1");
            a.Add("2");
            Console.WriteLine(a[1]);
            Process process = Process.GetCurrentProcess();
            long used = process.PrivateMemorySize64;
            Console.WriteLine(used);
            var x = "13 7 20 DUP + -";
            var data = new StringBuilder();


        }
    }
}
