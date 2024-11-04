using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje
{
    public class Urun
    {
       public string ad { get; set; }
        public decimal fiyat { get; set; }
        private decimal indirim;
        public decimal Indirim
        {
            get { return indirim; }
            set
            {
                if (value < 0 || value > 50)
               
                    indirim = 0;
                
                
                else
                    indirim = value;
            }

        }
        public Urun(string Ad, decimal Fiyat)
        {
            ad = Ad;
            fiyat = Fiyat;
            Indirim=0;
        }
        public decimal IndirimliFiyat()
        {
  
            return fiyat - (fiyat * Indirim / 100);

        }
        class Program
        {
            static void Main(string[] args)
            {

                Urun urun1 = new Urun("Kazak", 2000m);
                Urun urun2 = new Urun("Kaban", 1000m);
                Urun urun3 = new Urun("Tişört",500m);
                Urun urun4 = new Urun("Ceket", 4000m);

               
                urun1.Indirim = 20; 
                urun2.Indirim = 30; 
                urun3.Indirim = 40; 
                urun4.Indirim = 60; 
                Console.WriteLine($"Ürün: {urun1.ad}, Fiyat: {urun1.fiyat}, İndirim: {urun1.indirim}%, İndirimli Fiyat: {urun1.IndirimliFiyat()}");
                Console.WriteLine($"Ürün: {urun2.ad}, Fiyat: {urun2.fiyat}, İndirim: {urun2.indirim}%, İndirimli Fiyat: {urun2.IndirimliFiyat()}");
                Console.WriteLine($"Ürün: {urun3.ad}, Fiyat: {urun3.fiyat}, İndirim: {urun3.indirim}%, İndirimli Fiyat: {urun3.IndirimliFiyat()}");
                Console.WriteLine($"Ürün: {urun4.ad}, Fiyat: {urun4.fiyat}, İndirim: {urun4.indirim}%, İndirimli Fiyat: {urun4.IndirimliFiyat()}");
               

               
                Console.Read();
            }
        }
    }
}
