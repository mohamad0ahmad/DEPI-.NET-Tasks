using System;

namespace ConsoleApp1
{
    struct Rectangle
    {
        public int Length { get; set; }
        public int Width { get; set; }

        public Rectangle(int l, int w)
        {
            Length = l;
            Width = w;
        }

        public static void Swap(ref Rectangle r1, ref Rectangle r2)
        {
            Rectangle temp = r1;
            r1 = r2;
            r2 = temp;
        }

        public override string ToString() => $"[{Length}x{Width}]";
    }
}
