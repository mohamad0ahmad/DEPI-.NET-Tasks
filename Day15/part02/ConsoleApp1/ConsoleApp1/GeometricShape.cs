namespace ConsoleApp1
{
    public abstract class GeometricShape
    {
        public double Dimension1 { get; set; }
        public double Dimension2 { get; set; }

        public GeometricShape(double d1, double d2)
        {
            Dimension1 = d1;
            Dimension2 = d2;
        }

        public abstract double CalculateArea();
        public abstract double Perimeter { get; }
    }
}
