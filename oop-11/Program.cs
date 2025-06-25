// Soru 11: Animal adında bir sınıf tanımlayın. MakeSound() sanal metodunu Dog ve Cat sınıflarında farklı
// seslerle override edin.
using System;

class Animal
{
    // Sanal metod (virtual), istersek alt sınıflarda override edebiliriz
    public virtual void MakeSound()
    {
        Console.WriteLine("Hayvan bir ses çıkarıyor.");
    }
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Hav Hav!");
    }
}

class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Miyav!");
    }
}

// Test sınıfı
class Program
{
    static void Main()
    {
        Animal animal = new Animal();
        Animal dog = new Dog();
        Animal cat = new Cat();

        animal.MakeSound();  // Hayvan bir ses çıkarıyor.
        dog.MakeSound();     // Hav Hav!
        cat.MakeSound();     // Miyav!
    }
}