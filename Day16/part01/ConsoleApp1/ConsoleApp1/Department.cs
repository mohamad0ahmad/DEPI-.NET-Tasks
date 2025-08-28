namespace ConsoleApp1
{
    class Department
    {
        public string DeptName { get; set; }

        public Department(string name) => DeptName = name;

        public override bool Equals(object obj)
        {
            return obj is Department d && d.DeptName == DeptName;
        }

        public override int GetHashCode() => DeptName.GetHashCode();

        public override string ToString() => DeptName;
    }
}
