using System;

namespace ConsoleApp1
{
    public class SortingTwo<T>
    {
        public static void Sort(T[] array, Comparison<T> comparison)
        {
            Array.Sort(array, comparison);
        }
    }
}
