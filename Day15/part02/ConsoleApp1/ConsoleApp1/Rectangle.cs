namespace ConsoleApp1
{
    public class Rectangle : GeometricShape
    {
        public Rectangle(double length, double width) : base(length, width) { }

        public override double CalculateArea()
        {
            return Dimension1 * Dimension2;
        }

        public override double Perimeter
        {
            get { return 2 * (Dimension1 + Dimension2); }
        }
    }
}
