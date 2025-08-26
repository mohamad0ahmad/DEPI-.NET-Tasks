namespace ConsoleApp1
{
    public class Triangle : GeometricShape
    {
        public Triangle(double baseLength, double height) : base(baseLength, height) { }

        public override double CalculateArea()
        {
            return 0.5 * Dimension1 * Dimension2;
        }

        public override double Perimeter
        {
            get { return Dimension1 + Dimension2 + System.Math.Sqrt(Dimension1 * Dimension1 + Dimension2 * Dimension2); }
        }
    }
}
