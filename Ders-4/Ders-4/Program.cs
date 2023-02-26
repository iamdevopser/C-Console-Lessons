using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2, toplama, cikarma, carpma, bolme;
            Console.Write("******  ARITMETIK ISLEMLER ******");
            Console.WriteLine();
            Console.Write("1.SAYI: ");
            sayi1 = Convert.ToInt32(Console.ReadLine()); 
            Console.Write("2.SAYI: ");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            toplama = sayi1 + sayi2;
            cikarma = sayi1 - sayi2;
            carpma = sayi2 * sayi1;
            bolme = sayi1 / sayi2; 
            Console.WriteLine();
            Console.WriteLine("Toplama: " + toplama);
            Console.WriteLine("Cikarma: " + cikarma);
            Console.WriteLine("Carpma : " + carpma);
            Console.WriteLine("Bolme  : " + bolme);
            Console.WriteLine();
            Console.WriteLine("Karenin Alan ve Cevresini Bulma");
            int birkenar, kareAlan, kareCevre;
            Console.Write("Karenin bir kenar uzunlugu: ");
            birkenar = Convert.ToInt32(Console.ReadLine());
            kareAlan = birkenar * birkenar;
            kareCevre = 4 * birkenar;
            Console.WriteLine();
            Console.WriteLine("Karenin Alani  : " + kareAlan);
            Console.WriteLine("Karenin Cevresi: " + kareCevre);

            Console.ReadLine();


        }
    }
}
