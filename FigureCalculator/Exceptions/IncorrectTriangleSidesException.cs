using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureCalculator.Exceptions
{
    public class IncorrectTriangleSidesException : Exception
    {
        public IncorrectTriangleSidesException(string message) : base(message) { }
    }

}
