using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_18._1
{   // YGS ders icerikleri
    internal class Program
    {
        static void Main(string[] args)
        {
            char ders;
            Console.WriteLine("..... YGS DERS MENUSU .....\n");
            Console.WriteLine("Turkce...");
            Console.WriteLine("Matematik...");
            Console.WriteLine("Sosyal Bilgisi...");
            Console.WriteLine("Fen Bilgisi...\n");
            Console.Write("Hangi dersin bilgilerini gormek istersiniz? ");
            ders = Convert.ToChar(Console.ReadLine());
            if (ders == 't' || ders == 'T')
            {
                Console.WriteLine("\nTurkce dersi agirlikli olup dilbilgisi sorulari da icerir");

            }
            else if (ders == 'm' || ders == 'M')
            {
                Console.WriteLine("\nMatematik dersi temel mat1 konulari ve 8-9 tane geometri icerir");
            }
            else if (ders == 's' || ders == 'S')
            {
                Console.WriteLine("\nSosyal Bilgiler dersi tarih ve cografya konularini icerir");
            }
            else if (ders == 'f' || ders == 'F')
            {
                Console.WriteLine("\nFenbilgisi dersi fizik, kimya ve biyoloji derslerini icerir");
            }
            else Console.WriteLine("Yanlis harf girisi yaptiniz!");

            Console.ReadLine();
        }
    }
}
