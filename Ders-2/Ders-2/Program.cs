using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_2    // STRING DEGISKENLER
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ad, soyad, sehir;
            Console.WriteLine("Ad: ");
            ad = Console.ReadLine();
            Console.WriteLine("Soyad:");
            soyad = Console.ReadLine();
            Console.WriteLine("Sehir: ");
            sehir = Console.ReadLine();

            Console.WriteLine("Ad - Soyad - Sehir {0} {1} {2}", ad, soyad, sehir);
        }    
    }
}
