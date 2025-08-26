using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.ConstrainedExecution;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problem 1
            IVehicle car = new Car();
            IVehicle bike = new Bike();
            car.StartEngine();
            car.StopEngine();
            bike.StartEngine();
            bike.StopEngine();

            Console.WriteLine("--------------------------------------------------");

            // Problem 2
            Shape rect = new Rectangle(5, 10);
            Shape circle = new Circle(7);
            rect.Display();
            circle.Display();

            Console.WriteLine("--------------------------------------------------");

            // Problem 3
            Product[] products = {
                new Product(1, "Laptop", 800),
                new Product(2, "Phone", 600),
                new Product(3, "Tablet", 400)
            };
            Array.Sort(products);
            foreach (var p in products)
            {
                Console.WriteLine($"{p.Id} - {p.Name} - ${p.Price}");
            }

            Console.WriteLine("--------------------------------------------------");

            // Problem 4
            Student s1 = new Student(1, "Ali", "A");
            Student s2 = new Student(s1); 
            s2.Name = "Omar"; 
            Console.WriteLine($"Original: {s1.Name}, Copy: {s2.Name}");

            Console.WriteLine("--------------------------------------------------");

            // Problem 5
            Robot robot = new Robot();
            robot.Walk(); 
            IWalkable walkableRobot = robot;
            walkableRobot.Walk(); 

            Console.WriteLine("--------------------------------------------------");

            // Problem 6
            Account acc = new Account(101, "Mohamed", 5000);
            Console.WriteLine($"Account Holder: {acc.AccountHolder}, Balance: {acc.Balance}");

            Console.WriteLine("--------------------------------------------------");

            // Problem 7
            Book b1 = new Book();
            Book b2 = new Book("C# Programming");
            Book b3 = new Book("OOP in C#", "John Doe");
            Console.WriteLine($"{b1.Title}, {b2.Title}, {b3.Title} by {b3.Author}");
        }
    }
}
