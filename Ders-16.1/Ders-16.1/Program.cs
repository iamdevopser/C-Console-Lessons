using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_16._1
{
    // Konsolda girilen sayilari kucukten buyuge siralama 
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Sayiyi girin: ");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(sayilar);

            foreach (int i in sayilar)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
