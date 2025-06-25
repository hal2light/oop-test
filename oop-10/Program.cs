// Soru 10: Shape adlı soyut bir sınıf yazın. GetArea() isimli soyut bir metod içersin. Circle ve Square sınıfları
// bu metodu override etsin.

using System;

abstract class Shape
{
    // Soyut metod: Alt sınıflar mutlaka override etmek zorunda
    public abstract double GetArea();
}

// Daire sınıfı
class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}

// Kare sınıfı
class Square : Shape
{
    public double SideLength { get; set; }

    public Square(double sideLength)
    {
        SideLength = sideLength;
    }

    public override double GetArea()
    {
        return SideLength * SideLength;
    }
}

// Test sınıfı
class Program
{
    static void Main()
    {
        Shape circle = new Circle(5);
        Shape square = new Square(4);

        Console.WriteLine($"Dairenin Alanı: {circle.GetArea():F2}");
        Console.WriteLine($"Karenin Alanı: {square.GetArea():F2}");
    }
}