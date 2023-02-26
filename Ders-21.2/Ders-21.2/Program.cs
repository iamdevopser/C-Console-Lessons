using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_21._2    // Bool degiskeni - pozitif ya da negatif olma durumu ve 10 dan buyuk olma durumunu kontrol etme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            Console.Write("Sayiyi girin: ");
            sayi = Convert.ToInt32(Console.ReadLine());
            bool durum1 = sayi > 0;
            Console.WriteLine("Sayi pozitif mi: {0}", durum1);
            bool durum2 = sayi > 10;
            Console.Write("Sayi 10 dan buyuk mu: {0}", durum2);
            Console.ReadLine();
        }
    }
}
