using ConsoleApp1;

namespace ConsoleApp1
{
    class RectangleShape : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double Area => Width * Height;

        public RectangleShape(double w, double h)
        {
            Width = w; Height = h;
        }

        public void Draw() => System.Console.WriteLine("Drawing Rectangle");
    }
}
