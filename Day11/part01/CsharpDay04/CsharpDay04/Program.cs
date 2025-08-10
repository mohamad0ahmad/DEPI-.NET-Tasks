using System;

namespace CsharpDay04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ---------------- Problem 1 ----------------
            //int[] arr1 = new int[3]; 
            //int[] arr2 = { 1, 2, 3 }; 
            //int[] arr3 = new[] { 4, 5, 6 }; 

            //arr1[0] = 10;
            //arr1[1] = 20;
            //arr1[2] = 30;

            //Console.WriteLine("Array 1:");
            //foreach (int num in arr1) Console.Write(num + " ");
            //Console.WriteLine("\nArray 2:");
            //foreach (int num in arr2) Console.Write(num + " ");
            //Console.WriteLine("\nArray 3:");
            //foreach (int num in arr3) Console.Write(num + " ");

            //// Demonstrate IndexOutOfRangeException
            //try
            //{
            //    Console.WriteLine(arr1[5]);
            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine("\nException: " + ex.Message);
            //}

            //// ---------------- Problem 2 ----------------
            //int[] arrA = { 1, 2, 3 };
            //int[] arrB = arrA; // shallow copy
            //arrB[0] = 99;
            //Console.WriteLine("\nShallow Copy: arrA[0] = " + arrA[0]);

            //int[] arrC = (int[])arrA.Clone(); // deep copy
            //arrC[0] = 50;
            //Console.WriteLine("Deep Copy: arrA[0] = " + arrA[0] + ", arrC[0] = " + arrC[0]);

            //// ---------------- Problem 3 ----------------
            //int[,] grades = new int[3, 3];
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"Enter grade for student {i + 1}, subject {j + 1}: ");
            //        grades[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //Console.WriteLine("\nGrades:");
            //for (int i = 0; i < grades.GetLength(0); i++)
            //{
            //    for (int j = 0; j < grades.GetLength(1); j++)
            //    {
            //        Console.Write(grades[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            // ---------------- Problem 4 ----------------
            //int[] arrMethods = { 5, 3, 8, 1, 4 };
            //Array.Sort(arrMethods);
            //Console.WriteLine("After Sort: " + string.Join(", ", arrMethods));

            //Array.Reverse(arrMethods);
            //Console.WriteLine("After Reverse: " + string.Join(", ", arrMethods));

            //Console.WriteLine("IndexOf(4): " + Array.IndexOf(arrMethods, 4));

            //int[] copyArray = new int[5];
            //Array.Copy(arrMethods, copyArray, 5);
            //Console.WriteLine("After Copy: " + string.Join(", ", copyArray));

            //Array.Clear(arrMethods, 0, 2);
            //Console.WriteLine("After Clear: " + string.Join(", ", arrMethods));

            //// ---------------- Problem 5 ----------------
            //int[] arrLoop = { 10, 20, 30, 40 };
            //Console.WriteLine("For loop:");
            //for (int i = 0; i < arrLoop.Length; i++)
            //    Console.Write(arrLoop[i] + " ");

            //Console.WriteLine("\nForeach loop:");
            //foreach (int num in arrLoop)
            //    Console.Write(num + " ");

            //Console.WriteLine("\nWhile loop (reverse):");
            //int idx = arrLoop.Length - 1;
            //while (idx >= 0)
            //{
            //    Console.Write(arrLoop[idx] + " ");
            //    idx--;
            //}

            //// ---------------- Problem 6 ----------------
            //int numInput;
            //do
            //{
            //    Console.Write("\nEnter a positive odd number: ");
            //    if (int.TryParse(Console.ReadLine(), out numInput) && numInput > 0 && numInput % 2 != 0)
            //        break;
            //    Console.WriteLine("Invalid input, try again.");
            //} while (true);
            //Console.WriteLine("Valid input: " + numInput);

            //// ---------------- Problem 7 ----------------
            //int[,] fixedMatrix = { { 1, 2 }, { 3, 4 } };
            //Console.WriteLine("Matrix:");
            //for (int i = 0; i < fixedMatrix.GetLength(0); i++)
            //{
            //    for (int j = 0; j < fixedMatrix.GetLength(1); j++)
            //        Console.Write(fixedMatrix[i, j] + "\t");
            //    Console.WriteLine();
            //}

            //// ---------------- Problem 8 ----------------
            //Console.Write("Enter month number: ");
            //int month = int.Parse(Console.ReadLine());

            //// if-else
            //if (month == 1) Console.WriteLine("January");
            //else if (month == 2) Console.WriteLine("February");
            //else Console.WriteLine("Other month");

            //// switch
            //switch (month)
            //{
            //    case 1: Console.WriteLine("January"); break;
            //    case 2: Console.WriteLine("February"); break;
            //    default: Console.WriteLine("Other month"); break;
            //}

            //// ---------------- Problem 9 ----------------
            //int[] arrSearch = { 5, 1, 4, 3, 2, 4 };
            //Array.Sort(arrSearch);
            //Console.WriteLine("Sorted: " + string.Join(", ", arrSearch));
            //Console.WriteLine("IndexOf(4): " + Array.IndexOf(arrSearch, 4));
            //Console.WriteLine("LastIndexOf(4): " + Array.LastIndexOf(arrSearch, 4));

            //// ---------------- Problem 10 ----------------
            //int[] arrSum = { 1, 2, 3, 4 };
            //int sumFor = 0, sumForeach = 0;

            //for (int i = 0; i < arrSum.Length; i++)
            //    sumFor += arrSum[i];

            //foreach (int num in arrSum)
            //    sumForeach += num;

            //Console.WriteLine("Sum using for: " + sumFor);
            //Console.WriteLine("Sum using foreach: " + sumForeach);
        }
    }
}
