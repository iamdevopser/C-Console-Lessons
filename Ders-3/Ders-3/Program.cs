using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_3        // integer degisken ornekleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // Ornek 1
            int sayi1, sayi2, toplam;
            sayi1 = 5;
            sayi2 = 7;
            toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam: " + toplam);
            Console.WriteLine();
            
            // Ornek 2
            int a, b, c;
            a = 8;
            b = 7;
            c = a * b;
            Console.WriteLine("a * b = " + c);
            Console.WriteLine();

            // Ornek 3
            int deger1, deger2, ortalama;
            deger1 = 22;
            deger2 = 12;
            ortalama = (deger1+ deger2) / 2;
            Console.WriteLine("Ortalama = " + ortalama);
            Console.WriteLine();

            // Ornek 4
            string ad, soyad;
            int numara;
            ad = "Tarik";
            soyad = "Karakullukcu";
            numara = 1234567890;

            Console.WriteLine("****  Ogrenci Bilgi Formu ****");
            Console.WriteLine("Adi     : " + ad);
            Console.WriteLine("Soyadi  : " + soyad);
            Console.WriteLine("Numarasi: " + numara);
            Console.WriteLine("******************************");

            int s1, s2, s3, p, ort;
            s1 = 50;
            s2 = 75;
            s3 = 95;
            p = 100;
            ort = (s1 + s2 + s3 + p) / 4;

            Console.WriteLine("*** Sinav - Proje Notlari ****");
            Console.WriteLine("******************************");
            Console.WriteLine("Sinav 1 : " + s1);   
            Console.WriteLine("Sinav 2 : " + s2);
            Console.WriteLine("Sinav 3 : " + s3);
            Console.WriteLine("Proje   : " + p);
            Console.WriteLine("Ortalama: " + ort);
            Console.WriteLine("******************************");



            Console.ReadLine();

        }
    }
}
