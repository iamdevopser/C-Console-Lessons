using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_6    // IF ELSE ORNEKLERI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Ornek 1 *****");
            string isim = "Tarik";
            if(isim == "Tarik")
            {
                Console.WriteLine("Dogru isim girisi yaptiniz.");
            }
            else Console.WriteLine("Girdiginiz isim yanlis.");
            Console.WriteLine();

            Console.WriteLine("***** Ornek 2 *****");
            string ad;
            Console.Write("Bir isim giriniz:");
            ad = Console.ReadLine();
            if (ad == "Tarik")
            {
                Console.WriteLine("Dogru isim girisi yaptiniz.");
            }
            else Console.WriteLine("Girdiginiz isim yanlis.");
            Console.WriteLine();

            Console.WriteLine("***** Ornek 3 *****");
            string sehir;
            Console.Write("Turkiyenin baskenti neresidir?  ");
            sehir = Console.ReadLine();
            if (sehir == "Ankara")
            {
                Console.WriteLine("Cevabiniz dogru.");
            }
            else Console.WriteLine("Cevabiniz yanlis.");

            Console.WriteLine("***** Ornek 4 *****");
            int sayi;
            Console.Write("Bir sayi giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi > 0)
            {
                Console.WriteLine("Pozitif bir sayi girdiniz.");
            }
            else Console.WriteLine("Negatif sayi girdiniz.");
        }
    }
}
