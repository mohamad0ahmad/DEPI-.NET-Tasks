using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public static class Utility
    {
        public static T GetDefault<T>() => default(T);

        public static Array CloneArray(Array array) => (Array)array.Clone();

        public static List<R> ApplyFunc<T, R>(List<T> list, Func<T, R> func)
        {
            List<R> result = new List<R>();
            foreach (var item in list)
                result.Add(func(item));
            return result;
        }

        public static void ApplyAction(List<string> list, Action<string> action)
        {
            foreach (var s in list) action(s);
        }

        public static List<int> Filter(List<int> list, Predicate<int> predicate)
        {
            List<int> result = new List<int>();
            foreach (var i in list)
                if (predicate(i)) result.Add(i);
            return result;
        }

        public static List<string> FilterStrings(List<string> list, Func<string, bool> condition)
        {
            List<string> result = new List<string>();
            foreach (var s in list)
                if (condition(s)) result.Add(s);
            return result;
        }

        public static int MathAnonymous(int a, int b, Func<int, int, int> func) => func(a, b);

        public static double MathLambda(double a, double b, Func<double, double, double> func) => func(a, b);
    }
}
