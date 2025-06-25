// Soru 7:
// Bir Temperature sınıfı tanımlayın. Celsius ve Fahrenheit özelliklerini kapsülleyin ve birbirine otomatik
// olarak dönüştürecek get ve set yöntemleri yazın.
using System;

public class Temperature
{
    // Sıcaklığı dahili olarak saklamak için private bir alan (field).
    // Temel birim olarak Celsius'u kullanıyoruz.
    private double celsius;

    // Celsius özelliği (property)
    public double Celsius
    {
        get
        {
            // Saklanan Celsius değerini doğrudan döndür.
            return this.celsius;
        }
        set
        {
            // Gelen değeri private alana ata.
            this.celsius = value;
        }
    }

    // Fahrenheit özelliği (property)
    public double Fahrenheit
    {
        get
        {
            // Saklanan Celsius değerini Fahrenheit'a çevir ve döndür.
            // Formül: F = C * (9/5) + 32
            return (this.celsius * 9 / 5) + 32;
        }
        set
        {
            // Gelen Fahrenheit değerini Celsius'a çevir ve private alanda sakla.
            // Formül: C = (F - 32) * (5/9)
            this.celsius = (value - 32) * 5 / 9;
        }
    }
}

// Sınıfın kullanımını gösteren ana program
public class Program
{
    public static void Main(string[] args)
    {
        Temperature temp = new Temperature();

        // 1. Celsius değerini ayarlayalım ve Fahrenheit karşılığını okuyalım.
        Console.WriteLine("Sıcaklık 25 C olarak ayarlanıyor...");
        temp.Celsius = 25;

        // Math.Round ile sonucu daha okunaklı hale getirelim.
        Console.WriteLine($"Celsius Değeri: {Math.Round(temp.Celsius, 2)}");
        Console.WriteLine($"Fahrenheit Karşılığı: {Math.Round(temp.Fahrenheit, 2)}"); // Otomatik olarak 77 F hesaplayacak.

        Console.WriteLine("\n-----------------------------------\n");

        // 2. Fahrenheit değerini ayarlayalım ve Celsius karşılığını okuyalım.
        Console.WriteLine("Sıcaklık 98.6 F olarak ayarlanıyor...");
        temp.Fahrenheit = 98.6; // Bu atama, private 'celsius' alanını otomatik güncelleyecek.

        Console.WriteLine($"Fahrenheit Değeri: {Math.Round(temp.Fahrenheit, 2)}");
        Console.WriteLine($"Celsius Karşılığı: {Math.Round(temp.Celsius, 2)}"); // Otomatik olarak 37 C hesaplayacak.
        
        Console.WriteLine("\n-----------------------------------\n");
        
        // 3. Suyun donma noktasını test edelim.
        Console.WriteLine("Sıcaklık 0 C olarak ayarlanıyor...");
        temp.Celsius = 0;
        
        Console.WriteLine($"Celsius Değeri: {Math.Round(temp.Celsius, 2)}");
        Console.WriteLine($"Fahrenheit Karşılığı: {Math.Round(temp.Fahrenheit, 2)}"); // Otomatik olarak 32 F hesaplayacak.
    }
}