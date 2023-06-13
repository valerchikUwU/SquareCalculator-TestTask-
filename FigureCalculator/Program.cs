using FigureCalculator.Models;

class Program
{
    static void Main(string[] args)
    {
        Triangle triangle = new Triangle(25, 15, 15);
        Console.WriteLine($"Прямоугольный ли треугольник: {triangle.IsRight()}");

        Console.WriteLine($"Площадь треугольника {triangle.SquareCalculate()}");

        Circle circle = new Circle(14);
        Console.WriteLine($"Площадь круга {circle.SquareCalculate()}");
    }
}