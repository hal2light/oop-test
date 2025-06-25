// Soru 12: Book sınıfı tanımlayın ve EBook, PrintedBook adlı iki sınıfı ondan kalıtım yoluyla oluşturun. Her
// sınıf GetFormat() metodunu override etsin.

using System;

class Book
{
    // Sanal metod: Alt sınıflar isterse override edebilir
    public virtual string GetFormat()
    {
        return "Bilinmeyen format";
    }
}

class EBook : Book
{
    public override string GetFormat()
    {
        return "Dijital E-Kitap (PDF, EPUB, vb.)";
    }
}

class PrintedBook : Book
{
    public override string GetFormat()
    {
        return "Basılı Kitap (Kağıt)";
    }
}

// Test sınıfı
class Program
{
    static void Main()
    {
        Book genericBook = new Book();
        Book ebook = new EBook();
        Book printedBook = new PrintedBook();

        Console.WriteLine($"Kitap Formatı: {genericBook.GetFormat()}");
        Console.WriteLine($"Kitap Formatı: {ebook.GetFormat()}");
        Console.WriteLine($"Kitap Formatı: {printedBook.GetFormat()}");
    }
}