// Soru 2: Aşağıdaki sınıf yapısında hangi OOP kavramları kullanılmaktadır? Açıklayınız.

interface IMovable
{
    void Move();
}
abstract class Vehicle
{
    public abstract void Start();
}
class Car : Vehicle, IMovable
{
    public override void Start() => Console.WriteLine("Car starting...");
    public void Move() => Console.WriteLine("Car is moving.");
}

//Cevap:
// Soyutlama (Abstraction)
// Kalıtım (Inheritance)
// Çok Biçimlilik (Polymorphism)
// Interface (Arayüz Kullanımı)

