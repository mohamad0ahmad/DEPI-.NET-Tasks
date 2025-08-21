namespace ConsoleApp1
{
    class Parent
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Parent(int x, int y)
        {
            X = x; Y = y;
        }

        public virtual int Product() => X * Y;

        public override string ToString() => $"({X}, {Y})";
    }
}
