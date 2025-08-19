using System;

struct Point2
{
    public int X;
    public int Y;

    public Point2(int x)
    {
        X = x;
        Y = 0;
    }

    public Point2(int x, int y)
    {
        X = x;
        Y = y;
    }

    public override string ToString()
    {
        return $"Point -> X:{X}, Y:{Y}";
    }
}
