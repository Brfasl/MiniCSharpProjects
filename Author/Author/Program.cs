using System;
using System.Collections.Generic;

class Yazar
{
    public string Ad { get; set; }
    public string Ulke { get; set; }
    public List<Kitap> Kitaplar { get; set; }

    public Yazar(string ad, string ulke)
    {
        Ad = ad;
        Ulke = ulke;
        Kitaplar = new List<Kitap>();
    }

    public void KitapEkle(Kitap kitap)
    {
        Kitaplar.Add(kitap);
    }

    public void BilgiYazdir()
    {
        Console.WriteLine($"Yazar Adı: {Ad}, Ülke: {Ulke}");
        Console.WriteLine("Kitapları:");
        foreach (var kitap in Kitaplar)
        {
            Console.WriteLine($"- {kitap.Baslik}, ISBN: {kitap.ISBN}");
        }
    }
}

class Kitap
{
    public string Baslik { get; set; }
    public string ISBN { get; set; }

    public Kitap(string baslik, string isbn)
    {
        Baslik = baslik;
        ISBN = isbn;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Yazar yazar1 = new Yazar("Orhan Pamuk", "Türkiye");
        Kitap kitap1 = new Kitap("Kırmızı Saçlı Kadın", "1234567890");
        Kitap kitap2 = new Kitap("Benim Adım Kırmızı", "0987654321");

        yazar1.KitapEkle(kitap1);
        yazar1.KitapEkle(kitap2);

        yazar1.BilgiYazdir();
        Console.Read();
    }
}
