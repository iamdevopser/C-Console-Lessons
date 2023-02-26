using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_15._3
{
    // Dizide verilen sayilarin toplamini hesaplama
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 1, 2, 3, 4, 5, 6 };
            int toplam = 0;

            foreach (int i in sayilar)
            {
                toplam = toplam + i;
            }
            Console.WriteLine("Toplam: " + toplam);

            Console.ReadLine();
        }
    }
}
