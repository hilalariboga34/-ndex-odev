using System;

class SatrancTahtasi
{
    private string[,] tahtadakiTaslar = new string[8, 8];

    public string this[int satir, int sutun]
    {
        get
        {
            if (satir < 0 || satir >= 8 || sutun < 0 || sutun >= 8)
                return "Geçersiz kare! Lütfen 0-7 arasında bir koordinat girin.";
            return tahtadakiTaslar[satir, sutun] ?? "Bu kare boş.";
        }
        set
        {
            if (satir < 0 || satir >= 8 || sutun < 0 || sutun >= 8)
                Console.WriteLine("Geçersiz kare! Lütfen 0-7 arasında bir koordinat girin.");
            else
                tahtadakiTaslar[satir, sutun] = value;
        }
    }

    static void Main(string[] args)
    {
        SatrancTahtasi satrancTahtasi = new SatrancTahtasi();
        satrancTahtasi[0, 0] = "Kale";
        satrancTahtasi[0, 1] = "At";

        Console.WriteLine(satrancTahtasi[0, 0]); // Kale
        Console.WriteLine(satrancTahtasi[7, 7]); // Bu kare boş.
        Console.WriteLine(satrancTahtasi[8, 8]); // Geçersiz kare!
    }
}
