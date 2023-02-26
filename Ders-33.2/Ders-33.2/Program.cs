using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_33._2    // Metod cagirarak girilen sayinin kubunu hesaplatma
{
    internal class Program
    {
        private static int kupu(int sayi)
        {
            int kupdeger = sayi * sayi * sayi;
            return kupdeger;
        }
        private static void Main(string[] args)
        {
            Console.Write("Sayiyi girin: ");
            int s;
            s = Convert.ToInt16(Console.ReadLine());
            Console.Write("Sonuc: " + kupu(s));
            Console.Read();
        }
    }
}
