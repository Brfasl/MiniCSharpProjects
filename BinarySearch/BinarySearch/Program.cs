using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static void Main(string [] args)
        {
            Console.WriteLine("Kaç Adet Sayı Gireceksiniz:");
            int kaçSayi = int.Parse(Console.ReadLine());
            int[] girilenSayi = new int[kaçSayi];
            Console.WriteLine("Sayı Giriniz:");
            for(int i=0; i < kaçSayi; i++)
            {
                Console.Write($"{i + 1}. Sayı: ");
                girilenSayi[i] = int.Parse(Console.ReadLine());

            }

            Array.Sort(girilenSayi);
            Console.WriteLine("\nSıralı Dizi: " + string.Join(", ", girilenSayi));

            // Kullanıcıdan aramak istediği sayıyı alıyoruz

            Console.Write("\nAramak istediğiniz sayıyı girin: ");
            int arananSayi = int.Parse(Console.ReadLine());

            // İkili arama algoritmasını kullanarak sayıyı arıyoruz

            int sonuc = BinarySearch(girilenSayi, arananSayi);

            // Sonucu ekrana yazdırıyoruz
            if (sonuc != -1)
            {
                Console.WriteLine($"\n{arananSayi} sayısı dizide bulundu (Index: {sonuc}).");
            }
            else
            {
                Console.WriteLine($"\n{arananSayi} sayısı dizide bulunamadı.");
            }
            Console.Read();
        }

        // İkili Arama Algoritması (Binary Search)
        static int BinarySearch(int[] dizi, int hedef)
        {
            int sol = 0, sag = dizi.Length - 1;

            while (sol <= sag)
            {
                int orta = (sol + sag) / 2;

                if (dizi[orta] == hedef)
                    return orta;
                else if (dizi[orta] < hedef)
                    sol = orta + 1;
                else
                    sag = orta - 1;
            }


            return -1; // Sayı bulunamazsa -1 döner


        }




    }
}
