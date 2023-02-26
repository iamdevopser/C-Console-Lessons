using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_20   // Decimal ile urun satis uygulamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal urun1, urun2, toplam;
            int s1, s2;
            urun1 = 14.85M;
            urun2 = 21.48m;
            Console.Write("1.urun satis miktari: ");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2.urun satis mikari: ");
            s2 = Convert.ToInt32(Console.ReadLine());
            toplam = s1 * urun1 + s2 * urun2;
            Console.WriteLine("Urun sonunda kasada olmasi gereken tutar: " + toplam + " TL'dir.");
            Console.ReadLine();
        }
    }
}
