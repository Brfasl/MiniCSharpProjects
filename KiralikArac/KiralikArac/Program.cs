using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiralikArac
{
    public class KiralikArac
    {
       public string Plaka { get; private set; }
       public decimal GunlukUcret { get; private set; }
        public bool MusaitMi { get; private set; }
        public KiralikArac(string plaka,decimal gunlukUcret)
        {
            Plaka = plaka;
            GunlukUcret = gunlukUcret;
            MusaitMi = true;
        }
        public void AracKirala()
        {
            if (MusaitMi)
            {
                MusaitMi = false;
                Console.WriteLine($"{Plaka}'lı Araç Kiralandı.Ücret, {GunlukUcret} TL'dir.");

            }
            else
                Console.WriteLine($"{Plaka}'lı Araç Önceden Kiralanmış.");

        }
        public void AracıTeslimEt()
        {
            if (!MusaitMi)
            {
                MusaitMi = true;
                Console.WriteLine($"{Plaka}'lı Araç Teslim Edildi.");
            }
            else
                Console.WriteLine($"{Plaka}'lı Araç Zaten Teslim Edildi.");
        }
    }
   
    class Program
    {
        static void Main(string[] args)
        {
            KiralikArac a1 = new KiralikArac("60 DB 327", 1000m);
            KiralikArac a2 = new KiralikArac("44 BH 892", 2870m);
            KiralikArac a3 = new KiralikArac("06 MU 501", 3000m);
            KiralikArac a4 = new KiralikArac("35 KL 284", 4200m);
            a1.AracKirala();
            a1.AracKirala();
            a2.AracıTeslimEt();
            a3.AracKirala();
            a4.AracKirala();
            a4.AracıTeslimEt();

            Console.Read();
        }
    }
}
