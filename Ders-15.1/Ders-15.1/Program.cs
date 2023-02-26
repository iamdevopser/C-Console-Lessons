using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_15._1
{
    // dizideki cift sayilari foreach ile bulup carpimlarini hesaplama
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] degerler = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int sonuc = 1;
            int toplam = 0;

            foreach (int i in degerler)
            {
                if (i % 2 == 0)
                {
                    sonuc = sonuc * i;
                }
            }
            Console.Write(sonuc);


            Console.ReadLine();
        }
    }
}
