using System;

class Hesap
{
    public string HesapNo { get; set; }
    public decimal Bakiye { get; set; }
    public string HesapSahibi { get; set; }

    public virtual void ParaYatir(decimal miktar)
    {
        Bakiye += miktar;
        Console.WriteLine($"Yeni bakiye: {Bakiye}");
    }

    public virtual void ParaCek(decimal miktar)
    {
        if (Bakiye >= miktar)
        {
            Bakiye -= miktar;
            Console.WriteLine($"Yeni bakiye: {Bakiye}");
        }
        else
        {
            Console.WriteLine("Yetersiz bakiye!");
        }
    }

    public virtual void BilgiYazdir()
    {
        Console.WriteLine($"Hesap No: {HesapNo}, Hesap Sahibi: {HesapSahibi}, Bakiye: {Bakiye}");
    }
}

class VadesizHesap : Hesap
{
    public decimal EkHesapLimiti { get; set; }

    public override void ParaCek(decimal miktar)
    {
        if (Bakiye + EkHesapLimiti >= miktar)
        {
            Bakiye -= miktar;
            Console.WriteLine($"Yeni bakiye: {Bakiye}");
        }
        else
        {
            Console.WriteLine("Yetersiz bakiye ve ek hesap limiti!");
        }
    }
}

class VadeliHesap : Hesap
{
    public int VadeSuresi { get; set; }
    public double FaizOrani { get; set; }

    public override void ParaCek(decimal miktar)
    {
        Console.WriteLine("Vade dolmadan para çekemezsiniz!");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Hesap türünü seçin: 1- Vadesiz Hesap, 2- Vadeli Hesap");
        int secim = int.Parse(Console.ReadLine());

        if (secim == 1)
        {
            VadesizHesap vadesiz = new VadesizHesap();
            Console.Write("Hesap No: ");
            vadesiz.HesapNo = Console.ReadLine();
            Console.Write("Hesap Sahibi: ");
            vadesiz.HesapSahibi = Console.ReadLine();
            Console.Write("Bakiye: ");
            vadesiz.Bakiye = decimal.Parse(Console.ReadLine());
            Console.Write("Ek Hesap Limiti: ");
            vadesiz.EkHesapLimiti = decimal.Parse(Console.ReadLine());
            vadesiz.BilgiYazdir();
            vadesiz.ParaCek(100); // Örnek işlem
        }
        else if (secim == 2)
        {
            VadeliHesap vadeli = new VadeliHesap();
            Console.Write("Hesap No: ");
            vadeli.HesapNo = Console.ReadLine();
            Console.Write("Hesap Sahibi: ");
            vadeli.HesapSahibi = Console.ReadLine();
            Console.Write("Bakiye: ");
            vadeli.Bakiye = decimal.Parse(Console.ReadLine());
            Console.Write("Vade Süresi: ");
            vadeli.VadeSuresi = int.Parse(Console.ReadLine());
            Console.Write("Faiz Oranı: ");
            vadeli.FaizOrani = double.Parse(Console.ReadLine());
            vadeli.BilgiYazdir();
            vadeli.ParaCek(100); // Örnek işlem
        }
        else
        {
            Console.WriteLine("Geçersiz seçim!");
        }
        Console.Read();
    }
}
