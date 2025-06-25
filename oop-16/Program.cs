// // Soru 16: StudentInfo sınıfında DisplayInfo() metodunu:
//  İsim ile,
//  İsim ve yaş ile,
//  İsim, yaş ve okul adı ile olacak şekilde aşırı yükleyin.

using System;

class StudentInfo
{
    // Sadece isim parametreli versiyon
    public void DisplayInfo(string name)
    {
        Console.WriteLine($"İsim: {name}");
    }

    // İsim ve yaş parametreli versiyon
    public void DisplayInfo(string name, int age)
    {
        Console.WriteLine($"İsim: {name}, Yaş: {age}");
    }

    // İsim, yaş ve okul adı parametreli versiyon
    public void DisplayInfo(string name, int age, string school)
    {
        Console.WriteLine($"İsim: {name}, Yaş: {age}, Okul: {school}");
    }
}

// Test sınıfı
class Program
{
    static void Main()
    {
        StudentInfo student = new StudentInfo();

        student.DisplayInfo("Ahmet");
        student.DisplayInfo("Ayşe", 20);
        student.DisplayInfo("Mehmet", 22, "Ankara Üniversitesi");
    }
}