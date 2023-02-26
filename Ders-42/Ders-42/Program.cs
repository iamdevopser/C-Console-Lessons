using System;
using System.Text;
using System.Threading;
using System.Linq;
using System.Runtime.ConstrainedExecution;

namespace Ders_42       // Aritmetik Islemler

{
    class Program
    {

        static void Main(string[] args)
        {

            int islem;
            Console.WriteLine("************************************");
            Console.WriteLine("Aritmetik islem menusune hosgeldiniz");
            Console.WriteLine("*************** MENU ***************");
            Console.WriteLine("1- Aritmetik dort islem ");
            Console.WriteLine("2- Us Alma");
            Console.WriteLine("3- Kok alma");
            Console.WriteLine("4- Karenin cevre ve alan hesabi");
            Console.WriteLine("5- Dikdortgende alan ve cevre hesabi");
            Console.WriteLine("6- Eskenar ucgende cevre\n");

            Console.WriteLine("************************************\n");
            for (int i = 1; i <= 6; i++)
            {
                Console.WriteLine();
                Console.Write("Islem yapmak istediginiz alan: ");
                islem = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine();
                if (islem == 1)
                {
                    int a, b, toplam, fark, carpim, bolum;
                    Console.Write("1.sayiyi girin: ");
                    a = Convert.ToInt16(Console.ReadLine());
                    Console.Write("2.sayiyi girin: ");
                    b = Convert.ToInt16(Console.ReadLine());

                    toplam = a + b;
                    fark = a - b;
                    carpim = a * b;
                    bolum = a / b;
                    Console.WriteLine();
                    Console.WriteLine("4 islemin sonucu: ");
                    Console.WriteLine();
                    Console.WriteLine("Toplam: " + toplam);
                    Console.WriteLine("Fark: " + fark);
                    Console.WriteLine("Carpim: " + carpim);
                    Console.WriteLine("Bolum: " + bolum);
                    Console.WriteLine("************************************");

                }

                if (islem == 2)
                {
                    double sayi, us, sonuc;
                    Console.WriteLine("************************************");
                    Console.Write("Sayiyi girin: ");
                    sayi = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ussu girin: ");
                    us = Convert.ToDouble(Console.ReadLine());
                    sonuc = Math.Pow(sayi, us);
                    Console.WriteLine("Sonuc: " + sonuc);
                    Console.WriteLine("************************************");

                }

                if (islem == 3)
                {
                    double sayi, kok;
                    Console.WriteLine("************************************");
                    Console.Write("Koku alinacak sayiyi girin: ");
                    sayi = Convert.ToDouble(Console.ReadLine());
                    kok = Math.Sqrt(sayi);
                    Console.WriteLine("Sonuc: " + kok);
                    Console.WriteLine("************************************");

                }

                if (islem == 4)
                {
                    int kenar, alan, cevre;
                    Console.WriteLine("************************************");
                    Console.Write("Kenarin degeri: ");
                    kenar = Convert.ToInt16(Console.ReadLine());
                    alan = kenar * kenar;
                    cevre = kenar * 4;
                    Console.WriteLine("Alan: " + alan);
                    Console.WriteLine("Cevre: " + cevre);
                    Console.WriteLine("************************************");

                }

                if (islem == 5)
                {
                    int kisa, uzun, cevreDik, alanDik;
                    Console.WriteLine("************************************");
                    Console.Write("Kisa kenari degeri: ");
                    kisa = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Uzun kenari degeri: ");
                    uzun = Convert.ToInt16(Console.ReadLine());
                    alanDik = kisa * uzun;
                    cevreDik = kisa + kisa + uzun + uzun;
                    Console.WriteLine("Karenin Alani: " + alanDik);
                    Console.WriteLine("karenin Cevresi: " + cevreDik);
                    Console.WriteLine("************************************");

                }

                if (islem == 6)
                {
                    int kenarEskenar, cevreEskenar;
                    Console.WriteLine("************************************");
                    Console.Write("Eskenar ucgenin bir kenarinin degeri: ");
                    kenarEskenar = Convert.ToInt16(Console.ReadLine());
                    cevreEskenar = kenarEskenar * 3;
                    Console.WriteLine("Eskenar ucgenin cevresi: " + cevreEskenar);
                    Console.WriteLine("************************************");

                }
            }
            Console.ReadLine();


        }
    }
}

