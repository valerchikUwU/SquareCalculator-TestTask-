using FigureCalculator.Contracts;
using FigureCalculator.Exceptions;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureCalculator.Models
{
    public class Circle : Figure
    {

        public double Radius { get; }

        public Circle(double radius)
        {
            if (radius < 0)
                throw new BelowZeroException("Радиус не может быть меньше 0", radius);
            Radius = radius;
        }
        public override double SquareCalculate()
        {
            return Math.Round(Math.PI * Math.Pow(Radius, 2d), 3);
        }
    }
}
