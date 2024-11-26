using System;

class Kitaplik
{
    private string[] kitaplar;

    public Kitaplik(int kapasite)
    {
        kitaplar = new string[kapasite];
    }

    public string this[int indeks]
    {
        get
        {
            if (indeks < 0 || indeks >= kitaplar.Length)
                return "Geçersiz indeks! Lütfen doğru bir indeks girin.";
            return kitaplar[indeks] ?? "Bu indeks boş.";
        }
        set
        {
            if (indeks < 0 || indeks >= kitaplar.Length)
                Console.WriteLine("Geçersiz indeks! Lütfen doğru bir indeks girin.");
            else
                kitaplar[indeks] = value;
        }
    }

    static void Main(string[] args)
    {
        Kitaplik kitaplik = new Kitaplik(5);
        kitaplik[0] = "Simyacı";
        kitaplik[1] = "1984";

        Console.WriteLine(kitaplik[0]); // Simyacı
        Console.WriteLine(kitaplik[3]); // Bu indeks boş.
        Console.WriteLine(kitaplik[10]); // Geçersiz indeks!
    }
}
