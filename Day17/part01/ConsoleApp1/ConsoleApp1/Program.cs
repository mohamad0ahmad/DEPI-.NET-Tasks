using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //-------------------------------------------//
            Employee[] employees = {
                new Employee("Ali", 3000),
                new Employee("Omar", 2000),
                new Employee("Sara", 4000)
            };
            SortingAlgorithm<Employee>.Sort(employees, (a, b) => a.Salary.CompareTo(b.Salary));
            Console.WriteLine("Employees sorted by Salary:");
            foreach (var e in employees) Console.WriteLine(e);

            //-------------------------------------------//
            int[] numbers = { 1, 5, 3, 9, 2 };
            SortingTwo<int>.Sort(numbers, (a, b) => b.CompareTo(a));
            Console.WriteLine("Integers sorted descending:");
            foreach (var n in numbers) Console.Write(n + " ");
            Console.WriteLine();

            //-------------------------------------------//
            string[] names = { "Ali", "Mohamed", "Sara", "Omar" };
            SortingTwo<string>.Sort(names, (a, b) => a.Length.CompareTo(b.Length));
            Console.WriteLine("Strings sorted by length:");
            foreach (var s in names) Console.WriteLine(s);

            //-------------------------------------------//
            Manager[] managers = {
                new Manager("Hassan", 7000),
                new Manager("Mona", 6000),
                new Manager("Khaled", 8000)
            };
            Array.Sort(managers);
            Console.WriteLine("Managers sorted by Salary:");
            foreach (var m in managers) Console.WriteLine(m);

            //-------------------------------------------//
            Func<Employee, Employee, bool> compareByNameLength =
                (a, b) => a.Name.Length < b.Name.Length;
            Array.Sort(employees, (a, b) =>
                compareByNameLength(a, b) ? -1 : 1);
            Console.WriteLine("Employees sorted by Name length:");
            foreach (var e in employees) Console.WriteLine(e);

            //-------------------------------------------//
            int[] nums = { 10, 4, 7, 1 };
            Array.Sort(nums, delegate (int a, int b) { return a.CompareTo(b); });
            Console.WriteLine("Sorted with anonymous function: " + string.Join(",", nums));
            Array.Sort(nums, (a, b) => a.CompareTo(b));
            Console.WriteLine("Sorted with lambda: " + string.Join(",", nums));

            //-------------------------------------------//
            int[] arr = { 1, 2, 3 };
            SortingAlgorithm<int>.Swap(ref arr[0], ref arr[2]);
            Console.WriteLine("After Swap: " + string.Join(",", arr));

            //-------------------------------------------//
            SortingTwo<Employee>.Sort(employees, (a, b) =>
            {
                int result = a.Salary.CompareTo(b.Salary);
                return result == 0 ? a.Name.CompareTo(b.Name) : result;
            });
            Console.WriteLine("Employees sorted by Salary then Name:");
            foreach (var e in employees) Console.WriteLine(e);

            //-------------------------------------------//
            Console.WriteLine("Default int: " + Utility.GetDefault<int>());
            Console.WriteLine("Default string: " + Utility.GetDefault<string>());

            //-------------------------------------------//
            Employee[] cloned = CloningSortingAlgorithm<Employee>.CloneArray(employees);
            CloningSortingAlgorithm<Employee>.Sort(cloned, (a, b) => a.Salary.CompareTo(b.Salary));


            //-------------------------------------------//
            List<string> words = new List<string> { "hello", "world" };
            var upper = StringTransformer.Transform(words, s => s.ToUpper());
            Console.WriteLine("Uppercase: " + string.Join(",", upper));

            //-------------------------------------------//
            int sum = MathOperations.Execute(5, 3, (a, b) => a + b);
            Console.WriteLine("Sum = " + sum);

            //-------------------------------------------//
            List<int> intList = new List<int> { 1, 2, 3 };
            var strList = GenericTransformer.Transform<int, string>(intList, i => i.ToString());
            Console.WriteLine("Int to string: " + string.Join(",", strList));

            //-------------------------------------------//
            Func<int, int> square = x => x * x;
            var squared = Utility.ApplyFunc(intList, square);
            Console.WriteLine("Squares: " + string.Join(",", squared));

            //-------------------------------------------//
            List<string> greetings = new List<string> { "Hi", "Hello" };
            Utility.ApplyAction(greetings, s => Console.WriteLine("Greeting: " + s));

            //-------------------------------------------//
            List<int> evenNumbers = Utility.Filter(intList, x => x % 2 == 0);
            Console.WriteLine("Evens: " + string.Join(",", evenNumbers));

            //-------------------------------------------//
            var startsWithA = Utility.FilterStrings(words, delegate (string s) { return s.StartsWith("h"); });
            Console.WriteLine("Starts with h: " + string.Join(",", startsWithA));

            //-------------------------------------------//
            int multiply = Utility.MathAnonymous(4, 5, delegate (int a, int b) { return a * b; });
            Console.WriteLine("Multiply = " + multiply);

            //-------------------------------------------//
            var longWords = Utility.FilterStrings(words, s => s.Length > 3);
            Console.WriteLine("Words length >3: " + string.Join(",", longWords));

            //-------------------------------------------//
            double resultDiv = Utility.MathLambda(10, 2, (a, b) => a / b);
            Console.WriteLine("Division = " + resultDiv);
        }
    }
}
