using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kisi
{
    public class Kisi
    {
        string Ad { get; set; }
        string Soyad { get; set; }
        string TelefonNumarasi { get; set; }
        public Kisi(string ad,string soyad,string telefonNumarasi)
        {
            Ad = ad;
            Soyad = soyad;
            TelefonNumarasi = telefonNumarasi;
        }
        public string KisiBilgisi()
        {
            return $"Adı: {Ad} Soyadı: {Soyad} Telefon Numarası: {TelefonNumarasi}";
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Kisi k1 = new Kisi("Ali", "Cabbar", "0536272");
            Kisi k2 = new Kisi("Irmak", "Tüzin", "0546278");
            Kisi k3 = new Kisi("Ali", "Cabbar", "0551890");
            Console.WriteLine(k1.KisiBilgisi());
            Console.WriteLine(k2.KisiBilgisi());
            Console.WriteLine(k3.KisiBilgisi());
            Console.Read();
        }
    }
}
