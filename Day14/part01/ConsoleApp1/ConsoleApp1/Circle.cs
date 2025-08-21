using ConsoleApp1;

namespace ConsoleApp1
{
    class Circle : IShape
    {
        public double Radius { get; set; }
        public double Area => System.Math.PI * Radius * Radius;

        public Circle(double r)
        {
            Radius = r;
        }

        public void Draw() => System.Console.WriteLine("Drawing Circle");
    }
}
