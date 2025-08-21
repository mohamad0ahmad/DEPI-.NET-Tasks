using System;
using System.Drawing;
using System.Runtime.ConstrainedExecution;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            // car
            Car c1 = new Car();
            Car c2 = new Car(1);
            Car c3 = new Car(2, "Toyota");
            Car c4 = new Car(3, "BMW", 50000);
            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine(c4);

            // ------------------------------ //
            Calculator calc = new Calculator();
            Console.WriteLine(calc.Sum(2, 3));
            Console.WriteLine(calc.Sum(1, 2, 3));
            Console.WriteLine(calc.Sum(2.5, 3.5));

            // ------------------------------ //
            Child child = new Child(2, 3, 4);
            Console.WriteLine("Product: " + child.Product());
            Console.WriteLine(child);

            // ------------------------------ //
            IShape rect = new RectangleShape(4, 5);
            rect.PrintDetails();

            IShape circle = new Circle(3);
            circle.PrintDetails();

            // ------------------------------ //
            IMovable mCar = new MovableCar();
            mCar.Move();

            // ------------------------------ //
            File file = new File();
            file.Read();
            file.Write();

            // ------------------------------ //
            Shape s = new Rectangle(5, 10);
            s.Draw();
            Console.WriteLine("Area: " + s.CalculateArea());
        }
    }
}
