using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Problem 1:===");
            int[] numbers = { 1, 2, 3, 4, 5 };
            var reversed = GenericMethods.ReverseArray(numbers);
            Console.WriteLine(string.Join(", ", reversed));

            string[] names = { "Ali", "Omar", "Sara" };
            var reversedNames = GenericMethods.ReverseArray(names);
            Console.WriteLine(string.Join(", ", reversedNames));

            Console.WriteLine("\n=== Problem 2:===");
            GenericStack<string> stack = new GenericStack<string>();
            stack.Push("A");
            stack.Push("B");
            stack.Push("C");
            Console.WriteLine("Peek: " + stack.Peek());
            Console.WriteLine("Pop: " + stack.Pop());
            Console.WriteLine("Peek after Pop: " + stack.Peek());

            Console.WriteLine("\n=== Problem 3:===");
            int[] arr = { 10, 20, 30, 40 };
            GenericMethods.Swap(arr, 1, 3);
            Console.WriteLine(string.Join(", ", arr));

            Console.WriteLine("\n=== Problem 4:===");
            int[] arr2 = { 7, 2, 9, 1, 5 };
            Console.WriteLine("Max int: " + GenericMethods.FindMax(arr2));

            string[] arr3 = { "apple", "banana", "orange" };
            Console.WriteLine("Max string: " + GenericMethods.FindMax(arr3));
        }
    }
}
