// Soru 13: MathOperations sınıfında Add() metodunu 2 int, 2 double ve 3 int parametrelerle aşırı yükleyin.
using System;

class MathOperations
{
    // 2 adet int parametre
    public int Add(int a, int b)
    {
        return a + b;
    }

    // 2 adet double parametre
    public double Add(double a, double b)
    {
        return a + b;
    }

    // 3 adet int parametre
    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }
}

// Test sınıfı
class Program
{
    static void Main()
    {
        MathOperations math = new MathOperations();

        int sum1 = math.Add(3, 5);           // 2 int parametre
        double sum2 = math.Add(2.5, 4.8);    // 2 double parametre
        int sum3 = math.Add(1, 2, 3);        // 3 int parametre

        Console.WriteLine($"Toplam (int, int): {sum1}");
        Console.WriteLine($"Toplam (double, double): {sum2}");
        Console.WriteLine($"Toplam (int, int, int): {sum3}");
    }
}