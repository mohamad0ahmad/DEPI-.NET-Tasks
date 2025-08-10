using System;

namespace CombinedProblems
{
    class Program
    {
        static void Main()
        {
            //// 1.
            //try
            //{
            //    Console.Write("Enter first integer: ");
            //    int a = int.Parse(Console.ReadLine());
            //    Console.Write("Enter second integer: ");
            //    int b = int.Parse(Console.ReadLine());

            //    int result = a / b;
            //    Console.WriteLine($"Result: {result}");
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Error: Cannot divide by zero.");
            //}
            //finally
            //{
            //    Console.WriteLine("Operation complete");
            //}

            //###########################
            //// 2. Defensive code method
            //TestDefensiveCode();

            //###########################
            // 3. 
            //int? nullableInt = null;
            //int defaultValue = nullableInt ?? 100;
            //Console.WriteLine($"Value using ?? operator: {defaultValue}");
            //Console.WriteLine($"HasValue: {nullableInt.HasValue}");
            //if (nullableInt.HasValue)
            //    Console.WriteLine($"Value: {nullableInt.Value}");
            //else
            //    Console.WriteLine("No value assigned.");

            //###########################
            //// 4. 
            //try
            //{
            //    int[] arr = new int[5];
            //    arr[10] = 50;
            //}
            //catch (IndexOutOfRangeException)
            //{
            //    Console.WriteLine("Error: Index out of range.");
            //}

            //###########################
            // 5.
            //int[,] matrix = new int[3, 3];
            //Console.WriteLine("Enter values for 3x3 matrix:");
            //for (int i = 0; i < 3; i++)
            //    for (int j = 0; j < 3; j++)
            //        matrix[i, j] = int.Parse(Console.ReadLine());

            //for (int i = 0; i < 3; i++)
            //{
            //    int rowSum = 0;
            //    for (int j = 0; j < 3; j++)
            //        rowSum += matrix[i, j];
            //    Console.WriteLine($"Row {i} sum: {rowSum}");
            //}

            //for (int j = 0; j < 3; j++)
            //{
            //    int colSum = 0;
            //    for (int i = 0; i < 3; i++)
            //        colSum += matrix[i, j];
            //    Console.WriteLine($"Column {j} sum: {colSum}");
            //}

            //###########################
            //// 6.
            //int[][] jagged = new int[3][];
            //jagged[0] = new int[2];
            //jagged[1] = new int[3];
            //jagged[2] = new int[1];

            //for (int i = 0; i < jagged.Length; i++)
            //{
            //    Console.WriteLine($"Enter {jagged[i].Length} numbers for row {i}:");
            //    for (int j = 0; j < jagged[i].Length; j++)
            //        jagged[i][j] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Jagged array contents:");
            //for (int i = 0; i < jagged.Length; i++)
            //{
            //    for (int j = 0; j < jagged[i].Length; j++)
            //        Console.Write(jagged[i][j] + " ");
            //    Console.WriteLine();
            //}

            //###########################
            // 7. 
            //#nullable enable
            //string? nullableStr = null;
            //Console.Write("Enter a string (leave empty for null): ");
            //string input = Console.ReadLine();
            //if (!string.IsNullOrEmpty(input))
            //    nullableStr = input;
            //Console.WriteLine(nullableStr!); 
            //#nullable disable

            //###########################
            // 8.
            //int val = 123;
            //object boxed = val;
            //try
            //{
            //    int unboxed = (int)boxed; 
            //    Console.WriteLine($"Unboxed value: {unboxed}");
            //}
            //catch (InvalidCastException)
            //{
            //    Console.WriteLine("Invalid cast during unboxing.");
            //}

            //###########################
            //// 9. 
            //SumAndMultiply(4, 5, out int sum, out int product);
            //Console.WriteLine($"Sum: {sum}, Product: {product}");

            //###########################
            //// 10. 
            //PrintString("Hello", 3);
            //PrintString(count: 2, text: "Named param example");

            //###########################
            //// 11. 
            //int[]? nullableArray = null;
            //Console.WriteLine($"Length: {nullableArray?.Length}");

            //###########################
            //// 12.
            //Console.Write("Enter a day: ");
            //string day = Console.ReadLine();
            //int dayNumber = day.ToLower() switch
            //{
            //    "monday" => 1,
            //    "tuesday" => 2,
            //    "wednesday" => 3,
            //    "thursday" => 4,
            //    "friday" => 5,
            //    "saturday" => 6,
            //    "sunday" => 7,
            //    _ => 0
            //};
            //Console.WriteLine($"Day number: {dayNumber}");

            //###########################
            //// 13.
            //Console.WriteLine($"Sum (individual): {SumArray(1, 2, 3, 4)}");
            //int[] numbers = { 5, 6, 7 };
            //Console.WriteLine($"Sum (array): {SumArray(numbers)}");
        }

        static void TestDefensiveCode()
        {
            int x, y;
            do
            {
                Console.Write("Enter positive integer X: ");
            } while (!int.TryParse(Console.ReadLine(), out x) || x <= 0);

            do
            {
                Console.Write("Enter positive integer Y (> 1): ");
            } while (!int.TryParse(Console.ReadLine(), out y) || y <= 1);

            Console.WriteLine($"X = {x}, Y = {y}");
        }

        static void SumAndMultiply(int a, int b, out int sum, out int product)
        {
            sum = a + b;
            product = a * b;
        }

        static void PrintString(string text, int count = 5)
        {
            for (int i = 0; i < count; i++)
                Console.WriteLine(text);
        }

        static int SumArray(params int[] nums)
        {
            int sum = 0;
            foreach (int n in nums)
                sum += n;
            return sum;
        }
    }
}
