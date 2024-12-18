using System;
using System.Collections.Generic;

interface IYayinci
{
    void AboneEkle(IAbone abone);
    void AboneCikar(IAbone abone);
    void Bildir();
}

interface IAbone
{
    void BilgiAl(string mesaj);
}

class Yayinci : IYayinci
{
    private List<IAbone> aboneler = new List<IAbone>();
    private string sonDegisiklik;

    public void AboneEkle(IAbone abone)
    {
        aboneler.Add(abone);
        Console.WriteLine("Yeni abone eklendi.");
    }

    public void AboneCikar(IAbone abone)
    {
        aboneler.Remove(abone);
        Console.WriteLine("Abone çıkarıldı.");
    }

    public void DegisiklikYap(string mesaj)
    {
        sonDegisiklik = mesaj;
        Bildir();
    }

    public void Bildir()
    {
        foreach (var abone in aboneler)
        {
            abone.BilgiAl(sonDegisiklik);
        }
    }
}

class Abone : IAbone
{
    public string Ad { get; set; }

    public void BilgiAl(string mesaj)
    {
        Console.WriteLine($"{Ad}, yeni bir bildirim alındı: {mesaj}");
    }
}

class Program
{
    static void Main()
    {
        Yayinci yayinci = new Yayinci();

        Abone abone1 = new Abone { Ad = "Ali" };
        Abone abone2 = new Abone { Ad = "Ayşe" };

        yayinci.AboneEkle(abone1);
        yayinci.AboneEkle(abone2);

        yayinci.DegisiklikYap("Yeni içerik yayınlandı!");

        yayinci.AboneCikar(abone1);

        yayinci.DegisiklikYap("Yeni güncelleme mevcut!");
        Console.Read();
    }
}
