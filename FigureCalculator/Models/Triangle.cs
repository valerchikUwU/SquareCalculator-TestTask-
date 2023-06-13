using FigureCalculator.Contracts;
using FigureCalculator.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureCalculator.Models
{
    public class Triangle : Figure
    {
        private double firstSide { get; }
        private double secondSide { get; }
        private double thirdSide { get; }


        public Triangle(double _firstSide, double _secondSide, double _thirdSide)
        {
            try
            {
                if (_firstSide <= 0)
                {
                    throw new BelowZeroException("Сторона не может быть меньше или равна 0", _firstSide);
                }
                if (_secondSide <= 0)
                {
                    throw new BelowZeroException("Сторона не может быть меньше или равна 0", _secondSide);
                }
                if (_thirdSide <= 0)
                {
                    throw new BelowZeroException("Сторона не может быть меньше или равна 0", _thirdSide);
                }

                double biggestSide = Math.Max(_firstSide, Math.Max(_secondSide, _thirdSide));
                double perimeter = _firstSide + _secondSide + _thirdSide;
                if ((perimeter - biggestSide) - biggestSide <= 0)
                {
                    throw new IncorrectTriangleSidesException("Сумма длин двух сторон треугольника должна быть больше третьей стороны.");
                }


                this.firstSide = _firstSide;

                this.secondSide = _secondSide;

                this.thirdSide = _thirdSide;
            }

            catch (BelowZeroException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message} : {ex.Value}");
            }
            catch (IncorrectTriangleSidesException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        
        }

        public double PerimeterCalculate()
        {
            return firstSide + secondSide + thirdSide;
        }

        public bool IsRight()
        {
            double firstSideSquared = Math.Pow(firstSide, 2);
            double secondSideSquared = Math.Pow(secondSide, 2);
            double thirdSideSquared = Math.Pow(thirdSide, 2);

            if (firstSideSquared == (secondSideSquared + thirdSideSquared)
                || secondSideSquared == (firstSideSquared + thirdSideSquared)
                || thirdSideSquared == (firstSideSquared + secondSideSquared))
            {
                return true;
            }
            else return false;
        }

        public override double SquareCalculate()
        {
            double semiPerimeter = PerimeterCalculate() / 2;
            return Math.Round(Math.Sqrt(semiPerimeter * (semiPerimeter - firstSide) * (semiPerimeter - secondSide) * (semiPerimeter - thirdSide)), 3);
        }
    }
}
