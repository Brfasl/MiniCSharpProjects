using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje
{
    public class BankaHesabi
    {
        public string HesapNumarasi { get; set; }
        private decimal Bakiye;
        public decimal bakiye
        {
            get { return Bakiye; }
            set
            {
                if (Bakiye > 0)
                    Bakiye=value;
                else
                    throw new ArgumentException("Hatalı Bakiye Girdiniz.");
            }
        }
        public BankaHesabi(string hesapNumarasi, decimal bakiye)
        {
            Bakiye += bakiye;
            HesapNumarasi = hesapNumarasi;
        }
        public void ParaYatir(decimal miktar)
        {
            if (miktar > 0)
            {
                Bakiye += miktar;
                Console.WriteLine($"{miktar} TL Yatırıldı.Güncel Bakiyeniz:{Bakiye}");
            }

            else
                throw new ArgumentException("Hatalı Miktar Girdiniz.");

           

        }
        public void ParaCek(decimal miktar)
        {
            if (Bakiye > miktar)
            {
                Bakiye -=miktar;
                Console.WriteLine($"{miktar} TL Çekildi.Kalan Bakiye:{Bakiye}");
            }
            else
                Console.WriteLine($"Yetersiz Bakiye.Güncel Bakiye:{Bakiye}");

           


        }

        class Program
        {
            static void Main(string[] args)
            {
                BankaHesabi müsteri1 = new BankaHesabi("1", 1000);
                BankaHesabi müsteri2 = new BankaHesabi("2", 4000);
                BankaHesabi müsteri3 = new BankaHesabi("3", 8000);
                müsteri1.ParaCek(3000);
                müsteri2.ParaYatir(3000);
                müsteri3.ParaCek(3000);



                Console.ReadLine();



            }
        }
    }
}
