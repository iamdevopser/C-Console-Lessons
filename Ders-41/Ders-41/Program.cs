using System;
using System.Text;
using System.Threading;
using System.Linq;

namespace Ders_41
{
    class Program       // Bilgi Yarismasi
    {

        static void Main(string[] args)
        {

            Console.WriteLine("***********************");
            Console.WriteLine("Yarismaya hosgeldiniz");
            Console.Title = "Bilgi yarismasi";
            string ad, soyad;
            Console.Write("Adiniz: ");
            ad = Convert.ToString(Console.ReadLine());
            Console.Write("Soyadiniz: ");
            soyad = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Basliyoruz, Enter tusuna basiniz...");
            Console.WriteLine("Her yanittan sonra Enter Tusuna Basmayi Unutmayin...");
            Console.WriteLine("Cevaplari BUYUK HARFLERLE Verin...");

            Console.Read();

            int dogru, yanlis, para;
            dogru = 0;
            yanlis = 0;
            para = 0;

            string s1;
            Console.WriteLine("Soru 1- Cumhuriyet kac yilinda ilan edilmistir?");
            s1 = Convert.ToString(Console.ReadLine());
            string c1;
            Console.Write(" A- 1920\n B- 1923\n C- 1924\n D- 1926\n Cevabiniz: ");
            Console.WriteLine();
            c1 = Console.ReadLine();
            if (c1 == "B")
            {
                dogru = dogru + 1;
                para = para + 1000;
                Console.WriteLine("Tebrikler, cevap dogru, Enter tusuna basiniz");
                Console.ReadLine();
            }
            else
            {
                yanlis = yanlis + 1;
                Console.WriteLine("Maalesef cevap yanlis, Enter tusuna basiniz");
                Console.ReadLine();
            }

            string s2;
            Console.WriteLine("Soru 2- Turkiyenin baskenti hangi sehirdir?");
            s2 = Convert.ToString(Console.ReadLine());
            string c2;
            Console.Write(" A- Istanbul\n B- Izmir\n C- Ankara\n D- Konya\n Cevabiniz: ");
            Console.WriteLine();
            c2 = Console.ReadLine();

            if (c2 == "C")
            {
                dogru++;
                para = para + 1000;
                Console.WriteLine("Tebrikler, cevap dogru, Enter tusuna basiniz");
                Console.ReadLine();
            }
            else
            {
                yanlis++;
                Console.WriteLine("Maalesef cevap yanlis, Enter tusuna basiniz");
                Console.ReadLine();
            }

            string s3;
            Console.WriteLine("Soru 3- Maki hangi bolgenin bitki ortusudur?");
            s3 = Convert.ToString(Console.ReadLine());
            string c3;
            Console.Write(" A- Marmara\n B- Ege\n C- Guneydogu\n D- Akdeniz\n Cevabiniz: ");
            Console.WriteLine();
            c3 = Console.ReadLine();

            if (c3 == "D")
            {
                dogru++;
                para = para + 1000;
                Console.WriteLine("Tebrikler, cevap dogru, Enter tusuna basiniz");
                Console.ReadLine();
            }
            else
            {
                yanlis++;
                Console.WriteLine("Maalesef cevap yanlis, Enter tusuna basiniz");
                Console.ReadLine();
            }

            string s4;
            Console.WriteLine("Soru 3- Asagidakilerden hangisi istanbulda yer alan semtlerden biri degildir?");
            s4 = Convert.ToString(Console.ReadLine());
            string c4;
            Console.Write(" A- Urla\n B- Sariyer\n C- Uskudar\n D- Kartal\n Cevabiniz: ");
            Console.WriteLine();
            c4 = Console.ReadLine();

            if (c4 == "A")
            {
                dogru++;
                para = para + 1000;
                Console.WriteLine("Tebrikler, cevap dogru, Enter tusuna basiniz");
                Console.ReadLine();
            }
            else
            {
                yanlis++;
                Console.WriteLine("Maalesef cevap yanlis, Enter tusuna basiniz");
                Console.ReadLine();
            }

            Console.WriteLine("Adiniz: " + ad);
            Console.WriteLine("Soyadiniz: " + soyad);
            Console.WriteLine("Dogru sayisi: " + dogru);
            Console.WriteLine("Yanlis sayisi: " + yanlis);
            Console.WriteLine("Toplam kazandiginiz para: " + para);
            Console.ReadLine();


        }
    }
}

