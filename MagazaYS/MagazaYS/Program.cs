using System;
using System.Collections.Generic;

abstract class Urun
{
    public string Ad { get; set; }
    public decimal Fiyat { get; set; }

    public abstract decimal HesaplaOdeme();
    public abstract void BilgiYazdir();
}

class Kitap : Urun
{
    public string Yazar { get; set; }

    public override decimal HesaplaOdeme()
    {
        return Fiyat + (Fiyat * 0.10m); // %10 vergi
    }

    public override void BilgiYazdir()
    {
        Console.WriteLine($"Kitap Adı: {Ad}, Yazar: {Yazar}, Fiyat: {Fiyat}, Ödenecek Tutar: {HesaplaOdeme()}");
    }
}

class Elektronik : Urun
{
    public string Marka { get; set; }

    public override decimal HesaplaOdeme()
    {
        return Fiyat + (Fiyat * 0.25m); // %25 vergi
    }

    public override void BilgiYazdir()
    {
        Console.WriteLine($"Elektronik Ürün: {Ad}, Marka: {Marka}, Fiyat: {Fiyat}, Ödenecek Tutar: {HesaplaOdeme()}");
    }
}

class Program
{
    static void Main()
    {
        List<Urun> urunler = new List<Urun>();

        Kitap kitap = new Kitap { Ad = "C# ile Programlama", Fiyat = 50, Yazar = "Ahmet Yılmaz" };
        Elektronik elektronik = new Elektronik { Ad = "Laptop", Fiyat = 5000, Marka = "Dell" };

        urunler.Add(kitap);
        urunler.Add(elektronik);

        foreach (var urun in urunler)
        {
            urun.BilgiYazdir();
        }
        Console.Read();
    }
}
