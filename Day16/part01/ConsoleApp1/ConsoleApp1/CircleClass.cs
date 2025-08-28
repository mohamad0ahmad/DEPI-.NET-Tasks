namespace ConsoleApp1
{
    class CircleClass
    {
        public int Radius { get; set; }
        public string Color { get; set; }

        public CircleClass(int r, string c)
        {
            Radius = r;
            Color = c;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is CircleClass other)) return false;
            return Radius == other.Radius && Color == other.Color;
        }

        public override int GetHashCode() => (Radius, Color).GetHashCode();

        public static bool operator ==(CircleClass a, CircleClass b) => a.Equals(b);
        public static bool operator !=(CircleClass a, CircleClass b) => !a.Equals(b);
    }
}
