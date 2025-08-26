using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Shape Series (Squares) ===");
            Utilities.PrintTenShapes(new SquareSeries());

            Console.WriteLine("\n=== Shape Series (Circles) ===");
            Utilities.PrintTenShapes(new CircleSeries());

            Console.WriteLine("\n=== Sorting Shapes by Area ===");
            Shape[] shapes =
            {
                new Shape("Square", 25),
                new Shape("Circle", Math.PI * 5 * 5),
                new Shape("Rectangle", 20)
            };
            Array.Sort(shapes);
            foreach (var s in shapes)
                Console.WriteLine(s);

            Console.WriteLine("\n=== Geometric Shapes ===");
            GeometricShape triangle = new Triangle(3, 4);
            Console.WriteLine($"Triangle Area: {triangle.CalculateArea()}, Perimeter: {triangle.Perimeter}");

            GeometricShape rectangle = new Rectangle(5, 7);
            Console.WriteLine($"Rectangle Area: {rectangle.CalculateArea()}, Perimeter: {rectangle.Perimeter}");

            Console.WriteLine("\n=== Selection Sort on Areas ===");
            int[] areas = { 25, 78, 20, 50, 10 };
            Utilities.SelectionSort(areas);
            Console.WriteLine(string.Join(", ", areas));
        }
    }
}
