class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Animal speaks");
    }
}
class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Dog barks");
    }
}
class Program
{
    static void Main()
    {
        Animal a = new Dog();
        a.Speak();
    }
}

//Output: Dog barks