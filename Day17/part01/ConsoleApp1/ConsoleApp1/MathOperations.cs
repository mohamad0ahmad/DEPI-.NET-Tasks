using System;

namespace ConsoleApp1
{
    public static class MathOperations
    {
        public static int Execute(int a, int b, Func<int, int, int> operation) => operation(a, b);
    }
}
