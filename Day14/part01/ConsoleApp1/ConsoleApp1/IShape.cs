using System;

namespace ConsoleApp1
{
    interface IShape
    {
        double Area { get; }
        void Draw();

        void PrintDetails()
        {
            Console.WriteLine($"Shape Details: Area = {Area}");
            Draw();
        }
    }
}
