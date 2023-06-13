using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureCalculator.Exceptions
{
    public class BelowZeroException : Exception
    {
        public double Value { get; }
        public BelowZeroException(string message, double value )  : base(message)
        {
            Value = value;
        }
    }
}
