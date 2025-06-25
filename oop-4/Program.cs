// Soru 4:
// Person sınıfında Name ve Age alanlarını private olarak tanımlayın. Bu alanlara erişim için get ve set
// metodları tanımlayın. Age değeri negatif girilirse, 0 atanmalı.

public class Person
{
    private string name;
    private int age;

    // Name özelliği
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    // Age özelliği, negatif girilirse 0 atanır
    public int Age
    {
        get { return age; }
        set
        {
            if (value < 0)
                age = 0;
            else
                age = value;
        }
    }
}

class Program
{
    static void Main()
    {
        Person person = new Person();

        person.Name = "Zeynep";
        person.Age = -5;  // Negatif değer verildiğinde 0 atanır

        Console.WriteLine($"Ad: {person.Name}");
        Console.WriteLine($"Yaş: {person.Age}");  // 0 yazdırır
    }
}