using System;

struct Point
{
    public int X;
    public int Y;

    // Default Constructor
    //public Point()
    //{
    //    X = 0;
    //    Y = 0;
    //}

    // Parameterized Constructor
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}

