using FigureCalculator.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureCalculator.Tests
{
    public class CircleTests
    {
        [Test]
        public void CalculatingSquare()
        {
            double radius = 5;
            Circle circle = new Circle(radius);
            double expectedValue = Math.Round(Math.PI * Math.Pow(radius, 2), 3);

            var square = circle.SquareCalculate();

            Assert.AreEqual((square - expectedValue), 0);
        }
    }
}
