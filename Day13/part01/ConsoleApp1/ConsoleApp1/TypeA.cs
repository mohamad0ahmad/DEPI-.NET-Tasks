using System;

class TypeA
{
    private int F = 10;
    internal int G = 20; 
    public int H = 30;     

    public void PrintInside()
    {
        Console.WriteLine($"Inside Class: F={F}, G={G}, H={H}");
    }
}

