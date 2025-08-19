using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
            Point p2 = new Point(5, 7);
            Console.WriteLine(p1);
            Console.WriteLine(p2);

            //------------------
            TypeA obj = new TypeA();
            obj.PrintInside();


            Console.WriteLine($"Access Internal: {obj.G}");
            Console.WriteLine($"Access Public: {obj.H}");

            //-------------------------

            Employee e1 = new Employee(1, "Mohamed", 2500);
            Console.WriteLine(e1);

            e1.SetName("Abdelrahman");
            e1.EmpSalary = 2000;
            Console.WriteLine(e1.GetName());
            Console.WriteLine(e1.EmpSalary);

            //---------------------------
            Point2 p3 = new Point2(5);
            Point2 p4 = new Point2(3, 7);
            Console.WriteLine(p3); 
            Console.WriteLine(p4);

            //--------------------

            Point p5 = new Point(1, 2);
            Point p6 = new Point(10, 20);
            Point p7 = new Point(-5, 15);

            Console.WriteLine(p5);
            Console.WriteLine(p6);
            Console.WriteLine(p7);
        }
    }
}
