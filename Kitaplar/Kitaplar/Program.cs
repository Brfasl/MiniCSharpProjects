using System;
using System.Collections.Generic;

class Yazar
{
    public string Ad { get; set; }
    public string Ülke { get; set; }
    public List<Kitap> Kitaplar { get; set; }

    public Yazar(string ad, string ülke)
    {
        Ad = ad;
        Ülke = ülke;
        Kitaplar = new List<Kitap>();
    }

    public void KitapEkle(Kitap kitap)
    {
        Kitaplar.Add(kitap);
        kitap.YazarAtama(this); 
    }
}

class Kitap
{
    public string Baslik { get; set; }
    public DateTime YayinTarihi { get; set; }
    public Yazar Yazar { get; private set; }

    public Kitap(string baslik, DateTime yayinTarihi)
    {
        Baslik = baslik;
        YayinTarihi = yayinTarihi;
    }

    public void YazarAtama(Yazar yazar)
    {
        Yazar = yazar;
        if (!yazar.Kitaplar.Contains(this))
        {
            yazar.KitapEkle(this);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Yazar yazar1 = new Yazar("Orhan Pamuk", "Türkiye");
        Kitap kitap1 = new Kitap("Masumiyet Müzesi", new DateTime(2008, 8, 1));

        yazar1.KitapEkle(kitap1);

        Console.WriteLine($"{yazar1.Ad} adlı yazarın kitapları:");
        foreach (var kitap in yazar1.Kitaplar)
        {
            Console.WriteLine($"- {kitap.Baslik} ({kitap.YayinTarihi.Year})");
        }

        Console.WriteLine($"\n{kitap1.Baslik} kitabının yazarı: {kitap1.Yazar.Ad}");
        Console.Read();
    }
}
