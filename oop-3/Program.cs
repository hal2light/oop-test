// BankAccount adında bir sınıf yazın. Balance alanı dışarıdan doğrudan erişilememeli, sadece Deposit ve
// Withdraw metodları ile değiştirilmelidir.

using System;

public class BankAccount
{
    private decimal balance;  // dışarıdan erişilemeyen alan

    public BankAccount(decimal initialBalance = 0)
    {
        if (initialBalance >= 0)
            balance = initialBalance;
        else
            throw new ArgumentException("Başlangıç bakiyesi negatif olamaz.");
    }

    // Bakiyeyi döndüren sadece okuma özelliği
    public decimal GetBalance()
    {
        return balance;
    }

    // Para yatırma metodu
    public void Deposit(decimal amount)
    {
        if (amount > 0)
            balance += amount;
        else
            throw new ArgumentException("Yatırılacak miktar pozitif olmalıdır.");
    }

    // Para çekme metodu
    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Çekilecek miktar pozitif olmalıdır.");
        if (amount > balance)
            throw new InvalidOperationException("Yetersiz bakiye.");

        balance -= amount;
    }
}

class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount(1000);  // 1000 TL başlangıç

        account.Deposit(500);  // 500 TL yatır
        account.Withdraw(300); // 300 TL çek

        Console.WriteLine($"Mevcut bakiye: {account.GetBalance()} TL");
    }
}