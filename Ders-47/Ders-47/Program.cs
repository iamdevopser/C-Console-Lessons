using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_46
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double seçim, adet, toplam = 0;
            double hesap = 0;
            Console.WriteLine("********************************");
            Console.WriteLine("**  Yemekler ** İçecekler     **");
            Console.WriteLine("**                            **");
            Console.WriteLine("** 1-Et Döner - 100.00 TL     **");
            Console.WriteLine("**                            **");
            Console.WriteLine("** 2-Tavuk Döner - 70.00 TL   **");
            Console.WriteLine("**                            **");
            Console.WriteLine("** 3-Çorbalar - 25.00 TL      **");
            Console.WriteLine("**                            **");
            Console.WriteLine("** 4-Salatalar - 15.00 TL     **");
            Console.WriteLine("**                            **");
            Console.WriteLine("** 5-Ayran - 10.00 TL     **  **");
            Console.WriteLine("********************************");

            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine("");
                Console.Write("Alacaginiz urunun numarasini giriniz:");
                seçim = Convert.ToDouble(Console.ReadLine());

                if (seçim == 1)
                {
                    Console.Write("Kaç Porsiyon Et Döner istiyorsunuz: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 100;
                    hesap = hesap + toplam;
                }
                else if (seçim == 2)
                {
                    Console.Write("Kaç Porsiyon Tavuk Döner istiyorsunuz: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 70;
                    hesap = hesap + toplam;
                }
                else if (seçim == 3)
                {
                    Console.Write("Kaç Porsiyon Çorba istiyorsunuz: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 25;
                    hesap = hesap + toplam;
                }
                else if (seçim == 4)
                {
                    Console.Write("Kaç Porsiyon Salata istiyorsunuz: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 15;
                    hesap = hesap + toplam;
                }
                else if (seçim == 5)
                {
                    Console.Write("Kaç adet Ayran istiyorsunuz: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 10;
                    hesap = hesap + toplam;
                }

                else
                    Console.WriteLine("Böyle Bir Şeçim Yok...");
            }

            Console.WriteLine("Toplam hesap : " + hesap);
            Console.WriteLine();
            Console.Write("Verdiginiz Para : ");
            double verilenPara = Convert.ToDouble(Console.ReadLine());
            double paraUstu = verilenPara - hesap;
            Console.WriteLine();
            Console.Write("Para Üstü : " + paraUstu);
            Console.WriteLine();

            if (paraUstu < 0)
            {
                Console.WriteLine("Para Üstü Yok...");
            }

            if (verilenPara < hesap)
            {
                Console.WriteLine("Malesef Paranız Yetmiyor. Sizi bulasikhaneye alalim :))");
                Console.WriteLine();
                Console.WriteLine("Şu Kadar Eksik para verdiniz : " + paraUstu);
            }
            else
            {
                Console.WriteLine("Afiyet Olsun .....");
            }
            Console.ReadKey();
        }
    }
}
