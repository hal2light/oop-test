// Soru 1: Aşağıdaki gereksinimleri karşılayan bir C# sınıf yapısı oluşturunuz:
// Person adında bir sınıf tanımlanacak. Bu sınıfta Name ve Age adında iki özellik olacak.
// Bu sınıftan Student adlı sınıf türetilecek ve ek olarak SchoolName özelliği olacak.
// ToString() metodu override edilecek ve kişinin bilgileri döndürülecek.
class Program
{
    static void Main()
    {
        Student ogrenci = new Student
        {
            Name = "Berken",
            Age = 21,
            SchoolName = "Dokuz Eylul Universitesi"
        };

        Console.WriteLine(ogrenci.ToString());
    }
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"Ad: {Name}, Yas:{Age} ";
        }
    }

    public class Student : Person
    {
        public string SchoolName { get; set; }
        public override string ToString()
        {
            return base.ToString() + $", Okul: {SchoolName}"; 
        }
    }
}