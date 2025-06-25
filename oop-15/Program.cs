// Soru 15: AreaCalculator sınıfında:
//  CalculateArea(double radius) → daire alanı
//  CalculateArea(double width, double height) → dikdörtgen alanı
//  CalculateArea(int side) → kare alanı
// şeklinde 3 overload tanımlayın.

using System;

class AreaCalculator
{
    // Daire alanı: π * r^2
    public double CalculateArea(double radius)
    {
        return Math.PI * radius * radius;
    }

    // Dikdörtgen alanı: genişlik * yükseklik
    public double CalculateArea(double width, double height)
    {
        return width * height;
    }

    // Kare alanı: kenar * kenar
    public int CalculateArea(int side)
    {
        return side * side;
    }
}

// Test sınıfı
class Program
{
    static void Main()
    {
        AreaCalculator calculator = new AreaCalculator();

        double circleArea = calculator.CalculateArea(5.0);          // Daire alanı
        double rectangleArea = calculator.CalculateArea(4.0, 6.0); // Dikdörtgen alanı
        int squareArea = calculator.CalculateArea(3);              // Kare alanı

        Console.WriteLine($"Daire Alanı: {circleArea:F2}");
        Console.WriteLine($"Dikdörtgen Alanı: {rectangleArea:F2}");
        Console.WriteLine($"Kare Alanı: {squareArea}");
    }
}