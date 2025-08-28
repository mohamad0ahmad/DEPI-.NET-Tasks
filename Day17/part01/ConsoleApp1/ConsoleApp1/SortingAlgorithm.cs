using System;

namespace ConsoleApp1
{
    public class SortingAlgorithm<T>
    {
        public static void Sort(T[] array, Comparison<T> comparison)
        {
            Array.Sort(array, comparison);
        }

        public static void Swap<TU>(ref TU a, ref TU b)
        {
            TU temp = a;
            a = b;
            b = temp;
        }
    }

    public class CloningSortingAlgorithm<T> where T : ICloneable
    {
        public static void Sort(T[] array, Comparison<T> comparison)
        {
            Array.Sort(array, comparison);
        }

        public static T[] CloneArray(T[] array)
        {
            T[] cloned = new T[array.Length];
            for (int i = 0; i < array.Length; i++)
                cloned[i] = (T)array[i].Clone();
            return cloned;
        }
    }
}
