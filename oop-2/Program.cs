// Soru 2: Employee sınıfından kalıtım alan Manager ve Developer sınıflarını yazınız.
// Her birinin CalculateSalary() metodu farklı maaş hesaplasın.

using System;

public class Employee
{
    public string Name { get; set; }
    public int BaseSalary { get; set; }

    public Employee(string name, int baseSalary)
    {
        Name = name;
        BaseSalary = baseSalary;
    }

    // Virtual method to be overridden
    public virtual int CalculateSalary()
    {
        return BaseSalary;
    }
}

public class Manager : Employee
{
    public int Bonus { get; set; }

    public Manager(string name, int baseSalary, int bonus)
        : base(name, baseSalary)
    {
        Bonus = bonus;
    }

    public override int CalculateSalary()
    {
        // Manager's salary includes a bonus
        return BaseSalary + Bonus;
    }
}

public class Developer : Employee
{
    public int OvertimeHours { get; set; }
    public int HourlyRate { get; set; }

    public Developer(string name, int baseSalary, int overtimeHours, int hourlyRate)
        : base(name, baseSalary)
    {
        OvertimeHours = overtimeHours;
        HourlyRate = hourlyRate;
    }

    public override int CalculateSalary()
    {
        // Developer's salary includes overtime payment
        return BaseSalary + (OvertimeHours * HourlyRate);
    }
}
class Program
{
    static void Main()
    {
        Manager manager = new Manager("Ali", 10000, 3000);
        Developer developer = new Developer("Ayşe", 8000, 10, 150);

        Console.WriteLine($"{manager.Name} maaşı: {manager.CalculateSalary()} TL");
        Console.WriteLine($"{developer.Name} maaşı: {developer.CalculateSalary()} TL");
    }
}