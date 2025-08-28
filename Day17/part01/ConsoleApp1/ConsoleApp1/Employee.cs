using System;

namespace ConsoleApp1
{
    public class Employee : ICloneable
    {
        public string Name { get; set; }
        public int Salary { get; set; }

        public Employee(string name, int salary)
        {
            Name = name;
            Salary = salary;
        }

        public override string ToString() => $"{Name} - {Salary}";

        public object Clone() => new Employee(Name, Salary);
    }

    public class Manager : Employee, IComparable<Manager>
    {
        public Manager(string name, int salary) : base(name, salary) { }

        public int CompareTo(Manager other) => this.Salary.CompareTo(other.Salary);
    }
}
