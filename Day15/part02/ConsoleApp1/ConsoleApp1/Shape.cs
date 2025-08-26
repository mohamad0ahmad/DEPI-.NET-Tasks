using System;

namespace ConsoleApp1
{
    public class Shape : IComparable<Shape>
    {
        public string Name { get; set; }
        public double Area { get; set; }

        public Shape(string name, double area)
        {
            Name = name;
            Area = area;
        }

        public int CompareTo(Shape other)
        {
            return Area.CompareTo(other.Area);
        }

        public override string ToString()
        {
            return $"{Name} - Area: {Area:F2}";
        }
    }
}
