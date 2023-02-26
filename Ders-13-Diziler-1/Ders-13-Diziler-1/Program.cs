using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_13_Diziler_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 10, 24, 36, 21, 54, 86, 91, 100 };

            Console.WriteLine(sayilar[2]);

            string[] isimler = { "Ali", "Ahmet", "Emre", "Mukremin", "Emin" };
            Console.WriteLine(isimler[4]);
            
            string[] sehirler = new string[3];

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Sehir: ");
                sehirler[i] = Console.ReadLine();
            }
            Console.WriteLine("**** Sehir Listesi ****");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(sehirler[i]);
            }
            Console.ReadLine();

        }
    }
}
