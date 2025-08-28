using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public static class StringTransformer
    {
        public static List<string> Transform(List<string> input, Func<string, string> transformer)
        {
            List<string> result = new List<string>();
            foreach (var s in input)
                result.Add(transformer(s));
            return result;
        }
    }
}
