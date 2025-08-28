using System;

namespace ConsoleApp1
{
    static class Helper2<T>
    {
        public static bool SearchArray(T[] arr, T value)
        {
            foreach (var item in arr)
                if (item.Equals(value)) return true;
            return false;
        }

        public static void ReplaceArray(T[] arr, T oldVal, T newVal)
        {
            for (int i = 0; i < arr.Length; i++)
                if (arr[i].Equals(oldVal))
                    arr[i] = newVal;
        }
    }
}
