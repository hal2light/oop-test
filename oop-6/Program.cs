// Soru 6:
// Student sınıfında Grade isimli bir özelliği 0-100 aralığında sınırlandırarak tanımlayın. Yanlış girişlerde hata
// mesajı verin.

using System;

public class Student
{
    // Notu saklamak için private bir alan (field)
    private int grade;

    // Grade (Not) için public bir özellik (property)
    public int Grade
    {
        // Değeri okumak için 'get' bloğu
        get
        {
            return this.grade;
        }
        // Değeri atamak için 'set' bloğu
        set
        {
            // Atanmak istenen değer (value) 0 ile 100 arasında mı diye kontrol edilir.
            if (value >= 0 && value <= 100)
            {
                // Değer geçerliyse, private alana ata.
                this.grade = value;
            }
            else
            {
                // Değer geçersizse, hata mesajı ver.
                Console.WriteLine("Hata: Not değeri 0 ile 100 arasında olmalıdır.");
            }
        }
    }

    // Öğrenci bilgilerini yazdırmak için bir metot
    public void DisplayStudentInfo()
    {
        Console.WriteLine($"Öğrencinin Notu: {this.Grade}");
    }
}

// Sınıfın kullanımını gösteren ana program
public class Program
{
    public static void Main(string[] args)
    {
        // Student sınıfından bir nesne oluşturuluyor
        Student student1 = new Student();

        // 1. Geçerli bir not ataması yapılıyor
        Console.WriteLine("Geçerli bir not (85) atanıyor...");
        student1.Grade = 85;
        student1.DisplayStudentInfo(); // Çıktı: Öğrencinin Notu: 85

        Console.WriteLine("\n-----------------------------------\n");

        // 2. Geçersiz bir not ataması (100'den büyük) deneniyor
        Console.WriteLine("Geçersiz bir not (105) atanmaya çalışılıyor...");
        student1.Grade = 105; // Bu satır hata mesajını tetikleyecek
        student1.DisplayStudentInfo(); // Çıktı: Öğrencinin Notu: 85 (değer değişmedi)

        Console.WriteLine("\n-----------------------------------\n");

        // 3. Geçersiz bir not ataması (0'dan küçük) deneniyor
        Console.WriteLine("Geçersiz bir not (-10) atanmaya çalışılıyor...");
        student1.Grade = -10; // Bu satır da hata mesajını tetikleyecek
        student1.DisplayStudentInfo(); // Çıktı: Öğrencinin Notu: 85 (değer hala değişmedi)
    }
}