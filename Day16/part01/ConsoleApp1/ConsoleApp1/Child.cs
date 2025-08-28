using System;

namespace ConsoleApp1
{
    class Parent
    {
        public string Name { get; set; }
        public virtual int Salary { get; set; }
    }

    class Child : Parent
    {
        public sealed override int Salary { get; set; }

        public void DisplaySalary()
        {
            Console.WriteLine($"{Name}'s Salary = {Salary}");
        }
    }
}
