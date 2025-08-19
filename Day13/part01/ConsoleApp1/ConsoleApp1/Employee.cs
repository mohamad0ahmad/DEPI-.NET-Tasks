using System;

struct Employee
{
    private int EmpId;
    private string Name;
    private decimal Salary;

    public Employee(int id, string name, decimal salary)
    {
        EmpId = id;
        Name = name;
        Salary = salary;
    }

    public string GetName() => Name;
    public void SetName(string value)
    {
        Name = value.Length <= 10 ? value : value.Substring(0, 10);
    }

    public decimal EmpSalary
    {
        get { return Salary; }
        set { Salary = value < 3000 ? 3000 : value; }
    }

    public override string ToString()
    {
        return $"Id={EmpId}, Name={Name}, Salary={Salary}";
    }
}

