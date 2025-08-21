namespace ConsoleApp1
{
    abstract class Shape
    {
        public virtual void Draw() => System.Console.WriteLine("Drawing Shape");
        public abstract double CalculateArea();
    }
}
