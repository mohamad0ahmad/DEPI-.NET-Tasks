using System;
using System.Security;
using System.Text;

namespace ConsoleApp1
{
    class Person
    {
        public string Name;
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            //int x = 10;
            /*int y = 20;
            int sum = x + y;
            Console.WriteLine(sum);*/
            //Q
            //S: Ctrl + /

            //----------------------

            //String x = "10";
            //Console.WriteLine(x + 'y');
            //Q:difference between a runtime error and a logical error
            //Runtime Error
            //Occurs during program execution(runtime)
            //Causes the program to crash or behave unexpectedly
            //Usually due to illegal operations(e.g., dividing by zero, accessing invalid memory)
            //Logical Error
            //Occurs due to a mistake in logic
            //Program runs without crashing, but gives wrong output
            //Harder to detect because the code is syntactically and semantically correct

            //----------------------
            //String FullName;
            //int Age;
            //float MonthlySalary;
            //bool Student;
            //Q:Why is it important to follow naming conventions such as PascalCase in C#? 
            //1. Improves Readability 2. Enhances Consistency 3. Follows Community Standards 4. Aids in Collaboration

            //----------------------
            //Person p1 = new Person();
            //p1.Name = "Alice";

            //Person p2 = p1;

            //p2.Name = "Bob";

            //Console.WriteLine("p1.Name: " + p1.Name);
            //Console.WriteLine("p2.Name: " + p2.Name);
            //Q
            //Value Types	Reference Types
            // Stack        Heap(reference stored in stack)

            //----------------------
            //int x = 15;
            //int y = 4;
            //Console.WriteLine(x+y);
            //Console.WriteLine(x-y); 
            //Console.WriteLine(x*y);
            //Console.WriteLine(x/y);
            //Console.WriteLine(x%y);

            //Q:What will be the output of the following code? Explain why: 
            //int a = 2, b = 7;
            //Console.WriteLine(a % b);
            //2 --> because reminder of division will be 2

            //----------------------
            //Console.Write("Enter a number: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //if (number > 10 && number % 2 == 0)
            //{
            //    Console.WriteLine("The number is greater than 10 and even.");
            //}
            //else
            //{
            //    Console.WriteLine("The number does not meet both conditions.");
            //}
            //Q: How does the && (logical AND) operator differ from the & (bitwise AND) operator? 
            //Use && for logic, & for bits.

            //---------------------
            //Console.Write("Enter a double value: ");
            //double doubleValue = Convert.ToDouble(Console.ReadLine());

            //int intValue = (int)doubleValue;

            //double fromInt = intValue; 

            //Console.WriteLine("Original double value: " + doubleValue);
            //Console.WriteLine("After explicit cast to int: " + intValue);
            //Console.WriteLine("Implicit cast back to double: " + fromInt);

            //Q:Why is explicit casting required when converting a double to an int?
            //because:
            //It may cause data loss(e.g., fractional part is removed).
            //The compiler needs your permission to do this unsafe operation.

            //---------------------
            //Console.Write("Enter your age: ");
            //string input = Console.ReadLine();

            //try
            //{
            //    int age = int.Parse(input);

            //    if (age > 0)
            //    {
            //        Console.WriteLine("Valid age entered: " + age); 
            //    }
            //    else
            //    {
            //        Console.WriteLine("Age must be greater than 0.");
            //    }
            //}
            //catch (FormatException) 
            //{
            //    Console.WriteLine("Invalid input. Please enter a numeric value.");
            //}
            //Q:What exception might occur if the input is invalid and how can you handle it
            //Use a try-catch block:

            //---------------------
            //int x = 5;

            //int a = x++; 

            //int b = ++x; 

            //Console.WriteLine("After postfix (x++), a = " + a);
            //Console.WriteLine("After prefix (++x), b = " + b);
            //Console.WriteLine("Final value of x = " + x);
            //Q:Given the code below, what is the value of x after execution? Explain why 
            //int x = 5;
            //int y = ++x + x++;
            //x = 7  y = 12
            //++x increases x before using it.      x++ uses x before increasing it.
        }
    }
}
