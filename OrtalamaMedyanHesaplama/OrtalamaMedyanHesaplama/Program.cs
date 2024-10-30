using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrtalamaMedyanHesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            int input;

            Console.WriteLine("Pozitif tam sayılar girin (0 girildiğinde program sonlanacaktır.):");

            // Kullanıcıdan sayıları almak için dngü yaptık.
            do
            {
                Console.Write("Sayı girin: ");
                input = int.Parse(Console.ReadLine());

                if (input > 0)
                {
                    numbers.Add(input);
                }

            } while (input != 0);

            if (numbers.Count > 0)
            {
                // Ortalama hesaplamak için bu metodu kullanıyoruz.
                double average = numbers.Average();

                // Medyan hesapla
                numbers.Sort();
                double median;
                int middle = numbers.Count / 2;

                if (numbers.Count % 2 == 0)
                {
                    median = (numbers[middle - 1] + numbers[middle]) / 2.0;
                }
                else
                {
                    median = numbers[middle];
                }

                Console.WriteLine($"\nOrtalama: {average}");
                Console.WriteLine($"Medyan: {median}");
            }
            else
            {
                Console.WriteLine("Geçerli bir sayı girilmedi.");
            }
            Console.ReadLine();
        }
    }
}
