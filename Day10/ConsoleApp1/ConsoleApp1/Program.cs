using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            try
            {
                int number1 = int.Parse(input);
                Console.WriteLine("int.Parse: " + number1);
            }
            catch (FormatException)
            {
                Console.WriteLine("int.Parse failed: Invalid format.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("int.Parse failed: Number too large or too small.");
            }

            try
            {
                int number2 = Convert.ToInt32(input);
                Console.WriteLine("Convert.ToInt32: " + number2);
            }
            catch (FormatException)
            {
                Console.WriteLine("Convert.ToInt32 failed: Invalid format.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Convert.ToInt32 failed: Number too large or too small.");
            }

            /*
            // 2.
            Console.Write("Enter an integer: ");
            string input2 = Console.ReadLine();
            if (int.TryParse(input2, out int result))
                Console.WriteLine("Valid integer: " + result);
            else
                Console.WriteLine("Invalid input.");
            */

            /*
            // 3. 
            object obj;
            obj = 42;
            Console.WriteLine("HashCode (int): " + obj.GetHashCode());
            obj = "hello";
            Console.WriteLine("HashCode (string): " + obj.GetHashCode());
            obj = 3.14;
            Console.WriteLine("HashCode (double): " + obj.GetHashCode());
            */

            /*
            // 4.
            int[] original = { 1, 2, 3 };
            int[] copy = original;
            copy[0] = 99;
            Console.WriteLine("Original[0]: " + original[0]);  // Output will be 99
            */

            /*
            // 5.
            string greeting = "Hello ";
            Console.WriteLine("Before: " + greeting.GetHashCode());
            greeting += "Hi Willy";
            Console.WriteLine("After: " + greeting.GetHashCode());
            */

            /*
            // 6.
            StringBuilder sb = new StringBuilder("Hi Willy");
            Console.WriteLine("Before: " + sb.GetHashCode());
            sb.Append(" How are you?");
            Console.WriteLine("After: " + sb.GetHashCode());
            */

            /*
            // 7.
            // Answer: StringBuilder is faster because strings are immutable in C#, so every modification creates a new string in memory.
            // StringBuilder modifies the same buffer, avoiding multiple memory allocations.
            */

            /*
            // 8.
            Console.Write("Enter first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Sum is " + (a + b));                          // Concatenation
            Console.WriteLine(string.Format("Sum is {0}", a + b));          // Composite formatting
            Console.WriteLine($"Sum is {a + b}");                            // String interpolation
            */

            /*
            // 9.
            StringBuilder builder = new StringBuilder("Hello World");
            builder.Append("!");
            builder.Replace("World", "C#");
            builder.Insert(6, "amazing ");
            builder.Remove(0, 6);
            Console.WriteLine(builder.ToString());  // Output: amazing C#!
            */
        }
    }
}
