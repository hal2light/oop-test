// Rectangle sınıfı oluşturun. Width ve Height değişkenleri private olmalı. Kullanıcının dikdörtgen alanını
// alabileceği bir GetArea() metodu tanımlayın. 
using System;

// Rectangle sınıfı tanımı
public class Rectangle
{
    // Private (özel) değişkenler
    private double width;
    private double height;

    // Genişlik ve yüksekliği ayarlamak için bir yapıcı (constructor) metot
    public Rectangle(double width, double height)
    {
        // Girilen değerlerin negatif olmamasını sağlamak için kontrol
        if (width > 0 && height > 0)
        {
            this.width = width;
            this.height = height;
        }
        else
        {
            // Geçersiz değerler için varsayılan olarak 0 ataması yapılıyor
            this.width = 0;
            this.height = 0;
            Console.WriteLine("Genişlik ve yükseklik pozitif bir değer olmalıdır.");
        }
    }

    // Dikdörtgenin alanını hesaplayan ve döndüren public metot
    public double GetArea()
    {
        // Alan = Genişlik * Yükseklik
        return this.width * this.height;
    }
}

// Sınıfın kullanımını gösteren ana program
public class Program
{
    public static void Main(string[] args)
    {
        // Rectangle sınıfından bir nesne (örnek) oluşturuluyor
        // Genişlik: 10, Yükseklik: 5
        Rectangle myRectangle = new Rectangle(10, 5);

        // GetArea() metodu kullanılarak alan hesaplanıyor
        double area = myRectangle.GetArea();

        // Sonuç ekrana yazdırılıyor
        Console.WriteLine("Dikdörtgenin Alanı: " + area); // Çıktı: Dikdörtgenin Alanı: 50

        // Geçersiz bir değerle nesne oluşturma denemesi
        Rectangle invalidRectangle = new Rectangle(5, 10);
        double invalidArea = invalidRectangle.GetArea();
        Console.WriteLine("Geçersiz Dikdörtgenin Alanı: " + invalidArea); // Çıktı: Geçersiz Dikdörtgenin Alanı: 0
    }
}