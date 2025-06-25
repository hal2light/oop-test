// Soru 9: Employee sınıfını oluşturun. Bu sınıftan Manager ve Developer sınıflarını türetin. Her biri için
// CalculateSalary() metodunu farklı şekilde tanımlayın.

using System;
using System.Collections.Generic;

// 1. Temel Sınıf (Base Class)
public class Employee
{
    public string Name { get; set; }
    public double BaseSalary { get; set; }

    // Yapıcı Metot (Constructor)
    public Employee(string name, double baseSalary)
    {
        this.Name = name;
        this.BaseSalary = baseSalary;
    }

    // Maaş hesaplama metodunu "virtual" olarak tanımlıyoruz.
    // Bu, türetilmiş sınıfların bu metodu kendi ihtiyaçlarına göre ezmesine (override) izin verir.
    // Varsayılan olarak sadece temel maaşı döndürür.
    public virtual double CalculateSalary()
    {
        return this.BaseSalary;
    }
}

// 2. Türetilmiş Sınıf: Manager
// Employee sınıfından kalıtım alıyor.
public class Manager : Employee
{
    // Yöneticiye özel ek bir özellik: Yönetim Bonusu
    public double ManagementBonus { get; set; }

    // Temel sınıfın yapıcı metodunu "base" anahtar kelimesiyle çağırıyoruz.
    public Manager(string name, double baseSalary, double managementBonus) : base(name, baseSalary)
    {
        this.ManagementBonus = managementBonus;
    }

    // Temel sınıftaki CalculateSalary metodunu "override" ediyoruz.
    // Yöneticinin maaşı = Temel Maaş + Yönetim Bonusu
    public override double CalculateSalary()
    {
        return this.BaseSalary + this.ManagementBonus;
    }
}

// 3. Türetilmiş Sınıf: Developer
// Employee sınıfından kalıtım alıyor.
public class Developer : Employee
{
    // Geliştiriciye özel ek bir özellik: Proje Bonusu
    public double ProjectBonus { get; set; }

    // Temel sınıfın yapıcı metodunu çağırıyoruz.
    public Developer(string name, double baseSalary, double projectBonus) : base(name, baseSalary)
    {
        this.ProjectBonus = projectBonus;
    }

    // Temel sınıftaki CalculateSalary metodunu "override" ediyoruz.
    // Geliştiricinin maaşı = Temel Maaş + Proje Bonusu
    public override double CalculateSalary()
    {
        return this.BaseSalary + this.ProjectBonus;
    }
}

// Sınıfların kullanımını gösteren ana program
public class Program
{
    public static void Main(string[] args)
    {
        // Manager ve Developer nesneleri oluşturalım.
        Manager manager = new Manager("Ayşe Yılmaz", 15000, 5000);
        Developer developer = new Developer("Ahmet Kaya", 12000, 2500);

        Console.WriteLine("--- Bireysel Maaş Hesaplamaları ---");
        Console.WriteLine($"{manager.Name} (Yönetici) Maaşı: {manager.CalculateSalary():C}"); // Çıktı: 20,000.00 ₺
        Console.WriteLine($"{developer.Name} (Geliştirici) Maaşı: {developer.CalculateSalary():C}"); // Çıktı: 14,500.00 ₺

        Console.WriteLine("\n--- Polimorfizm ile Maaş Bordrosu ---");
        // Employee tipinde bir liste oluşturup tüm çalışanları ekleyelim.
        List<Employee> employees = new List<Employee>
        {
            manager,
            developer,
            new Employee("Ali Veli", 8000) // Normal bir çalışan
        };

        // Liste üzerinde döngü ile tüm çalışanların maaşlarını hesaplayalım.
        // Program, her çalışanın tipine (Manager, Developer, Employee) göre
        // doğru CalculateSalary() metodunu kendisi çalıştırır.
        foreach (var employee in employees)
        {
            Console.WriteLine($"{employee.Name} rolündeki çalışanın maaşı: {employee.CalculateSalary():C}");
        }
    }
}