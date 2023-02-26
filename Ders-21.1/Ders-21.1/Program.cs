using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_21._1    // bool degiskeni - sifre dogrulama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sifre;
            Console.Write("Sayiyi girin: ");
            sifre = Convert.ToInt32(Console.ReadLine());
            bool durum1 = sifre == 1234;
            Console.WriteLine("Sayi dogru mu: {0}", durum1);
            Console.Read();
        }
    }
}
