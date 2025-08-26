using System;

namespace ConsoleApp1
{
    public class SquareSeries : IShapeSeries
    {
        private int side = 0;
        public int CurrentShapeArea { get; set; }

        public void GetNextArea()
        {
            side++;
            CurrentShapeArea = side * side;
        }

        public void ResetSeries()
        {
            side = 0;
            CurrentShapeArea = 0;
        }
    }
}
