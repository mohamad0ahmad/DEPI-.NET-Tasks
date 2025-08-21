using ConsoleApp1;

namespace ConsoleApp1
{
    class Child : Parent
    {
        public int Z { get; set; }

        public Child(int x, int y, int z) : base(x, y)
        {
            Z = z;
        }
        //-------------------
        public new int Product() => X * Y * Z;

        // public override int Product() => (X + Y) * Z;
        //----------------
        public override string ToString() => $"({X}, {Y}, {Z})";
    }
}
