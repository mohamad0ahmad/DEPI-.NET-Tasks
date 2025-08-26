using System;

namespace ConsoleApp1
{
    public class Circle : Shape
    {
        private double Radius;
        public Circle(double r) { Radius = r; }
        public override double GetArea() => Math.PI * Radius * Radius;
    }
}
