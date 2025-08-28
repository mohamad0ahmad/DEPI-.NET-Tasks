namespace ConsoleApp1
{
    struct CircleStruct
    {
        public int Radius { get; set; }
        public string Color { get; set; }

        public CircleStruct(int r, string c)
        {
            Radius = r;
            Color = c;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is CircleStruct other)) return false;
            return Radius == other.Radius && Color == other.Color;
        }

        public override int GetHashCode() => (Radius, Color).GetHashCode();

        public static bool operator ==(CircleStruct a, CircleStruct b) => a.Equals(b);
        public static bool operator !=(CircleStruct a, CircleStruct b) => !a.Equals(b);
    }
}
