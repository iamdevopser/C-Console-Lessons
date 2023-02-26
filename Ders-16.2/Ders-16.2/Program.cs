using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_16._2
{
    // Dizide verilen sayilardan 10 ile 30 arasinda olanlari siralama
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 4, 1, 7, -8, 23, 14, 51, 84, -75, 26, -8, 9 };

            foreach (int i in sayilar)
            {
                if (i > 10 && i < 30 && i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
