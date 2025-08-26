﻿namespace ConsoleApp1
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Grade { get; set; }

        public Student(int id, string name, string grade)
        {
            Id = id; Name = name; Grade = grade;
        }


        public Student(Student other)
        {
            Id = other.Id;
            Name = string.Copy(other.Name);
            Grade = string.Copy(other.Grade);
        }
    }
}
