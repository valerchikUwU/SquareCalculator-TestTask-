using FigureCalculator.Exceptions;
using FigureCalculator.Models;
using Microsoft.VisualBasic;
using NUnit.Framework;

namespace FigureCalculator.Tests
{
    public class TriangleTest
    {

       

        [TestCase(3,4,5, ExpectedResult = true)]
        [TestCase(3,4,6, ExpectedResult = false)]
        [TestCase(3,4,5.00001, ExpectedResult = false)]
        public bool Init_IsRight_AND_NotRight(double firstSide, double secondSide, double thirdSide)
        {
            Triangle triangle = new Triangle(firstSide, secondSide, thirdSide);

            bool isRight = triangle.IsRight();

            return isRight;
        }


        [Test]
        public void CalculatingSquare()
        {
            double firstSide = 25, secondSide = 15, thirdSide = 15;
            double result = 103.645;
            Triangle triangle = new Triangle(firstSide, secondSide, thirdSide);

            double square = triangle.SquareCalculate();

            Assert.AreEqual(Math.Abs(square - result), 0);
        }
    }
}
