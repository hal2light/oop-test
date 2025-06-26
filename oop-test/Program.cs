class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }
    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }
    public double Add(double a, double b)
    {
        return a + b;
    }
}

class Program
{
    public static void Main()
    {
        Calculator calculator = new Calculator();

        Console.WriteLine(calculator.Add(2, 2));
        Console.WriteLine(calculator.Add(2, 2, 5));
        Console.WriteLine(calculator.Add(2.2, 2.2));
        
    }
}