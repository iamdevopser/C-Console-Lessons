using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Ornek 2 *****");
            int sinav1, sinav2, proje, ortalama;
            Console.WriteLine("***** Sinav notlariniz *****");
            Console.Write("1.Sinav Notu:");
            sinav1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2.Sinav Notu:");
            sinav2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Proje Notu: ");
            proje = Convert.ToInt32(Console.ReadLine());

            ortalama = (sinav1 + sinav2 + proje) / 3;
            if (ortalama <= 0 && ortalama > 100)
            {
                Console.WriteLine("Yanlis degerler girdiniz.");
            }
            else if (ortalama > 0 && ortalama < 30)
            {
                Console.WriteLine("Not ortalamasi: " + ortalama + ". Durum vasat.");
            }
            else if (ortalama >= 30 && ortalama < 50)
            {
                Console.WriteLine("Not ortalamasi: " + ortalama + ". Durum iyi degil.");
            }
            else if (ortalama >= 50 && ortalama < 75)
            {
                Console.WriteLine("Not ortalamasi: " + ortalama + ". Durum normal. Daha iyi olabilir.");
            }
            else if (ortalama >= 75 && ortalama < 90)
            {
                Console.WriteLine("Not ortalamasi: " + ortalama + ". Durum gayet iyi. Biraz daha cabalaman gerekiyor.");
            }
            else if (ortalama >= 90 && ortalama <= 100)
            {
                Console.WriteLine("Not ortalamasi: " + ortalama + ". Durum mukemmel.Tebrik ederim.");
            }

        }
    }
}
