using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public static class GenericTransformer
    {
        public static List<R> Transform<T, R>(List<T> input, Func<T, R> transformer)
        {
            List<R> result = new List<R>();
            foreach (var item in input)
                result.Add(transformer(item));
            return result;
        }
    }
}
