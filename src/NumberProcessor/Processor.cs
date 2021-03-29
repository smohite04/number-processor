using System;
using System.Collections.Generic;
using System.Text;

namespace NumberProcessor
{
    public class Processor
    {
        public static int Process(string input)
        {
            try
            {
                var data = input.ToData();
                return data.ProcessNumbers();
            }
            catch (InvalidOperationException ex)
            {
                //TODO: log exceptions
                return -1;
            }
            
        }
    }
}
