using System;

public class Islemci
{
    public int Cekirdekler { get; set; }
    public double Frekans { get; set; }

    public Islemci(int cekirdekler, double frekans)
    {
        Cekirdekler = cekirdekler;
        Frekans = frekans;
    }

    public string IslemciBilgi()
    {
        return $"{Cekirdekler} Çekirdek, {Frekans} GHz";
    }
}

public class Bilgisayar
{
    public string Model { get; set; }
    public Islemci Islemci { get; set; }

    public Bilgisayar(string model, Islemci islemci)
    {
        Model = model;
        Islemci = islemci;
    }

    public string BilgisayarBilgi()
    {
        return $"{Model} - {Islemci.IslemciBilgi()}";
    }
}


class Program
{
    static void Main(string[] args)
    {
        Islemci islemci = new Islemci(8, 3.5);
        Bilgisayar bilgisayar = new Bilgisayar("Lenovo ThinkPad", islemci);

        Console.WriteLine(bilgisayar.BilgisayarBilgi());
        Console.Read();
    }
}
