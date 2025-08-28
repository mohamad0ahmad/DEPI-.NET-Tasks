using System;

namespace ConsoleApp1
{
    class Person
    {
        public string Name { get; set; }
        public string Department { get; set; }

        public Person(string name, string dept)
        {
            Name = name;
            Department = dept;
        }

        public virtual void Display()
        {
            Console.WriteLine($"{Name} - {Department}");
        }
    }
}
