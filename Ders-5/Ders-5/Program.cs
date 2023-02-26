using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_5 // if else uygulamalari - 1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Ornek 1 *****");
            int sayi;
            Console.Write("Bir sayi giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi > 0)
            {
                Console.WriteLine("Pozintif sayi girdiniz.");
            }
            else  Console.WriteLine("Negatif sayi girdiniz."); 
            Console.ReadLine();

            Console.WriteLine("***** Ornek 2 *****");
            int sinav1, sinav2, ortalama;
            Console.WriteLine("***** Sinav notlariniz *****");
            Console.Write("1.Sinav Notu:");
            sinav1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2.Sinav Notu:");
            sinav2= Convert.ToInt32(Console.ReadLine());
            ortalama = (sinav1+ sinav2) / 2;
            if (ortalama >= 50)
            {
                Console.WriteLine("Dersten gectiniz.");
            }
            else Console.WriteLine("Dersten kaldiniz.");
        }
    }
}
