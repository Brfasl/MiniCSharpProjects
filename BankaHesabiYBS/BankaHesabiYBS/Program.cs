using System;

abstract class Hesap
{
    public string HesapNo { get; set; }
    public decimal Bakiye { get; set; }

    public abstract void ParaYatir(decimal miktar);
    public abstract void ParaCek(decimal miktar);
}

class BirikimHesabi : Hesap
{
    public double FaizOrani { get; set; }

    public override void ParaYatir(decimal miktar)
    {
        Bakiye += miktar;
        Bakiye += (decimal)(miktar * (decimal)FaizOrani / 100);
        Console.WriteLine($"Birikim hesabına {miktar} TL yatırıldı. Yeni bakiye: {Bakiye}");
    }

    public override void ParaCek(decimal miktar)
    {
        if (Bakiye >= miktar)
        {
            Bakiye -= miktar;
            Console.WriteLine($"Birikim hesabından {miktar} TL çekildi. Yeni bakiye: {Bakiye}");
        }
        else
        {
            Console.WriteLine("Yetersiz bakiye!");
        }
    }
}

class VadesizHesap : Hesap
{
    public decimal IslemUcreti { get; set; } = 5;

    public override void ParaYatir(decimal miktar)
    {
        Bakiye += miktar;
        Console.WriteLine($"Vadesiz hesaba {miktar} TL yatırıldı. Yeni bakiye: {Bakiye}");
    }

    public override void ParaCek(decimal miktar)
    {
        decimal toplamCekim = miktar + IslemUcreti;
        if (Bakiye >= toplamCekim)
        {
            Bakiye -= toplamCekim;
            Console.WriteLine($"Vadesiz hesaptan {miktar} TL çekildi. İşlem ücreti: {IslemUcreti}. Yeni bakiye: {Bakiye}");
        }
        else
        {
            Console.WriteLine("Yetersiz bakiye!");
        }
    }
}

interface IBankaHesabi
{
    DateTime HesapAcilisTarihi { get; set; }
    void HesapOzeti();
}

class BankaHesabi : BirikimHesabi, IBankaHesabi
{
    public DateTime HesapAcilisTarihi { get; set; }

    public void HesapOzeti()
    {
        Console.WriteLine($"Hesap No: {HesapNo}, Bakiye: {Bakiye}, Açılış Tarihi: {HesapAcilisTarihi.ToShortDateString()}");
    }
}

class Program
{
    static void Main()
    {
        BirikimHesabi birikimHesabi = new BirikimHesabi { HesapNo = "12345", Bakiye = 1000, FaizOrani = 5 };
        birikimHesabi.ParaYatir(500);
        birikimHesabi.ParaCek(300);

        VadesizHesap vadesizHesap = new VadesizHesap { HesapNo = "67890", Bakiye = 2000 };
        vadesizHesap.ParaYatir(1000);
        vadesizHesap.ParaCek(500);
        Console.Read();
    }
}
