using System;
using System.Collections.Generic;

public class Ogrenci
{
    public string Ad { get; set; }
    public int Yas { get; set; }

    public Ogrenci(string ad, int yas)
    {
        Ad = ad;
        Yas = yas;
    }

    public string OgrenciBilgi()
    {
        return $"{Ad}, {Yas} yaşında";
    }
}

public class Okul
{
    public string Ad { get; set; }
    public List<Ogrenci> Ogrenciler { get; set; } = new List<Ogrenci>();

    public Okul(string ad)
    {
        Ad = ad;
    }

    public void OgrenciEkle(Ogrenci ogrenci)
    {
        Ogrenciler.Add(ogrenci);
    }

    public string OkulBilgi()
    {
        return $"{Ad} okulunda {Ogrenciler.Count} öğrenci var.";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Okul okul = new Okul("Anadolu Lisesi");
        okul.OgrenciEkle(new Ogrenci("Ali", 16));
        okul.OgrenciEkle(new Ogrenci("Ayşe", 17));

        Console.WriteLine(okul.OkulBilgi());
        Console.Read();
    }
}
