using System;

namespace ConsoleApp1
{
    class Employee
    {
        public string Name { get; set; }
        public Department Department { get; set; }

        public Employee(string name, Department dept)
        {
            Name = name;
            Department = dept;
        }

        public override bool Equals(object obj)
        {
            if (obj is Employee other)
                return Name == other.Name && Department.Equals(other.Department);
            return false;
        }

        public override int GetHashCode() => (Name, Department).GetHashCode();

        public override string ToString() => $"{Name} - {Department}";
    }
}
