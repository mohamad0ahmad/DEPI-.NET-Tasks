using System;

namespace ConsoleApp1
{
    static class GenericMethods
    {
        // Problem 1: Reverse Array
        public static T[] ReverseArray<T>(T[] input)
        {
            T[] result = new T[input.Length];
            for (int i = 0; i < input.Length; i++)
                result[i] = input[input.Length - 1 - i];
            return result;
        }

        // Problem 3: Swap Elements
        public static void Swap<T>(T[] array, int index1, int index2)
        {
            if (index1 < 0 || index1 >= array.Length ||
                index2 < 0 || index2 >= array.Length)
                throw new ArgumentOutOfRangeException("Index out of range");

            T temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }

        // Problem 4: Find Maximum Element
        public static T FindMax<T>(T[] array) where T : IComparable<T>
        {
            if (array.Length == 0) throw new ArgumentException("Array is empty");

            T max = array[0];
            foreach (T item in array)
                if (item.CompareTo(max) > 0)
                    max = item;

            return max;
        }
    }
}
