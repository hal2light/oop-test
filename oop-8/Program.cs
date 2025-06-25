// Soru 8: Vehicle adında bir sınıf oluşturun. Bu sınıftan türeyen Car ve Bicycle sınıflarını yazın. Her sınıfın
// Drive() metodunu kendine özgü olacak şekilde override edin.

using System;
using System.Collections.Generic;

// 1. Temel Sınıf (Base Class)
public class Vehicle
{
    // Drive metodunu "virtual" olarak tanımlıyoruz.
    // Bu, türetilmiş sınıfların bu metodu override etmesine (ezmesine) olanak tanır.
    public virtual void Drive()
    {
        Console.WriteLine("Araç hareket ediyor.");
    }
}

// 2. Türetilmiş Sınıf: Car
// Vehicle sınıfından kalıtım alıyor (miras alıyor).
public class Car : Vehicle
{
    // Temel sınıftaki Drive metodunu "override" ediyoruz.
    // Bu metot çağrıldığında Car sınıfına özgü işlem yapılacak.
    public override void Drive()
    {
        Console.WriteLine("Araba motoru çalıştırılarak sürülüyor.");
    }
}

// 3. Türetilmiş Sınıf: Bicycle
// Vehicle sınıfından kalıtım alıyor.
public class Bicycle : Vehicle
{
    // Temel sınıftaki Drive metodunu "override" ediyoruz.
    public override void Drive()
    {
        Console.WriteLine("Bisiklet pedalları çevrilerek sürülüyor.");
    }
}

// Sınıfların kullanımını gösteren ana program
public class Program
{
    public static void Main(string[] args)
    {
        // Her sınıftan birer nesne oluşturalım.
        Vehicle myVehicle = new Vehicle();
        Car myCar = new Car();
        Bicycle myBicycle = new Bicycle();

        Console.WriteLine("--- Bireysel Nesne Çağrıları ---");
        myVehicle.Drive();  // Temel sınıfın metodu çağrılır.
        myCar.Drive();      // Car sınıfının override ettiği metot çağrılır.
        myBicycle.Drive();  // Bicycle sınıfının override ettiği metot çağrılır.

        Console.WriteLine("\n--- Polimorfizm ile Gösterim ---");
        // Vehicle tipinde bir liste oluşturup içine farklı türde nesneler ekleyelim.
        List<Vehicle> vehicles = new List<Vehicle>
        {
            new Vehicle(),
            new Car(),
            new Bicycle()
        };

        // Liste üzerinde döngü ile tüm araçları "sürelim".
        // Program, her nesnenin gerçek tipine (Car, Bicycle vb.) bakarak
        // doğru Drive() metodunu kendisi bulup çalıştırır.
        foreach (var vehicle in vehicles)
        {
            vehicle.Drive();
        }
    }
}