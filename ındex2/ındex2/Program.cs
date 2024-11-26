using System;
using System.Collections.Generic;

class NotSistemi
{
    private Dictionary<string, int> dersNotlari = new Dictionary<string, int>();

    public int this[string ders]
    {
        get
        {
            if (!dersNotlari.ContainsKey(ders))
            {
                Console.WriteLine("Ders bulunamadı!");
                return -1; // Hata durumunda -1 döndürülür
            }
            return dersNotlari[ders];
        }
        set
        {
            dersNotlari[ders] = value;
        }
    }

    static void Main(string[] args)
    {
        NotSistemi notSistemi = new NotSistemi();
        notSistemi["Matematik"] = 95;
        notSistemi["Fizik"] = 85;

        Console.WriteLine(notSistemi["Matematik"]); // 95
        Console.WriteLine(notSistemi["Kimya"]); // Ders bulunamadı!
    }
}
