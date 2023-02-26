using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_14._1
{
    // Konsola girilen ogrencilerin aldigi sinav sonuclarini listeleme
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] isim = new string[3];
            int[] s1 = new int[3];
            int[] s2 = new int[3];
            int[] ort = new int[3];

            for (int i = 0; i < 3; i++)
            {
                Console.Clear();

                Console.Write(i + 1 + " Ogrencinin adi: ");
                isim[i] = Console.ReadLine();

                Console.Write(i + 1 + " Sinav-1: ");
                s1[i] = Convert.ToInt32(Console.ReadLine());

                Console.Write(i + 1 + " Sinav-2: ");
                s2[i] = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ogrenci   Sinav-1   Sinav-2   Ortalama");

                ort[i] = (s1[i] + s2[i]) / 2;

            }

            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("  " + isim[i] + "     " + s1[i] + "       " + s2[i] + "        " + ort[i]);
            }
        }
    }
}
