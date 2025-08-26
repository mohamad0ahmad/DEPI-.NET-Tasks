using System;

namespace ConsoleApp1
{
    public static class Utilities
    {
        public static void PrintTenShapes(IShapeSeries series)
        {
            series.ResetSeries();
            for (int i = 0; i < 10; i++)
            {
                series.GetNextArea();
                Console.WriteLine($"Shape {i + 1}: Area = {series.CurrentShapeArea}");
            }
        }

        public static void SelectionSort(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] < numbers[minIndex])
                        minIndex = j;
                }
                int temp = numbers[minIndex];
                numbers[minIndex] = numbers[i];
                numbers[i] = temp;
            }
        }
    }
}
