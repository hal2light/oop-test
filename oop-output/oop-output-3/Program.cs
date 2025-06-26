class A
{
    public A()
    {
        Console.WriteLine("A Constructor");
    }
}
class B : A
{
    public B()
    {
        Console.WriteLine("B Constructor");
    }
}
class Program
{
    static void Main()
    {
        B obj = new B();
    }
}
//Output:
// A Constructor
// B Constructor