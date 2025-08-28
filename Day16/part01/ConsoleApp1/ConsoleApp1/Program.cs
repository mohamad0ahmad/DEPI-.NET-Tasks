using System;
using System.Drawing;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // --------------------
            Console.WriteLine("=== Weekdays Enum ===");
            foreach (Weekdays day in Enum.GetValues(typeof(Weekdays)))
                Console.WriteLine($"{day} = {(int)day}");

            // --------------------
            Console.WriteLine("\n=== Grades Enum ===");
            foreach (Grades g in Enum.GetValues(typeof(Grades)))
                Console.WriteLine($"{g} = {(short)g}");

            // --------------------
            Console.WriteLine("\n=== Person with Department ===");
            Person p1 = new Person("Ali", "IT");
            Person p2 = new Person("Omar", "HR");
            p1.Display();
            p2.Display();

            // --------------------
            Console.WriteLine("\n=== Child with Sealed Salary ===");
            Child child = new Child { Name = "Sara", Salary = 5000 };
            child.DisplaySalary();

            // --------------------
            Console.WriteLine("\n=== Utility Perimeter ===");
            Console.WriteLine($"Perimeter: {Utility.Perimeter(5, 7)}");

            //  --------------------
            Console.WriteLine("\n=== Complex Number Multiplication ===");
            ComplexNumber c1 = new ComplexNumber(2, 3);
            ComplexNumber c2 = new ComplexNumber(4, 5);
            ComplexNumber result = c1 * c2;
            Console.WriteLine($"Result: {result}");

            // --------------------
            Console.WriteLine("\n=== Gender Enum Memory Usage ===");
            Console.WriteLine($"Size of byte enum: {sizeof(byte)} bytes");
            Console.WriteLine($"Size of int enum: {sizeof(int)} bytes");

            // --------------------
            Console.WriteLine("\n=== Temperature Conversion ===");
            Console.WriteLine($"25C = {Utility.CelsiusToFahrenheit(25)}F");
            Console.WriteLine($"77F = {Utility.FahrenheitToCelsius(77)}C");

            // --------------------
            Console.WriteLine("\n=== Enum.TryParse ===");
            string input = "A";
            if (Enum.TryParse(input, out Grades grade))
                Console.WriteLine($"Parsed: {grade}");
            else
                Console.WriteLine("Invalid grade");

            // --------------------
            Console.WriteLine("\n=== Employee Search with Equals ===");
            Employee e1 = new Employee("Ahmed", new Department("IT"));
            Employee e2 = new Employee("Hany", new Department("HR"));
            Employee[] employees = { e1, e2 };
            Console.WriteLine(Helper2<Employee>.SearchArray(employees, new Employee("Ahmed", new Department("IT"))));

            // --------------------
            Console.WriteLine("\n=== Generic Max Method ===");
            Console.WriteLine(Helper.Max(5, 10));
            Console.WriteLine(Helper.Max(3.5, 7.2));
            Console.WriteLine(Helper.Max("Ali", "Omar"));

            // --------------------
            Console.WriteLine("\n=== ReplaceArray ===");
            int[] nums = { 1, 2, 3, 2, 4 };
            Helper2<int>.ReplaceArray(nums, 2, 9);
            Console.WriteLine(string.Join(", ", nums));

            string[] names = { "Ali", "Omar", "Ali" };
            Helper2<string>.ReplaceArray(names, "Ali", "Hany");
            Console.WriteLine(string.Join(", ", names));

            // --------------------
            Console.WriteLine("\n=== Swap Rectangles ===");
            Rectangle r1 = new Rectangle(4, 6);
            Rectangle r2 = new Rectangle(7, 3);
            Console.WriteLine($"Before: r1={r1}, r2={r2}");
            Rectangle.Swap(ref r1, ref r2);
            Console.WriteLine($"After: r1={r1}, r2={r2}");

            // --------------------
            Console.WriteLine("\n=== Department Search ===");
            Department d = new Department("IT");
            Console.WriteLine(Helper2<Employee>.SearchArray(employees, new Employee("Test", d)));

            //  --------------------
            Console.WriteLine("\n=== Struct vs Class Circle ===");
            CircleStruct cs1 = new CircleStruct(5, "Red");
            CircleStruct cs2 = new CircleStruct(5, "Red");
            Console.WriteLine($"Struct Equals: {cs1.Equals(cs2)}");
            Console.WriteLine($"Struct ==: {cs1 == cs2}");

            CircleClass cc1 = new CircleClass(5, "Red");
            CircleClass cc2 = new CircleClass(5, "Red");
            Console.WriteLine($"Class Equals: {cc1.Equals(cc2)}");
            Console.WriteLine($"Class ==: {cc1 == cc2}");
        }
    }
}
