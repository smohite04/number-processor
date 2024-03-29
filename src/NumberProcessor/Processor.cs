﻿using System;
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
                return data.PerformOperations();
            }
            catch (InvalidOperationException ex)
            {
                return -1;
            }            
        }
    }
}
