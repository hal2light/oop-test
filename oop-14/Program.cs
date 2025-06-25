// Soru 14: PrintMessage() isimli bir metod tanımlayın. Sırasıyla 1, 2 ve 3 string parametre alan versiyonlarını
// overload edin.
using System;

class MessagePrinter
{
    // 1 string parametreli versiyon
    public void PrintMessage(string msg1)
    {
        Console.WriteLine($"Mesaj: {msg1}");
    }

    // 2 string parametreli versiyon
    public void PrintMessage(string msg1, string msg2)
    {
        Console.WriteLine($"Mesaj 1: {msg1}");
        Console.WriteLine($"Mesaj 2: {msg2}");
    }

    // 3 string parametreli versiyon
    public void PrintMessage(string msg1, string msg2, string msg3)
    {
        Console.WriteLine($"Mesaj 1: {msg1}");
        Console.WriteLine($"Mesaj 2: {msg2}");
        Console.WriteLine($"Mesaj 3: {msg3}");
    }
}

// Test sınıfı
class Program
{
    static void Main()
    {
        MessagePrinter printer = new MessagePrinter();

        printer.PrintMessage("Selam!");
        printer.PrintMessage("Nasılsın?", "İyi misin?");
        printer.PrintMessage("Bugün hava güzel.", "Sıcaklık yüksek.", "Şemsiyeni unutma!");
    }
}