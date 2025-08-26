namespace ConsoleApp1
{
    public class Rectangle : Shape
    {
        private double Width, Height;
        public Rectangle(double w, double h) { Width = w; Height = h; }
        public override double GetArea() => Width * Height;
    }
}
