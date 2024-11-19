using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calisan
{
    public class Departman
    {
        public string Ad { get; set; }
        public string Lokasyon { get; set; }

        public Departman(string ad,string lokasyon)
        {
            Ad = ad;
            Lokasyon = lokasyon;
            
        }
    }
    public class Calisan
    {
        public string Ad { get; set; }
        public string Pozisyon { get; set; }
        public Departman Departman { get; set; }
        public Calisan(string ad,string pozisyon)
        {
            Ad = ad;
            Pozisyon = pozisyon;
        }
        public void DepartmanAtama(Departman departman)
        {
            Departman = departman;
        }
       
        public void BilgiGöster()
        {
            Console.WriteLine($"Çalışan Adı: {Ad}, Pozisyon: {Pozisyon}");
            if(Departman != null)
            {
                Console.WriteLine($"Departman:{Departman.Ad} ,Lokasyon:{Departman.Lokasyon}");
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calisan c1 = new Calisan("Ali","Müdür");
            Departman d1 = new Departman("ID", "İstanbul");
            c1.DepartmanAtama(d1);
            c1.BilgiGöster();
            Console.Read();
        }
    }
}
