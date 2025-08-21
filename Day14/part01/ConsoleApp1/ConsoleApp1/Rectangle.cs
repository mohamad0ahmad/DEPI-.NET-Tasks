using ConsoleApp1;

namespace ConsoleApp1
{
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double w, double h)
        {
            Width = w; Height = h;
        }

        public override void Draw() => System.Console.WriteLine("Drawing Rectangle from Shape base class");
        public override double CalculateArea() => Width * Height;
    }
}
