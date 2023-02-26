using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_14_Diziler_2
{
    // Ekrana girilen degerlerin en buyuk olanini bulma
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write((i + 1).ToString() + ". Sayiyi Girin: ");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }

            int enBuyuk = sayilar[0];

            for (int i = 1; i < 5; i++)
            {
                if (enBuyuk < sayilar[i])
                {
                    enBuyuk = sayilar[i];
                }
            }
            Console.WriteLine("En buyuk sayi: " + enBuyuk); Console.ReadLine();
        }
    }
}
