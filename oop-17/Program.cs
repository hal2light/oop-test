// Soru 17:
// ComplexNumber sınıfı oluşturun. + operatörünü iki kompleks sayıyı toplamak için aşırı yükleyin.

using System;

class ComplexNumber
{
    public double Real { get; set; }    // Gerçek kısım
    public double Imaginary { get; set; } // Sanal kısım

    public ComplexNumber(double real, double imaginary)
    {
        Real = real;
        Imaginary = imaginary;
    }

    // + operatörünün aşırı yüklenmesi
    public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
    {
        return new ComplexNumber(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
    }

    // Kompleks sayıyı string olarak göstermek için
    public override string ToString()
    {
        return $"{Real} + {Imaginary}i";
    }
}

// Test sınıfı
class Program
{
    static void Main()
    {
        ComplexNumber num1 = new ComplexNumber(3, 4);
        ComplexNumber num2 = new ComplexNumber(1, 2);

        ComplexNumber result = num1 + num2;

        Console.WriteLine($"Birinci Sayı: {num1}");
        Console.WriteLine($"İkinci Sayı: {num2}");
        Console.WriteLine($"Toplam: {result}");
    }
}