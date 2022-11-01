using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utils
{
    public static class RandomExtensions
    {
        public static double NextDouble(this Random RandGenerator, double MinValue, double MaxValue)
        {
            return RandGenerator.NextDouble() * (MaxValue - MinValue) + MinValue;
        }
    }
}
