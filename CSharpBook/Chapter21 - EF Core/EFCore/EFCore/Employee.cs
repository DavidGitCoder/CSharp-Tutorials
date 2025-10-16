using Azure;
using Microsoft.Identity.Client;
using System.Runtime.Intrinsics.X86;
namespace AutoLot;

internal partial class Employee
{
    public Employee() { }
    public Employee(string name, int id, float pay) : this(name, 0, id, pay, "--", EmployeePayTypeEnum.Salaried, new DateTime(250420251000)) { }
    public Employee(string name, int age, int id, float pay, string ssn, EmployeePayTypeEnum paytype, DateTime hiredate)
    {
        Name = name;
        Age = age;
        Pay = pay;
        Id = id;
        SSN = ssn;
        PayType = paytype;
        HireDate = hiredate;
    }
    public void GiveBonus(float amount)
    {
        Pay = this switch
        {
            { HireDate.Year: > 2020, Age: >= 18, PayType: EmployeePayTypeEnum.Hourly } => Pay += 40F * amount / 2080F,
            { Age: >= 18, PayType: EmployeePayTypeEnum.Commission } => Pay += .10F * amount,
            { Age: >= 18, PayType: EmployeePayTypeEnum.Salaried } => Pay += amount,
            _ => Pay += 500
        };
    }
    public void DisplayStats()
    {
        Console.WriteLine($"Id: {Id}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Pay: {Pay}");
        Console.WriteLine($"PayType: {PayType}");
        Console.WriteLine($"hireDate: {HireDate.Year}");

    }
}

