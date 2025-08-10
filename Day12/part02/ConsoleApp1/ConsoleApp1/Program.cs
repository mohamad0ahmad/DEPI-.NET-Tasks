using System;
using System.Linq;

namespace MultiTasks
{
    class Program
    {
        static void Main()
        {
            PrintNumbersInRange();
            DisplayMultiplicationTable();
            ListEvenNumbers();
            ComputeExponentiation();
            ReverseTextString();
            ReverseIntegerValue();
            LongestDistanceBetweenMatchingElements();
            ReverseWordsInSentence();
        }

        // 1. Print numbers in range
        static void PrintNumbersInRange()
        {
            Console.Write("Enter a positive integer: ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                Console.Write(i);
                if (i < num) Console.Write(", ");
            }
            Console.WriteLine();
        }

        // 2. Multiplication table
        static void DisplayMultiplicationTable()
        {
            Console.Write("Enter an integer: ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 12; i++)
            {
                Console.Write(num * i);
                if (i < 12) Console.Write(", ");
            }
            Console.WriteLine();
        }

        // 3. Even numbers list
        static void ListEvenNumbers()
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 2; i <= num; i += 2)
            {
                Console.Write(i);
                if (i + 2 <= num) Console.Write(", ");
            }
            Console.WriteLine();
        }

        // 4. Exponentiation
        static void ComputeExponentiation()
        {
            Console.Write("Enter base number: ");
            int baseNum = int.Parse(Console.ReadLine());
            Console.Write("Enter exponent: ");
            int exp = int.Parse(Console.ReadLine());

            int result = 1;
            for (int i = 0; i < exp; i++)
                result *= baseNum;

            Console.WriteLine(result);
        }

        // 5. Reverse a text string
        static void ReverseTextString()
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();
            string reversed = new string(str.Reverse().ToArray());
            Console.WriteLine(reversed);
        }

        // 6. Reverse an integer
        static void ReverseIntegerValue()
        {
            Console.Write("Enter an integer: ");
            int num = int.Parse(Console.ReadLine());
            string reversed = new string(num.ToString().Reverse().ToArray());
            Console.WriteLine(reversed);
        }

        // 7. Longest distance between matching elements
        static void LongestDistanceBetweenMatchingElements()
        {
            Console.Write("Enter array size: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter array elements:");
            for (int i = 0; i < n; i++)
                arr[i] = int.Parse(Console.ReadLine());

            int longest = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        int dist = j - i - 1;
                        if (dist > longest) longest = dist;
                    }
                }
            }
            Console.WriteLine($"Longest distance: {longest}");
        }

        // 8. Reverse words in a sentence
        static void ReverseWordsInSentence()
        {
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(words);
            Console.WriteLine(string.Join(" ", words));
        }
    }
}
