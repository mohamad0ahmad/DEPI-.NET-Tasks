using System;

namespace ConsoleApp1
{
    public abstract class Shape
    {
        public abstract double GetArea();
        public void Display() => Console.WriteLine($"Area = {GetArea()}");
    }
}
